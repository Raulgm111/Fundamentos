﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AdoNet.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace AdoNet.Repositories
{
    #region Procedures y View
//    CREATE VIEW V_EMPLEADOS_HOSPITAL
//AS
//    SELECT DOCTOR_NO AS IDEMPLEADO, APELLIDO, SALARIO, HOSPITAL_COD
//    FROM DOCTOR
//    UNION
//    SELECT EMPLEADO_NO, APELLIDO, SALARIO, HOSPITAL_COD FROM PLANTILLA
//GO


//ALTER PROCEDURE SP_EMPLEADOS_HOSPITAL2
//(@NOMBRE NVARCHAR(50)
//, @SUMA INT OUT, @MEDIA INT OUT, @PERSONAS INT OUT) 
//AS
//    DECLARE @IDHOSPITAL INT
//    SELECT @IDHOSPITAL = HOSPITAL_COD FROM HOSPITAL
//    WHERE NOMBRE = @NOMBRE
//    SELECT* FROM V_EMPLEADOS_HOSPITAL
//    WHERE HOSPITAL_COD = @IDHOSPITAL
//    SELECT @SUMA = SUM(SALARIO), @MEDIA = AVG(SALARIO)
//    , @PERSONAS = COUNT(IDEMPLEADO) FROM V_EMPLEADOS_HOSPITAL
//    WHERE HOSPITAL_COD = @IDHOSPITAL
//GO
    #endregion
    public class RepositoryHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        
        public RepositoryHospital()
        {
            IConfigurationBuilder builder= new ConfigurationBuilder().AddJsonFile("config.json",true,true);
            IConfigurationRoot config=builder.Build();

            string connectionString =
                "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
        }

        //NECESITMAOS UN METODO PARA DEVOLVER TODOS LOS HOSPITALES
        public List<string> GetHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            List<string> hospitales = new List<string>();
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public DatosHospital GetDatosHospital(string nombre)
        {
            SqlParameter paranombre = new SqlParameter("@NOMBRE", nombre);
            this.com.Parameters.Add(paranombre);
            SqlParameter pamsuma = new SqlParameter("@SUMA", 0);
            pamsuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamsuma);
            SqlParameter pammedia = new SqlParameter("@MEDIA", 0);
            pammedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pammedia);
            SqlParameter pampersonas = new SqlParameter("@PERSONAS", 0);
            pampersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pampersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_HOSPITAL2";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<EmpleadoHospital>empleados = new List<EmpleadoHospital>();
            while (this.reader.Read())
            {
                //int idEmpleado = int.Parse(this.reader["IDEMPLEADO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                EmpleadoHospital empleado = new EmpleadoHospital();
                //empleado.IdEmpleado = idEmpleado;
                empleado.Apellido = apellido;
                empleado.Salario= salario;
                empleados.Add(empleado);
            }
            this.reader.Close();
            DatosHospital datos=new DatosHospital();
            datos.Empleados = empleados;
            datos.SumaSalarial = int.Parse(pamsuma.Value.ToString());
            datos.MediaSalarial = int.Parse(pammedia.Value.ToString());
            datos.Personas = int.Parse(pampersonas.Value.ToString());

            this.cn.Close();
            this.com.Parameters.Clear();
            return datos;
        }
    }
}
