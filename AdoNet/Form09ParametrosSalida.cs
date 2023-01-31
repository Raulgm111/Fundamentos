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
//--NO QUEREMOS LOCALIDADES EN TERUEL
//IF(@LOCALIDADHOSP= 'TERUEL')
//BEGIN
//    PRINT 'TERUEL NO EXISTE'
//END
//ELSE BEGIN
//INSERT INTO DEPT VALUES
//        (@DEPARTAMETOCOD, @NOMBREHOSP, @LOCALIDADHOSP)

//        END
//GO
    #endregion
    public partial class Form09ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form09ParametrosSalida()
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
            this.comboDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.comboDepartamentos.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void comboDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectEmpleados();
        }

        private void SelectEmpleados()
        {
            string nombre = this.comboDepartamentos.SelectedItem.ToString();
            SqlParameter paranombre = new SqlParameter("@NOMBRE", nombre);
            this.com.Parameters.Add(paranombre);
            //DECLARAMOS LOS PARAMETROS DE SALIDA
            SqlParameter pamsuma = new SqlParameter("@SUMA",0);
            pamsuma.Direction=ParameterDirection.Output;
            this.com.Parameters.Add(pamsuma);
            SqlParameter pammedia = new SqlParameter("@MEDIA",0);
            pammedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pammedia);
            SqlParameter pampersonas = new SqlParameter("@PERSONAS",0);
            pampersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pampersonas);


            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_SELECT_DEPT_EMP";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.listEmpleados.Items.Add(apellido+" - "+salario);
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
