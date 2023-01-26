using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString =
                "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            //SIEMPRE CONNECTIONSTRING EN EL CONSTRUCTOR
            this.cn = new SqlConnection(this.connectionString);
            this.com=new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
            
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion esta cambiando de "
                + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                this.lblMensaje.BackColor = Color.LightGreen;
            }catch(Exception ex)
            {
                this.lblMensaje.Text = "Error al conectar con BBDD. " + ex;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.LightCoral;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM EMP";
            //INDICMAOS LA CONEXION QUE VAMOS A UTILIZAR
            this.com.Connection = this.cn;
            //INICAMOS EL TIPO DE CONSULTA
            this.com.CommandType=CommandType.Text;
            //INDICAMOS LA CONSULTA
            this.com.CommandText = sql;
            //CON TODO CONFIGURADO, PARA EJECUTAR LA CONSULTA
            //DEBEMOS TENER UNA CONEXION ABIERTA
            //EJECUTAMOS LA CONSULTA Y EXTRAEMOS EL READER
            this.reader = this.com.ExecuteReader();
            //DIBUJAMOS LA PRIMERA COLUMNA DE LA TABLA
            string columna = this.reader.GetName(0);
            //DIBUJAMOS EL TIPO DE LA PRIMERA COLUMNA DE LA TABLA
            string tipo=this.reader.GetDataTypeName(0);
            this.listColumnas.Items.Add(columna);
            this.listTipoDato.Items.Add(tipo);
            //PARA ACCCEDER A LOS DATOS DEBEMOS LEER
            while (this.reader.Read())
            {
                //VAMOS A RECUPERAR UN APELLIDO
                string apellido = this.reader["APELLIDO"].ToString();
                this.listApellidos.Items.Add(apellido);
            }
        }
    }
}
