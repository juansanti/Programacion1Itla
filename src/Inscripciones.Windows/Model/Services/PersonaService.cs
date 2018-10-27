using Dapper;
using Inscripciones.Windows.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripciones.Windows.Model.Services
{
    static class PersonaService
    {
        public static int InsertarPersona(Persona persona)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Inscripciones"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);

            string sqlCommand = @"INSERT INTO [dbo].[Personas]
           ([Nombre]
           ,[Apellido]
           ,[Sexo]
           ,[EscuelaId])
     VALUES
           (@nombre, @apellido, @sexo, @escuelaId)";

            SqlCommand cmd = new SqlCommand(sqlCommand, conn);
           
            cmd.Parameters.AddWithValue("@nombre", persona.Nombre);
            cmd.Parameters.AddWithValue("@apellido", persona.Apellido);
            cmd.Parameters.AddWithValue("@sexo", persona.Sexo);
            cmd.Parameters.AddWithValue("@escuelaId", persona.EscuelaId);

            conn.Open();

            var rowsAffected = cmd.ExecuteNonQuery();
            
            conn.Close();

            return rowsAffected;

        }

        public static List<Persona> GetAllPersonas()
        {
            List<Persona> personas = new List<Persona>();

            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Inscripciones"].ConnectionString;

            using (SqlConnection conn =
                new SqlConnection("Data Source=.;Initial Catalog=Inscripciones;Integrated Security=true"))
            {
                personas = conn.Query<Persona>("Select * from Personas").ToList();
            }


            return personas;
        }
    }
}
