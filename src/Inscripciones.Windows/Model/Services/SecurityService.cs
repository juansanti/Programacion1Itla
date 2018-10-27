using Dapper;
using Inscripciones.Windows.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inscripciones.Windows.Model.Services
{
    public static class SecurityService
    {
        public static string Hash(string inputString)
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(inputString));

            StringBuilder bldr = new StringBuilder();

            foreach (var b in hash)
            {
                bldr.Append(b.ToString());
            }
            return bldr.ToString();
        }

        public static Usuario Login(string login, string passwordUnHased)
        {
            var password = Hash(passwordUnHased);

            Usuario usuario;

            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Inscripciones"].ConnectionString;

            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                usuario = conn.Query<Usuario>("Select * from Usuarios where Login = @login and Password = @password", 
                    new {
                        login = login,
                        password = password
                    }).FirstOrDefault();
            }
            

            return usuario;
        }
    }
}
