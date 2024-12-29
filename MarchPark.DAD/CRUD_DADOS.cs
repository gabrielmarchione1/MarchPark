using MarchPark.ENT.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
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
                                ORDER BY NOME_CLIENTE ASC
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
                                  ORDER BY NOME_CLIENTE ASC
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

        /// <summary>
        /// Método para verificar se o cliente já existe.
        /// </summary>
        /// <param name="Cpf"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_CLIENTE_EXISTENTE(string Cpf)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                SELECT *
                                FROM MarchPark_TBL_CLIENTE
                                WHERE CONCAT(CPF_CLIENTE, CPF_CONTROLE) = '{Cpf}'
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
        /// Método para alterar cliente.
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="Cpf"></param>
        /// <param name="DataNascimento"></param>
        /// <param name="NumeroTelefone"></param>
        /// <param name="Email"></param>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_CLIENTE(string Nome, string Cpf, string DataNascimento, string NumeroTelefone, string Email, int IdCliente)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                UPDATE MarchPark_TBL_CLIENTE
	                                SET 
		                                NOME_CLIENTE = @nome,
		                                CPF_CLIENTE = @cpf,
		                                CPF_CONTROLE = @cpf_controle,
		                                DATA_NASCIMENTO = @data_nascimento,
		                                NUMERO_DDD = @num_ddd,
		                                NUMERO_TELEFONE = @num_telefone,
		                                ENDERECO_EMAIL = @email
                                WHERE ID_CLIENTE = {IdCliente}
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

        /// <summary>
        /// Método para verificar se o cliente já existe (para alteração).
        /// </summary>
        /// <param name="Cpf"></param>
        /// <param name="Nome"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_CLIENTE_EXISTENTE_ALTERAR(string Cpf, string Nome)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                SELECT *
                                FROM MarchPark_TBL_CLIENTE
                                WHERE CONCAT(CPF_CLIENTE, CPF_CONTROLE) = '{Cpf}'
                                AND NOME_CLIENTE <> '{Nome}'
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
        /// Método para deletar clientes.
        /// </summary>
        /// <param name="ListaUsuarios"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DELETAR_CLIENTES(List<string> IdClientes)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string idClientes = string.Join(", ", IdClientes.ConvertAll(u => $"'{u}'"));

                string sql = $@"
                                DELETE 
                                FROM MarchPark_TBL_CLIENTE
                                WHERE ID_CLIENTE IN ({idClientes})
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

        #region CAD VEICULO

        /// <summary>
        /// Método para carregar a ComboBox com o nome dos clientes.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable CARREGAR_COMBO_CLIENTES()
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
	                                NOME_CLIENTE
	                             FROM MarchPark_TBL_CLIENTE
                                 ORDER BY NOME_CLIENTE
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
        /// Método para consultar clientes.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_VEICULOS()
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
	                                VEI.ID_VEICULO,
                                    CLI.ID_CLIENTE,
	                                CLI.NOME_CLIENTE AS 'NOME CLIENTE',
	                                CONCAT(CLI.CPF_CLIENTE, CLI.CPF_CONTROLE) AS 'CPF',
	                                VEI.PLACA_VEICULO AS 'PLACA',
	                                VEI.MARCA_VEICULO AS 'MARCA',
	                                VEI.MODELO_VEICULO AS 'MODELO',
	                                VEI.COR_VEICULO AS 'COR',
	                                VEI.TIPO_VEICULO AS 'TIPO'
                                FROM MarchPark_TBL_VEICULO AS VEI
                                INNER JOIN MarchPark_TBL_CLIENTE AS CLI
	                                ON VEI.ID_CLIENTE = CLI.ID_CLIENTE
                                ORDER BY CLI.NOME_CLIENTE ASC
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
        /// Método para selecionar o CPF do cliente escolhido na combobox.
        /// </summary>
        /// <param name="VeiculoTarifa"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string SELECT_CPF_CLIENTE_SELECIONADO(int IdCliente)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                SELECT 
	                                CONCAT(CPF_CLIENTE, CPF_CONTROLE)
                                FROM MarchPark_TBL_CLIENTE
                                WHERE ID_CLIENTE = {IdCliente}
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
        /// Método para cadastrar veiculos.
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <param name="Placa"></param>
        /// <param name="TipoPlaca"></param>
        /// <param name="Marca"></param>
        /// <param name="Modelo"></param>
        /// <param name="Cor"></param>
        /// <param name="TipoVeiculo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_VEICULO(int IdCliente, string Placa, string TipoPlaca, string Marca, string Modelo, string Cor, string TipoVeiculo)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                INSERT INTO MarchPark_TBL_VEICULO (ID_CLIENTE, PLACA_VEICULO, TIPO_PLACA, MARCA_VEICULO, MODELO_VEICULO, COR_VEICULO, TIPO_VEICULO) 
                                VALUES (@id_cliente, @placa, @tipo_placa, @marca, @modelo, @cor, @tipo_veiculo)
                                ";

                // Usando a conexão com o banco
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_cliente", IdCliente);
                    cmd.Parameters.AddWithValue("@placa", Placa);
                    cmd.Parameters.AddWithValue("@tipo_placa", TipoPlaca);
                    cmd.Parameters.AddWithValue("@marca", Marca);
                    cmd.Parameters.AddWithValue("@modelo", Modelo);
                    cmd.Parameters.AddWithValue("@cor", Cor);
                    cmd.Parameters.AddWithValue("@tipo_veiculo", TipoVeiculo);

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
        /// Método para pesquisar veículos específicos.
        /// </summary>
        /// <param name="PlacaDigitado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable PESQUISAR_VEICULOS_ESPECIFICO(string PlacaDigitada)
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
                                    VEI.ID_VEICULO,
                                    CLI.ID_CLIENTE,
                                    CLI.NOME_CLIENTE AS 'NOME CLIENTE',
                                    CONCAT(CLI.CPF_CLIENTE, CLI.CPF_CONTROLE) AS 'CPF',
                                    VEI.PLACA_VEICULO AS 'PLACA',
                                    VEI.MARCA_VEICULO AS 'MARCA',
                                    VEI.MODELO_VEICULO AS 'MODELO',
                                    VEI.COR_VEICULO AS 'COR',
                                    VEI.TIPO_VEICULO AS 'TIPO'
                                FROM MarchPark_TBL_VEICULO AS VEI
                                INNER JOIN MarchPark_TBL_CLIENTE AS CLI
                                    ON VEI.ID_CLIENTE = CLI.ID_CLIENTE
                                WHERE VEI.PLACA_VEICULO LIKE '{PlacaDigitada}%'
                                ORDER BY CLI.NOME_CLIENTE ASC
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
        /// Método para pesquisar veiculos de clientes da ComboBox.
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable PESQUISAR_VEICULOS_CLIENTE_ESPECIFICO(int IdCliente)
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
                                    VEI.ID_VEICULO,
                                    CLI.ID_CLIENTE,
                                    CLI.NOME_CLIENTE AS 'NOME CLIENTE',
                                    CONCAT(CLI.CPF_CLIENTE, CLI.CPF_CONTROLE) AS 'CPF',
                                    VEI.PLACA_VEICULO AS 'PLACA',
                                    VEI.MARCA_VEICULO AS 'MARCA',
                                    VEI.MODELO_VEICULO AS 'MODELO',
                                    VEI.COR_VEICULO AS 'COR',
                                    VEI.TIPO_VEICULO AS 'TIPO'
                                FROM MarchPark_TBL_VEICULO AS VEI
                                INNER JOIN MarchPark_TBL_CLIENTE AS CLI
                                    ON VEI.ID_CLIENTE = CLI.ID_CLIENTE
                                WHERE CLI.ID_CLIENTE = {IdCliente}
                                ORDER BY CLI.NOME_CLIENTE ASC
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
        /// Método para alterar veículo.
        /// </summary>
        /// <param name="IdVeiculo"></param>
        /// <param name="Placa"></param>
        /// <param name="TipoPlaca"></param>
        /// <param name="Marca"></param>
        /// <param name="Modelo"></param>
        /// <param name="Cor"></param>
        /// <param name="TipoVeiculo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_VEICULO(int IdVeiculo, string Placa, string TipoPlaca, string Marca, string Modelo, string Cor, string TipoVeiculo)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                UPDATE MarchPark_TBL_VEICULO
	                                SET
		                                PLACA_VEICULO = @placa,
		                                TIPO_PLACA = @tipo_placa,
		                                MARCA_VEICULO = @marca,
		                                MODELO_VEICULO = @modelo,
		                                COR_VEICULO = @cor,
		                                TIPO_VEICULO = @tipo_veiculo
                                  WHERE ID_VEICULO = {IdVeiculo}
                                ";

                // Usando a conexão com o banco
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@placa", Placa);
                    cmd.Parameters.AddWithValue("@tipo_placa", TipoPlaca);
                    cmd.Parameters.AddWithValue("@marca", Marca);
                    cmd.Parameters.AddWithValue("@modelo", Modelo);
                    cmd.Parameters.AddWithValue("@cor", Cor);
                    cmd.Parameters.AddWithValue("@tipo_veiculo", TipoVeiculo);

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
        /// Método para deletar veículos.
        /// </summary>
        /// <param name="ListaUsuarios"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DELETAR_VEICULOS(List<string> IdVeiculos)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string idVeiculos = string.Join(", ", IdVeiculos.ConvertAll(u => $"'{u}'"));

                string sql = $@"
                                DELETE 
                                FROM MarchPark_TBL_VEICULO
                                WHERE ID_VEICULO IN ({idVeiculos})
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

        ///// <summary>
        ///// Método para pesquisar os clientes na ComboBox de cadastro de veículos.
        ///// </summary>
        ///// <param name="NomeDigitado"></param>
        ///// <returns></returns>
        ///// <exception cref="Exception"></exception>
        //public DataTable PESQUISAR_CLIENTES_COMBO_VEIC(string NomeDigitado)
        //{
        //    // Cria a conexão com o banco
        //    SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
        //    conn.Open();

        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter adapter = new SqlDataAdapter();

        //        string sql = $@"
        //                         SELECT
        //                         NOME_CLIENTE
        //                        FROM MarchPark_TBL_CLIENTE
        //                        WHERE NOME_CLIENTE LIKE '{NomeDigitado}%'
        //                         ";

        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.CommandTimeout = 30000;
        //        adapter.SelectCommand = cmd; // define o comando SQL para o SqlDataAdapter
        //        adapter.Fill(dt); // preenche o DataTable com os resultados da consulta
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        #endregion

        #region ENTRADA/SAÍDA

        /// <summary>
        /// Método para consultar todos os veículos de entrada e saida.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_VEICULOS_ESTACIONADOS()
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
                                     ENT.ID_ENTRADA,
	                                 ENT.ID_CLIENTE,
	                                 ENT.ID_VEICULO,
	                                 CLI.NOME_CLIENTE AS 'NOME CLIENTE',
	                                 CONCAT(CLI.CPF_CLIENTE, CLI.CPF_CONTROLE) AS 'CPF',
	                                 VEI.PLACA_VEICULO AS 'PLACA',
	                                 VEI.MARCA_VEICULO AS 'MARCA',
	                                 VEI.MODELO_VEICULO AS 'MODELO',
	                                 VEI.COR_VEICULO AS 'COR',
                                     VEI.TIPO_VEICULO AS 'TIPO VEICULO',
	                                 ENT.ENTRADA
                                 FROM MarchPark_TBL_ENTRADA AS ENT
                                 INNER JOIN MarchPark_TBL_CLIENTE AS CLI
	                                 ON ENT.ID_CLIENTE = CLI.ID_CLIENTE
                                 INNER JOIN MarchPark_TBL_VEICULO AS VEI
	                                 ON ENT.ID_VEICULO = VEI.ID_VEICULO
                                 ORDER BY ENT.ENTRADA DESC
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
        /// Método para carregar a ComboBox de clientes.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable CARREGAR_COMBO_CLIENTES_ENTRADA()
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = $@"
                                 SELECT DISTINCT
                                    CLI.ID_CLIENTE,
                                    CLI.NOME_CLIENTE
                                 FROM MarchPark_TBL_CLIENTE AS CLI
                                 INNER JOIN MarchPark_TBL_VEICULO AS VEI
	                                 ON CLI.ID_CLIENTE = VEI.ID_CLIENTE
                                 ORDER BY NOME_CLIENTE
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
        /// Método para carregar a ComboBox de placa
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable CARREGAR_COMBO_PLACAS(int IdCliente)
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
	                                 ID_VEICULO,
	                                 PLACA_VEICULO
                                 FROM MarchPark_TBL_VEICULO
                                 WHERE ID_CLIENTE = {IdCliente}
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
        /// Método para trazer as informações do veiculo selecionado na tela de entrada e saida.
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <param name="Placa"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string SELECT_INFORMACOES_VEICULO_SELECIONADO(int IdCliente, string Placa)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                SELECT 
	                                CONCAT(VEI.MARCA_VEICULO, ' ', VEI.MODELO_VEICULO, ' ', VEI.COR_VEICULO)
                                FROM MarchPark_TBL_CLIENTE AS CLI
                                INNER JOIN MarchPark_TBL_VEICULO AS VEI
	                                ON CLI.ID_CLIENTE = VEI.ID_CLIENTE
                                WHERE CLI.ID_CLIENTE = {IdCliente} AND VEI.PLACA_VEICULO = '{Placa}'
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
        /// Método para registrar entrada de veículo.
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <param name="IdVeiculo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool REGISTRAR_ENTRADA(int IdCliente, int IdVeiculo)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                string sql = $@"
                                INSERT INTO MarchPark_TBL_ENTRADA (ID_CLIENTE, ID_VEICULO, ENTRADA) 
                                VALUES (@id_cliente, @id_veiculo, CONVERT(DATETIME, GETDATE(), 120))
                                ";

                // Usando a conexão com o banco
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_cliente", IdCliente);
                    cmd.Parameters.AddWithValue("@id_veiculo", IdVeiculo);
                    
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
        /// Método para pesquisar veículos estacionados específicos a partir da placa digitada.
        /// </summary>
        /// <param name="PlacaDigitada"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable PESQUISAR_VEICULOS_ESTACIONADOS(string PlacaDigitada)
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
                                       ENT.ID_ENTRADA,
                                       ENT.ID_CLIENTE,
                                       ENT.ID_VEICULO,
                                       CLI.NOME_CLIENTE AS 'NOME CLIENTE',
                                       CONCAT(CLI.CPF_CLIENTE, CLI.CPF_CONTROLE) AS 'CPF',
                                       VEI.PLACA_VEICULO AS 'PLACA',
                                       VEI.MARCA_VEICULO AS 'MARCA',
                                       VEI.MODELO_VEICULO AS 'MODELO',
                                       VEI.COR_VEICULO AS 'COR',
                                       VEI.TIPO_VEICULO AS 'TIPO VEICULO',
                                       ENT.ENTRADA
                                   FROM MarchPark_TBL_ENTRADA AS ENT
                                   INNER JOIN MarchPark_TBL_CLIENTE AS CLI
                                       ON ENT.ID_CLIENTE = CLI.ID_CLIENTE
                                   INNER JOIN MarchPark_TBL_VEICULO AS VEI
                                       ON ENT.ID_VEICULO = VEI.ID_VEICULO
                                   WHERE VEI.PLACA_VEICULO LIKE '{PlacaDigitada}%'
                                   ORDER BY ENT.ENTRADA DESC
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
        /// Método para retornar o tipo do veículo selecionado.
        /// </summary>
        /// <param name="IdVeiculo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string TIPO_VEICULO(int IdVeiculo)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {

                string sql = $@"
                                SELECT
                                    TIPO_VEICULO
                                FROM MarchPark_TBL_VEICULO
                                WHERE ID_VEICULO = '{IdVeiculo}'
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

        #endregion

        #region CHECKOUT

        /// <summary>
        /// Método para trazer os dados do cliente que saiu do estacionamento.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_DADOS_CLIENTE_SAIDA()
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(MarchPark.DAD.ConnectionFactory.connectionString);
            conn.Open();

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = $@"
                                SELECT TOP (1)
	                                CLI.NOME_CLIENTE,
	                                CONCAT(CLI.CPF_CLIENTE, CLI.CPF_CONTROLE) AS CPF,
	                                CONCAT(VEI.MARCA_VEICULO, ' ', VEI.MODELO_VEICULO, ' ', VEI.COR_VEICULO) AS VEICULO,
	                                HIS.ENTRADA,
	                                HIS.SAIDA,
	                                HIS.VALOR_PAGO
                                FROM MarchPark_TBL_HISTORICO AS HIS
                                INNER JOIN MarchPark_TBL_CLIENTE AS CLI
	                                ON HIS.ID_CLIENTE = CLI.ID_CLIENTE
                                INNER JOIN MarchPark_TBL_VEICULO AS VEI
	                                ON HIS.ID_VEICULO = VEI.ID_VEICULO
                                ORDER BY ID_HISTORICO DESC
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

        #endregion

        #region RELATÓRIO

        /// <summary>
        /// Método para consultar o histórico do estacionamento.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_HISTORICO()
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
	                                 CLI.NOME_CLIENTE AS 'NOME CLIENTE',
	                                 CONCAT(CPF_CLIENTE, CPF_CONTROLE) AS 'CPF',
	                                 VEI.PLACA_VEICULO AS 'PLACA',
	                                 CONCAT(VEI.MARCA_VEICULO, ' ', VEI.MODELO_VEICULO, ' ', VEI.COR_VEICULO) AS 'VEÍCULO',
	                                 HIS.VALOR_PAGO AS 'VALOR PAGO',
	                                 HIS.ENTRADA,
	                                 HIS.SAIDA AS 'SAÍDA',
                                     HIS.NUM_ENTRADA_DIA AS 'Nº'
                                 FROM MarchPark_TBL_HISTORICO AS HIS
                                 INNER JOIN MarchPark_TBL_CLIENTE AS CLI
	                                 ON HIS.ID_CLIENTE = CLI.ID_CLIENTE
                                 INNER JOIN MarchPark_TBL_VEICULO AS VEI	
	                                 ON HIS.ID_VEICULO = VEI.ID_VEICULO
                                 ORDER BY HIS.SAIDA DESC
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
        /// Método para consultar o histórico do estacionamento a partir da data de entrada.
        /// </summary>
        /// <param name="DataEntrada"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_HISTORICO_DATA_ENTRADA(string DataEntrada)
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
                                     CLI.NOME_CLIENTE AS 'NOME CLIENTE',
                                     CONCAT(CPF_CLIENTE, CPF_CONTROLE) AS 'CPF',
                                     VEI.PLACA_VEICULO AS 'PLACA',
                                     CONCAT(VEI.MARCA_VEICULO, ' ', VEI.MODELO_VEICULO, ' ', VEI.COR_VEICULO) AS 'VEÍCULO',
                                     HIS.VALOR_PAGO AS 'VALOR PAGO',
                                     HIS.ENTRADA,
                                     HIS.SAIDA AS 'SAÍDA',
                                     HIS.NUM_ENTRADA_DIA AS 'Nº'
                                 FROM MarchPark_TBL_HISTORICO AS HIS
                                 INNER JOIN MarchPark_TBL_CLIENTE AS CLI
                                     ON HIS.ID_CLIENTE = CLI.ID_CLIENTE
                                 INNER JOIN MarchPark_TBL_VEICULO AS VEI	
                                     ON HIS.ID_VEICULO = VEI.ID_VEICULO
                                 WHERE FORMAT(HIS.ENTRADA, 'yyyy-MM-dd') = FORMAT((CONVERT(DATETIME, '{DataEntrada}')), 'yyyy-MM-dd')
                                 ORDER BY HIS.SAIDA DESC
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
        /// Método para consultar o histórico do estacionamento a partir de um range de data de entrada.
        /// </summary>
        /// <param name="DataInicio"></param>
        /// <param name="DataFim"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_HISTORICO_DATA_ENTRADA_RANGE(string DataInicio, string DataFim)
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
                                     CLI.NOME_CLIENTE AS 'NOME CLIENTE',
                                     CONCAT(CPF_CLIENTE, CPF_CONTROLE) AS 'CPF',
                                     VEI.PLACA_VEICULO AS 'PLACA',
                                     CONCAT(VEI.MARCA_VEICULO, ' ', VEI.MODELO_VEICULO, ' ', VEI.COR_VEICULO) AS 'VEÍCULO',
                                     HIS.VALOR_PAGO AS 'VALOR PAGO',
                                     HIS.ENTRADA,
                                     HIS.SAIDA AS 'SAÍDA',
                                     HIS.NUM_ENTRADA_DIA AS 'Nº'
                                 FROM MarchPark_TBL_HISTORICO AS HIS
                                 INNER JOIN MarchPark_TBL_CLIENTE AS CLI
                                     ON HIS.ID_CLIENTE = CLI.ID_CLIENTE
                                 INNER JOIN MarchPark_TBL_VEICULO AS VEI	
                                     ON HIS.ID_VEICULO = VEI.ID_VEICULO
                                 WHERE FORMAT(HIS.ENTRADA, 'yyyy-MM-dd') >= FORMAT((CONVERT(DATETIME, '{DataInicio}')), 'yyyy-MM-dd') 
                                 AND FORMAT(HIS.ENTRADA, 'yyyy-MM-dd') <= FORMAT((CONVERT(DATETIME, '{DataFim}')), 'yyyy-MM-dd')
                                 ORDER BY HIS.SAIDA DESC
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
        /// Método para consultar o histórico do estacionamento a partir da placa do veículo.
        /// </summary>
        /// <param name="Placa"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_HISTORICO_PLACA(string PlacaDigitada)
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
                                     CLI.NOME_CLIENTE AS 'NOME CLIENTE',
                                     CONCAT(CPF_CLIENTE, CPF_CONTROLE) AS 'CPF',
                                     VEI.PLACA_VEICULO AS 'PLACA',
                                     CONCAT(VEI.MARCA_VEICULO, ' ', VEI.MODELO_VEICULO, ' ', VEI.COR_VEICULO) AS 'VEÍCULO',
                                     HIS.VALOR_PAGO AS 'VALOR PAGO',
                                     HIS.ENTRADA,
                                     HIS.SAIDA AS 'SAÍDA',
                                     HIS.NUM_ENTRADA_DIA AS 'Nº'
                                 FROM MarchPark_TBL_HISTORICO AS HIS
                                 INNER JOIN MarchPark_TBL_CLIENTE AS CLI
                                     ON HIS.ID_CLIENTE = CLI.ID_CLIENTE
                                 INNER JOIN MarchPark_TBL_VEICULO AS VEI	
                                     ON HIS.ID_VEICULO = VEI.ID_VEICULO
                                 WHERE VEI.PLACA_VEICULO LIKE '{PlacaDigitada}%'
                                 ORDER BY HIS.SAIDA DESC
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
        /// Método para consultar o histórico do estacionamento a partir do CPF do cliente.
        /// </summary>
        /// <param name="CPFDigitado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_HISTORICO_CPF(string CPFDigitado)
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
                                     CLI.NOME_CLIENTE AS 'NOME CLIENTE',
                                     CONCAT(CPF_CLIENTE, CPF_CONTROLE) AS 'CPF',
                                     VEI.PLACA_VEICULO AS 'PLACA',
                                     CONCAT(VEI.MARCA_VEICULO, ' ', VEI.MODELO_VEICULO, ' ', VEI.COR_VEICULO) AS 'VEÍCULO',
                                     HIS.VALOR_PAGO AS 'VALOR PAGO',
                                     HIS.ENTRADA,
                                     HIS.SAIDA AS 'SAÍDA',
                                     HIS.NUM_ENTRADA_DIA AS 'Nº'
                                 FROM MarchPark_TBL_HISTORICO AS HIS
                                 INNER JOIN MarchPark_TBL_CLIENTE AS CLI
                                     ON HIS.ID_CLIENTE = CLI.ID_CLIENTE
                                 INNER JOIN MarchPark_TBL_VEICULO AS VEI	
                                     ON HIS.ID_VEICULO = VEI.ID_VEICULO
                                 WHERE CONCAT(CPF_CLIENTE, CPF_CONTROLE) LIKE '{CPFDigitado}%'
                                 ORDER BY HIS.SAIDA DESC
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

        #endregion
    }
}
