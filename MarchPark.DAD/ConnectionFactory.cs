using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;

namespace MarchPark.DAD
{
    public class ConnectionFactory : DataContext
    {
        /// <summary>
        /// String de conexão
        /// </summary>
        public static string connectionString = "Server=DESKTOP-FFELNCC;Database=PROJETOS;Trusted_Connection=True;"; // "Server=*servidor*;Database=*nome_db*;Trusted_Connection=True;"
        /// <summary>
        /// String de conexão
        /// </summary>
        public ConnectionFactory() : base("Server=DESKTOP-FFELNCC;Database=PROJETOS;Trusted_Connection=True;") { }
    }
}
