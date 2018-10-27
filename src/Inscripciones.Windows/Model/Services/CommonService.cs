using Inscripciones.Windows.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripciones.Windows.Model.Services
{
    public static class CommonService
    {
        public static List<Escuela> GetAllEscuelas()
        {
            
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Inscripciones"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("Select * From Escuelas", conn);

            List<Escuela> escuelas = new List<Escuela>();

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var escuela = new Escuela();

                escuela.Id = Convert.ToInt32(reader["Id"]);
                escuela.Nombre = reader["Nombre"].ToString();

                escuelas.Add(escuela);
            }

            conn.Close();


            return escuelas;
        }

    }
}
