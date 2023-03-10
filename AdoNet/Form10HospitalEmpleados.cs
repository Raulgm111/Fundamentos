using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AdoNet
{
    #region PROCEDURES Y VIEWS
//    CREATE PROCEDURE SP_HOSPITALES
//AS

//    SELECT* FROM HOSPITAL
//GO

//    ALTER PROCEDURE SP_EMPLEADOS_HOSPITAL
//(@NOMBRE NVARCHAR(50),
//@SUMA INT OUT,
//@MEDIA INT OUT,
//@PERSONAS INT OUT)
//AS
//    DECLARE @IDHOSPITAL INT

    //    SELECT @IDHOSPITAL = HOSPITAL_COD FROM HOSPITAL

    //    WHERE NOMBRE = @NOMBRE


    //    SELECT plantilla.APELLIDO, PLANTILLA.SALARIO FROM PLANTILLA WHERE PLANTILLA.HOSPITAL_COD= @IDHOSPITAL

    //    UNION
    //    SELECT DOCTOR.APELLIDO, DOCTOR.SALARIO FROM DOCTOR WHERE DOCTOR.HOSPITAL_COD= @IDHOSPITAL


    //    SELECT @SUMA = SUM(QUERY.SALARIO), @MEDIA = AVG(QUERY.SALARIO), @PERSONAS = COUNT(QUERY.APELLIDO)

    // FROM

    // (SELECT D.APELLIDO, D.SALARIO FROM DOCTOR D

    // WHERE D.HOSPITAL_COD= @IDHOSPITAL

    // UNION
    // SELECT P.APELLIDO, P.SALARIO FROM PLANTILLA P

    // WHERE P.HOSPITAL_COD= @IDHOSPITAL)

    // QUERY
    //GO
    #endregion
    public partial class Form10HospitalEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form10HospitalEmpleados()
        {
            InitializeComponent();
            string connectionString =
                "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
            this.LoadHospitales();

        }

        private void LoadHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.comboHospitales.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.comboHospitales.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void comboHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = this.comboHospitales.SelectedItem.ToString();
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
            this.listEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.listEmpleados.Items.Add(apellido + " - " + salario);
            }
            this.reader.Close();

            this.txtSuma.Text = pamsuma.Value.ToString();
            this.txtMedia.Text = pammedia.Value.ToString();
            this.txtPersonas.Text = pampersonas.Value.ToString();

            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
