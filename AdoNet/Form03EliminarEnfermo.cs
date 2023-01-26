using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form03EliminarEnfermo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermo()
        {
            InitializeComponent();
            string connectionString =
                "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadEnfermos();
        }
        private void LoadEnfermos()
        {
            string sqp = "SELECT * FROM ENFERMO";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sqp;
            this.cn.Open();
            this.reader=this.com.ExecuteReader();
            this.listEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.listEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
