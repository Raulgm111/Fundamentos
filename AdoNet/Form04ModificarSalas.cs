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
    public partial class Form04ModificarSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04ModificarSalas()
        {
            InitializeComponent();
            string connectionString =
                "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn=new SqlConnection(connectionString);
            this.com=new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadSalas();

        }
        private void LoadSalas()
        {
            string sql = "SELECT * FROM SALA";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listSalas.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.listSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string sala = this.txtxNuevoNombre.Text;
            int indice = this.listSalas.SelectedIndex;

            string sql = "UPDATE SALA SET NOMBRE=(SELECT NOMBRE FROM SALA WHERE SALA.NOMBRE=@NOMBRE)";
            SqlParameter pamisala = new SqlParameter("@NOMBRE", this.listSalas.Items[indice]);
            SqlParameter pamisala2 = new SqlParameter("@NOMBRE", sala);
            this.com.Parameters.Add(pamisala);
            this.com.Parameters.Add(pamisala2);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificado = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Sala modificada: " + modificado);
            this.LoadSalas();
        }
    }
}
