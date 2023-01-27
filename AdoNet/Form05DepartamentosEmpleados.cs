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
    public partial class Form05DepartamentosEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form05DepartamentosEmpleados()
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
            string sql = "SELECT DNOMBRE FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.listDepartamentos.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();

        }

        private void SeleccionarDepartamentos()
        {
            string sql = "SELECT EMP.APELLIDO FROM EMP RIGHT JOIN DEPT ON DEPT.DEPT_NO=EMP.DEPT_NO WHERE DEPT.DNOMBRE=@ITEMSDEP";
            string ItemsDep = this.listDepartamentos.SelectedItem.ToString();
            SqlParameter selectDep = new SqlParameter("@ITEMSDEP", ItemsDep);
            this.com.Parameters.Add(selectDep);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.listEmpleados.Items.Add(apellido);
            }
            this.com.Parameters.Clear();
            this.reader.Close();
            this.cn.Close();
        }

        private void UpdateEmpleados()
        {
            string sql = "UPDATE EMP SET SALARIO=@NEWSALARIO WHERE APELLIDO=@APELLIDO";
            string newsalario = this.txtSalario.Text;
            string empleado = this.listEmpleados.SelectedItem.ToString();
            SqlParameter panew = new SqlParameter("@NEWSALARIO", newsalario);
            SqlParameter paold = new SqlParameter("@APELLIDO", empleado);
            this.com.Parameters.Add(panew);
            this.com.Parameters.Add(paold);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificado = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Salario modificado: " + modificado);

        }

        private void UpdateOficio()
        {
            string sql = "UPDATE EMP SET OFICIO=@NEWOFICIO WHERE APELLIDO=@APELLIDO";
            string newoficio = this.txtOficio.Text;
            string empleado = this.listEmpleados.SelectedItem.ToString();
            SqlParameter panew = new SqlParameter("@NEWOFICIO", newoficio);
            SqlParameter paold = new SqlParameter("@APELLIDO", empleado);
            this.com.Parameters.Add(panew);
            this.com.Parameters.Add(paold);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificado = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Oficio modificado: " + modificado);

        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            this.UpdateEmpleados();
            this.UpdateOficio();
        }

        private void listDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SeleccionarDepartamentos();
        }

        private void listEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listEmpleados.SelectedIndex != -1)
            {
                string sql = "SELECT OFICIO, SALARIO FROM EMP WHERE APELLIDO=@APELLIDO";
                string apellido = this.listEmpleados.SelectedItem.ToString();
                SqlParameter pamapellido = new SqlParameter("@APELLIDO", apellido);
                this.com.Parameters.Add(pamapellido);
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                this.cn.Open();
                this.reader = this.com.ExecuteReader();
                this.reader.Read();
                string oficio = this.reader["OFICIO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.txtOficio.Text = oficio;
                this.txtSalario.Text = salario;
                this.reader.Close();
                this.cn.Close();
                this.com.Parameters.Clear();

            }
        }
    }
}
