using MarchPark.ENT.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
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

        #region GERENCIAMENTO

        /// <summary>
        /// Método para alterar a senha de permissão.
        /// </summary>
        /// <param name="SenhaNova"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_SENHA_PERMISSAO(string SenhaNova)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                UPDATE MarchPark_TBL_PERMISSAO
                                SET SENHA_PERMISSAO = '{SenhaNova}'
                                ";

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

        /// <summary>
        /// Método para alterar a tarifa.
        /// </summary>
        /// <param name="TarifaCarro"></param>
        /// <param name="TarifaMoto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_TARIFA(string TarifaCarro, string TarifaMoto)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                UPDATE MarchPark_TBL_TARIFA
                                SET VALOR_TARIFA = 
                                    CASE 
                                        WHEN TIPO_VEICULO = 'Carro' THEN {TarifaCarro}  -- novo valor para carro
                                        WHEN TIPO_VEICULO = 'Moto' THEN {TarifaMoto}    -- novo valor para moto
                                    END
                                ";

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

        /// <summary>
        /// Método para selecionar o valor da tarifa atual.
        /// </summary>
        /// <param name="VeiculoTarifa"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string SELECT_VALOR_TARIFA_ATUAL(string VeiculoTarifa)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                SELECT 
	                                VALOR_TARIFA
                                FROM MarchPark_TBL_TARIFA
                                WHERE TIPO_VEICULO = '{VeiculoTarifa}'
                                 ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    string a = cmd.ExecuteScalar().ToString();
                    return cmd.ExecuteScalar().ToString();
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
        /// Método para selecionar todos os usuarios do sistema.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_USUARIOS_MARCH_PARK()
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                DataTable dt = new DataTable();
                //SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = $@"
                                 SELECT 
                                    NOME_USUARIO AS 'Usuários'
                                 FROM MarchPark_TBL_LOGIN
                                 ORDER BY NOME_USUARIO
                                 ";

                //SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandTimeout = 30000;
                //adapter.SelectCommand = cmd; // define o comando SQL para o SqlDataAdapter
                //adapter.Fill(dt); // preenche o DataTable com os resultados da consulta
                //return dt;

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
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
        /// Método para deletar usuários do sistema.
        /// </summary>
        /// <param name="ListaUsuarios"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DELETAR_USUARIOS_MARCH_PARK(List<string> ListaUsuarios)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string usuariosWhereIn = string.Join(", ", ListaUsuarios.ConvertAll(u => $"'{u}'"));

                string sql = $@"
                                DELETE 
                                FROM MarchPark_TBL_LOGIN
                                WHERE NOME_USUARIO IN ({usuariosWhereIn})
                                ";

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

        #region CAD CLIENTE

        /// <summary>
        /// Método para consultar clientes.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_CLIENTES()
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = $@"
                                 SELECT
                                    ID_CLIENTE,
	                                NOME_CLIENTE AS NOME,
	                                CONCAT(CPF_CLIENTE, CPF_CONTROLE) AS CPF,
	                                DATA_NASCIMENTO AS NASCIMENTO,
	                                CONCAT(NUMERO_DDD, NUMERO_TELEFONE) AS TELEFONE,
	                                ENDERECO_EMAIL AS EMAIL
                                FROM MarchPark_TBL_CLIENTE
                                 ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandTimeout = 30000;
                adapter.SelectCommand = cmd; // define o comando SQL para o SqlDataAdapter
                adapter.Fill(dt); // preenche o DataTable com os resultados da consulta
                return dt;
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
        /// Método para pesquisar clientes especifícos.
        /// </summary>
        /// <param name="NomeDigitado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable PESQUISAR_CLIENTES_ESPECIFICO(string NomeDigitado)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = $@"
                                  SELECT
                                      ID_CLIENTE,
                                      NOME_CLIENTE AS NOME,
                                      CONCAT(CPF_CLIENTE, CPF_CONTROLE) AS CPF,
                                      DATA_NASCIMENTO AS NASCIMENTO,
                                      CONCAT(NUMERO_DDD, NUMERO_TELEFONE) AS TELEFONE,
                                      ENDERECO_EMAIL AS EMAIL
                                  FROM MarchPark_TBL_CLIENTE
                                  WHERE NOME_CLIENTE LIKE '{NomeDigitado}%'
                                 ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandTimeout = 30000;
                adapter.SelectCommand = cmd; // define o comando SQL para o SqlDataAdapter
                adapter.Fill(dt); // preenche o DataTable com os resultados da consulta
                return dt;
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
        /// Método para inserir cliente.
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="Cpf"></param>
        /// <param name="DataNascimento"></param>
        /// <param name="NumeroTelefone"></param>
        /// <param name="Email"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_CLIENTE(string Nome, string Cpf, string DataNascimento, string NumeroTelefone, string Email)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                INSERT INTO MarchPark_TBL_CLIENTE (NOME_CLIENTE, CPF_CLIENTE, CPF_CONTROLE, DATA_NASCIMENTO, NUMERO_DDD, NUMERO_TELEFONE, ENDERECO_EMAIL) 
                                VALUES (@nome, @cpf, @cpf_controle, @data_nascimento, @num_ddd, @num_telefone, @email)
                                ";

                // Usando a conexão com o banco
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@cpf", Cpf.Substring(0, 9));
                    cmd.Parameters.AddWithValue("@cpf_controle", Cpf.Substring(9, 2));
                    cmd.Parameters.AddWithValue("@data_nascimento", DataNascimento);

                    // Aqui, verifica se o telefone é null
                    if (string.IsNullOrEmpty(NumeroTelefone))
                    {
                        cmd.Parameters.AddWithValue("@num_ddd", DBNull.Value); // Passa NULL para o SQL
                        cmd.Parameters.AddWithValue("@num_telefone", DBNull.Value); // Passa NULL para o SQL
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@num_ddd", NumeroTelefone.Substring(0, 2)); // Passa NULL para o SQL
                        cmd.Parameters.AddWithValue("@num_telefone", NumeroTelefone.Substring(2, 9)); // Passa NULL para o SQL
                    }
                 
                    // Aqui, verifica se o email é null
                    if (string.IsNullOrEmpty(Email))
                    {
                        cmd.Parameters.AddWithValue("@email", DBNull.Value); // Passa NULL para o SQL
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@email", Email); // Passa o valor do email
                    }

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
