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
                "Data Source=LOCALHOST\\DESARROLLO;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            //SIEMPRE CONNECTIONSTRING EN EL CONSTRUCTOR
            this.cn = new SqlConnection(this.connectionString);
            this.com=new SqlCommand();
            
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
    }
}
