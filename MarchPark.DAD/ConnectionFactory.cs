using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;

namespace MarchPark.DAD
{
    /// <summary>
    /// Classe de conexão.
    /// </summary>
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

        /// <summary>
        /// Função para executar uma procedure sem retorno.
        /// </summary>
        /// <param name="NomeProcedure"></param>
        /// <param name="Prms"></param>
        /// <exception cref="Exception"></exception>
        public void EXECUTA_SP_SEM_RETORNO(string NomeProcedure, SqlParameter[] Prms)
        {
            MarchPark.DAD.ConnectionFactory db = new MarchPark.DAD.ConnectionFactory();
            SqlConnection conn = new SqlConnection(db.Connection.ConnectionString);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(NomeProcedure, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (Prms != null)
                {
                    cmd.Parameters.AddRange(Prms);
                }
                //cmd.Parameters.AddRange(Prms);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
