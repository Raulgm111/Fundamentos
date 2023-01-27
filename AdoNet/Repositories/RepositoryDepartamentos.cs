using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AdoNet.Models;
using System.Data;

namespace AdoNet.Repositories
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentos()
        {
            string connectionString =
                "Data Source=LOCALHOST\\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<Departamento> GetDepartamentos()
        {
            string sql = "SELECT * FROM DEPT";
            List<Departamento> departamentos = new List<Departamento>();
            this.com.CommandType = CommandType.Text;
            this.com.CommandText= sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                Departamento dept=new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = localidad;
                departamentos.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public int DeleteDepartamento(int id)
        {
            string sql = "DELETE FROM DEPT WHERE DEPT_NO=@NUM";
            SqlParameter pamnum = new SqlParameter("@NUM", id);
            this.com.Parameters.Add(pamnum);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return eliminados;
        }

        public int UpdateDepartamentos(int id, string nombre, string localidad)
        {
            string sql = "UPDATE DEPT SET DNOMBRE=@NOM,LOC=@LOC WHERE DEPT_NO=@NUM";
            SqlParameter pamnum = new SqlParameter("@NUM", id);
            SqlParameter pamnom = new SqlParameter("@NOM", nombre);
            SqlParameter pamloc = new SqlParameter("@LOC", localidad);
            this.com.Parameters.Add(pamnum);
            this.com.Parameters.Add(pamnom);
            this.com.Parameters.Add(pamloc);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return modificados;
        }

        public int InsertDepartamentos(int id,string nombre,string localidad)
        {
            string sql = "INSERT INTO DEPT VALUES (@NUM,@NOM,@LOC)";
            SqlParameter pamnum = new SqlParameter("@NUM", id);
            SqlParameter pamnom = new SqlParameter("@NOM", nombre);
            SqlParameter pamloc = new SqlParameter("@LOC", localidad);
            this.com.Parameters.Add(pamnum);
            this.com.Parameters.Add(pamnom);
            this.com.Parameters.Add(pamloc);
            this.com.CommandType=CommandType.Text;
            this.com.CommandText=sql;
            this.cn.Open();
            int insertados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return insertados;
        }
    }
}
