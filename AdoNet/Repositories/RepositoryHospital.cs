using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AdoNet.Models;

namespace AdoNet.Repositories
{
    public class RepositoryHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        
        public RepositoryHospital()
        {
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
            //hospitales.Clear();
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
            this.com.CommandText = "SP_EMPLEADOS_HOSPITAL";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<EmpleadoHospital>empleados = new List<EmpleadoHospital>();
            while (this.reader.Read())
            {
                int idEmpleado = int.Parse(this.reader["APELLIDO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                EmpleadoHospital empleado = new EmpleadoHospital();
                empleado.IdEmpleado = idEmpleado;
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
