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
        public Departamento FindDepartamento(int id)
        {
            string sql = "SELECT * FROM DEPT WHERE DEPT_NO=@NUMERO";
            SqlParameter pamid = new SqlParameter("@NUMERO", id);
            this.com.Parameters.Add(pamid);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            Departamento dept = new Departamento();
            dept.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
            dept.Nombre = this.reader["DNOMBRE"].ToString();
            dept.Localidad = this.reader["LOC"].ToString();
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return dept;
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
        private int GetMaxIdDepartamento()
        {
            string sql = "SELECT MAX(DEPT_NO) + 1 AS MAXIMO FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            //SI LA CONSULTA CONTIENE SOLAMENTE UNA FILA Y UN DATO        //NO ES NECESARIO UN READER, PODEMOS UTILIZAR EL METODO        //ExecuteScalar()
            int maximo = Convert.ToInt32(this.com.ExecuteScalar());
            this.cn.Close();
            return maximo;
        }



        public int InsertDepartamentos(int id,string nombre,string localidad)
        {
            //int id = this.GetMaxIdDepartamento();
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
