using MarchPark.ENT.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarchPark.DAD
{
    /// <summary>
    /// Classe de CRUD DADOS.
    /// </summary>
    public class CRUD_DADOS
    {
        #region ADM

        /// <summary>
        /// Método para consultar senha permissao.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_MARCH_PARK_TBL_PERMISSAO(string Senha)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                // Query SQL com collation case-sensitive
                string sql = $@"
                    DECLARE @senha VARCHAR(25) = '{Senha}'

                    SELECT * 
                    FROM MarchPark_TBL_PERMISSAO
                    WHERE SENHA_PERMISSAO COLLATE Latin1_General_CS_AS = @senha;
                    ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Executa a consulta e obtém os resultados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Retorna true se houver resultados, false caso contrário
                        return reader.HasRows;
                    }
                }
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

        #endregion

        #region LOGIN

        /// <summary>
        /// Método para consultar usuários (Login).
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public bool SELECT_MARCH_PARK_TBL_LOGIN(string Usuario, string Senha)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                // Query SQL com collation case-sensitive
                string sql = $@"
                                DECLARE @usuario VARCHAR(25) = '{Usuario}'
                                DECLARE @senha VARCHAR(25) = '{Senha}'

                                SELECT * 
                                FROM MarchPark_TBL_LOGIN
                                WHERE NOME_USUARIO COLLATE Latin1_General_CS_AS = @usuario
                                AND SENHA_USUARIO COLLATE Latin1_General_CS_AS = @senha;
                                ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Executa a consulta e obtém os resultados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Retorna true se houver resultados, false caso contrário
                        return reader.HasRows;
                    }
                }
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

        /// <summary>
        /// Método para consultar se o usuário já existe.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<MarchPark_TBL_LOGIN> SELECT_MARCH_PARK_TBL_LOGIN_EXISTENTE(MarchPark_TBL_LOGIN Ent)
        {
            try
            {
                using (MarchPark.DAD.ConnectionFactory db = new ConnectionFactory())
                {
                    List<MarchPark_TBL_LOGIN> listaUsuarios = (from TBL_LOGIN in db.GetTable<MarchPark_TBL_LOGIN>()
                                                             where TBL_LOGIN.NOME_USUARIO == Ent.NOME_USUARIO
                                                             select TBL_LOGIN).ToList();
                    return listaUsuarios;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir usuário (Login).
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_MARCH_PARK_TBL_LOGIN(MarchPark_TBL_LOGIN Ent)
        {
            try
            {
                using (MarchPark.DAD.ConnectionFactory db = new ConnectionFactory())
                {
                    db.GetTable<MarchPark.ENT.Login.MarchPark_TBL_LOGIN>().InsertOnSubmit(Ent);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Consulta para pegar o usuário ativo no sistema.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string SELECT_NOME_USUARIO_ATIVO(MarchPark_TBL_LOGIN Ent)
        {
            try
            {
                using (MarchPark.DAD.ConnectionFactory db = new ConnectionFactory())
                {
                    string usuario = (from TBL_LOGIN in db.GetTable<MarchPark_TBL_LOGIN>()
                                   where TBL_LOGIN.NOME_USUARIO == Ent.NOME_USUARIO
                                   select TBL_LOGIN.NOME_USUARIO).FirstOrDefault().ToString();

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region USUARIO ATIVO

        /// <summary>
        /// Método para validar a senha atual do usuário.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public bool VALIDAR_SENHA_ATUAL_USUARIO_ATIVO(string Usuario, string Senha)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                // Query SQL com collation case-sensitive
                string sql = $@"
                                DECLARE @usuario VARCHAR(25) = '{Usuario}'
                                DECLARE @senha VARCHAR(25) = '{Senha}'

                                SELECT * 
                                FROM MarchPark_TBL_LOGIN
                                WHERE NOME_USUARIO COLLATE Latin1_General_CS_AS = @usuario
                                AND SENHA_USUARIO COLLATE Latin1_General_CS_AS = @senha;
                                ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Executa a consulta e obtém os resultados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Retorna true se houver resultados, false caso contrário
                        return reader.HasRows;
                    }
                }
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

        /// <summary>
        /// Método para alterar senha/usuario do usuario ativo.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_USUARIO_SENHA_ATIVO(string UsuarioAtual, string UsuarioNovo, string SenhaNova, int TipoQuery)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = "";
                switch (TipoQuery)
                {
                    case 1: // usuario e senha
                        // Query SQL com collation case-sensitive
                        sql = $@"
                                        DECLARE @nome_usuario VARCHAR(25) = '{UsuarioAtual}'
                                        DECLARE @nome_novo VARCHAR(25) = '{UsuarioNovo}'
                                        DECLARE @senha VARCHAR(25) = '{SenhaNova}'

                                        UPDATE MarchPark_TBL_LOGIN
                                        SET NOME_USUARIO = @nome_novo, SENHA_USUARIO = @senha
                                        WHERE NOME_USUARIO COLLATE Latin1_General_CS_AS = @nome_usuario
                                        ";
                        break;
                    case 2: // usuario
                        // Query SQL com collation case-sensitive
                        sql = $@"
                                        DECLARE @nome_usuario VARCHAR(25) = '{UsuarioAtual}'
                                        DECLARE @nome_novo VARCHAR(25) = '{UsuarioNovo}'

                                        UPDATE MarchPark_TBL_LOGIN
                                        SET NOME_USUARIO = @nome_novo
                                        WHERE NOME_USUARIO COLLATE Latin1_General_CS_AS = @nome_usuario
                                        ";
                        break;
                    case 3: // senha
                        // Query SQL com collation case-sensitive
                        sql = $@"
                                        DECLARE @nome_usuario VARCHAR(25) = '{UsuarioAtual}'
                                        DECLARE @senha VARCHAR(25) = '{SenhaNova}'

                                        UPDATE MarchPark_TBL_LOGIN
                                        SET SENHA_USUARIO = @senha
                                        WHERE NOME_USUARIO COLLATE Latin1_General_CS_AS = @nome_usuario
                                        ";
                        break;
                }

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Executa a consulta e verifica o número de linhas afetadas
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Retorna true se uma linha foi atualizada, false caso contrário
                    return rowsAffected > 0;
                }
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

        #endregion
    }
}
