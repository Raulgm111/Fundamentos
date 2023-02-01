using AdoNet.Helpers;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryPrubaPersonaje
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryPrubaPersonaje()
        {
            string connectionString = HelperConfiguration.GetConnectionString2();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;
        }

        public List<string> GetSeries()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_SERIES";
            List<string> series = new List<string>();
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombreSerie= this.reader["nombre"].ToString();
                series.Add(nombreSerie);
            }
            this.reader.Close();
            this.cn.Close();
            return series;
        }

        public DatosPrubaPersonaje GetDatosSeries(string nombre)
        {
            SqlParameter paranombre = new SqlParameter("@NOMBRE", nombre);
            this.com.Parameters.Add(paranombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_SEREIS_PERSONAJES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<PruebaSeriesPersonajes> personajes = new List<PruebaSeriesPersonajes>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["idPersonaje"].ToString());
                string nombrePersonaje = this.reader["nombre"].ToString();
                PruebaSeriesPersonajes personaje = new PruebaSeriesPersonajes();
                personaje.IdPersonaje = id;
                personaje.NombrePersonaje = nombrePersonaje;
                personajes.Add(personaje);
            }
            this.reader.Close();
            DatosPrubaPersonaje datos = new DatosPrubaPersonaje();
            datos.Personajes = personajes;

            this.cn.Close();
            this.com.Parameters.Clear();
            return datos;
        }

        public void DeletePersonaje(int id)
        {
            SqlParameter pamid = new SqlParameter("@IDPERSONAJE", id);
            this.com.Parameters.Add(pamid);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_SEREIS_PERSONAJES_ELIMINAR";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.cn.Close();
            this.reader.Close();
            this.com.Parameters.Clear();
        }

    }

}
