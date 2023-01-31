using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AdoNet
{
    #region PROCEDIMINETOS USADOS
//    CREATE PROCEDURE SP_DEPARTAMENTOS
//    AS

//    SELECT* FROM DEPT
//GO

//alter PROCEDURE SP_INSERT_DEPARTAMENTO
//(@DEPARTAMETOCOD INT,
//@NOMBREHOSP NVARCHAR(50),
// @LOCALIDADHOSP NVARCHAR(50))
//AS
//INSERT INTO DEPT VALUES
//        (@DEPARTAMETOCOD, @NOMBREHOSP, @LOCALIDADHOSP)
//GO
    #endregion
    public partial class Form08MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form08MensajesServidor()
        {
            InitializeComponent();
            string connectionString =
                "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                this.listDepartamentos.Items.Add(id+", " +nombre+", "+ localidad);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad=this.txtLocalidad.Text;
            SqlParameter paraid = new SqlParameter("@DEPARTAMETOCOD", id);
            SqlParameter paranombre = new SqlParameter("@NOMBREHOSP", nombre);
            SqlParameter paraloc = new SqlParameter("@LOCALIDADHOSP", localidad);
            this.com.Parameters.Add(paraid);
            this.com.Parameters.Add(paranombre);
            this.com.Parameters.Add(paraloc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_INSERT_DEPARTAMENTO";
            this.cn.Open();
            int insertados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.LoadDepartamentos();
            MessageBox.Show("Registro insertado "+ insertados);
        }
    }
}
