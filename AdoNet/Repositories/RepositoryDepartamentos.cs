using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

        public int InsertDepartamentos(int id,string nombre,string localidad)
        {
            string sql = "INSERT INTO DEPT VALUES (@NUM,@NOM,@LOC)";
            SqlParameter pamnum = new SqlParameter("@NUM", id);
            SqlParameter pamnom = new SqlParameter("@NOM", id);
            SqlParameter pamloc = new SqlParameter("@LOC", id);
            this.com.Parameters.Add(pamnum);
            this.com.Parameters.Add(pamnom);
            this.com.Parameters.Add(pamloc);
            this.com.CommandType=System.Data.CommandType.Text;
            this.com.CommandText=sql;
            this.cn.Open();
            int insertados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return insertados;
        }
    }
}
