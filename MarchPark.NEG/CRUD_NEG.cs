using MarchPark.DAD;
using MarchPark.ENT.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarchPark.NEG
{
    /// <summary>
    /// Classe de CRUD NEGOCIOS.
    /// </summary>
    public class CRUD_NEG
    {
        private readonly MarchPark.DAD.CRUD_DADOS ObjDAD = new MarchPark.DAD.CRUD_DADOS();

        #region ADM

        /// <summary>
        /// Faz chamada da função "SELECT_MARCH_PARK_TBL_PERMISSAO" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_MARCH_PARK_TBL_PERMISSAO(string Senha)
        {
            try
            {
                return ObjDAD.SELECT_MARCH_PARK_TBL_PERMISSAO(Senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region LOGIN

        /// <summary>
        /// Faz chamada da função "SELECT_MARCH_PARK_TBL_LOGIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public bool SELECT_MARCH_PARK_TBL_LOGIN(string Usuario, string Senha)
        {
            try
            {
                return ObjDAD.SELECT_MARCH_PARK_TBL_LOGIN(Usuario, Senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_MARCH_PARK_TBL_LOGIN_EXISTENTE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<MarchPark_TBL_LOGIN> SELECT_MARCH_PARK_TBL_LOGIN_EXISTENTE(MarchPark_TBL_LOGIN Ent)
        {
            try
            {
                return ObjDAD.SELECT_MARCH_PARK_TBL_LOGIN_EXISTENTE(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "INSERT_MARCH_PARK_TBL_LOGIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_MARCH_PARK_TBL_LOGIN(MarchPark_TBL_LOGIN Ent)
        {
            try
            {
                ObjDAD.INSERT_MARCH_PARK_TBL_LOGIN(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_NOME_USUARIO_ATIVO" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string SELECT_NOME_USUARIO_ATIVO(MarchPark_TBL_LOGIN Ent)
        {
            try
            {
                return ObjDAD.SELECT_NOME_USUARIO_ATIVO(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region USUARIO ATIVO

        /// <summary>
        /// Faz chamada da função "SELECT_MARCH_PARK_TBL_LOGIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public bool VALIDAR_SENHA_ATUAL_USUARIO_ATIVO(string Usuario, string Senha)
        {
            try
            {
                return ObjDAD.VALIDAR_SENHA_ATUAL_USUARIO_ATIVO(Usuario, Senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public bool ALTERAR_USUARIO_SENHA_ATIVO(string UsuarioAtual, string UsuarioNovo, string SenhaNova, int TipoQuery)
        {
            try
            {
                return ObjDAD.ALTERAR_USUARIO_SENHA_ATIVO(UsuarioAtual, UsuarioNovo, SenhaNova, TipoQuery);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region GERENCIAMENTO

        /// <summary>
        /// Faz chamada da função "ALTERAR_SENHA_PERMISSAO" na camada de dados.
        /// </summary>
        /// <param name="SenhaNova"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_SENHA_PERMISSAO(string SenhaNova)
        {
            try
            {
                return ObjDAD.ALTERAR_SENHA_PERMISSAO(SenhaNova);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "ALTERAR_TARIFA" na camada de dados.
        /// </summary>
        /// <param name="TarifaCarro"></param>
        /// <param name="TarifaMoto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_TARIFA(string TarifaCarro, string TarifaMoto)
        {
            try
            {
                return ObjDAD.ALTERAR_TARIFA(TarifaCarro, TarifaMoto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_VALOR_TARIFA_ATUAL" na camada de dados.
        /// </summary>
        /// <param name="VeiculoTarifa"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string SELECT_VALOR_TARIFA_ATUAL(string VeiculoTarifa)
        {
            try
            {
                return ObjDAD.SELECT_VALOR_TARIFA_ATUAL(VeiculoTarifa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_USUARIOS_MARCH_PARK" na camada de dados.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_USUARIOS_MARCH_PARK()
        {
            try
            {
                return ObjDAD.SELECT_USUARIOS_MARCH_PARK();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETAR_USUARIOS_MARCH_PARK" na camada de dados.
        /// </summary>
        /// <param name="ListaUsuarios"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DELETAR_USUARIOS_MARCH_PARK(List<string> ListaUsuarios)
        {
            try
            {
                return ObjDAD.DELETAR_USUARIOS_MARCH_PARK(ListaUsuarios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region CAD CLIENTE

        /// <summary>
        /// Faz chamada da função "SELECT_CLIENTES" na camada de dados.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_CLIENTES()
        {
            try
            {
                return ObjDAD.SELECT_CLIENTES();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "PESQUISAR_CLIENTES_ESPECIFICO" na camada de dados.
        /// </summary>
        /// <param name="NomeDigitado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable PESQUISAR_CLIENTES_ESPECIFICO(string NomeDigitado)
        {
            try
            {
                return ObjDAD.PESQUISAR_CLIENTES_ESPECIFICO(NomeDigitado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "INSERIR_CLIENTE" na camada de dados.
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
            try
            {
                return ObjDAD.INSERIR_CLIENTE(Nome, Cpf, DataNascimento, NumeroTelefone, Email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CLIENTE_EXISTENTE" na camada de dados.
        /// </summary>
        /// <param name="Cpf"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_CLIENTE_EXISTENTE(string Cpf)
        {
            try
            {
                return ObjDAD.SELECT_CLIENTE_EXISTENTE(Cpf);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "ALTERAR_CLIENTE" na camada de dados.
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
            try
            {
                return ObjDAD.ALTERAR_CLIENTE(Nome, Cpf, DataNascimento, NumeroTelefone, Email, IdCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CLIENTE_EXISTENTE_ALTERAR" na camada de dados.
        /// </summary>
        /// <param name="Cpf"></param>
        /// <param name="Nome"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_CLIENTE_EXISTENTE_ALTERAR(string Cpf, string Nome)
        {
            try
            {
                return ObjDAD.SELECT_CLIENTE_EXISTENTE_ALTERAR(Cpf, Nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETAR_CLIENTES" na camada de dados.
        /// </summary>
        /// <param name="IdClientes"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DELETAR_CLIENTES(List<string> IdClientes)
        {
            try
            {
                return ObjDAD.DELETAR_CLIENTES(IdClientes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region CAD VEICULO

        /// <summary>
        /// Faz chamada da função "CARREGAR_COMBO_CLIENTES" na camada de dados.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable CARREGAR_COMBO_CLIENTES()
        {
            try
            {
                return ObjDAD.CARREGAR_COMBO_CLIENTES();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_VEICULOS" na camada de dados.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable SELECT_VEICULOS()
        {
            try
            {
                return ObjDAD.SELECT_VEICULOS();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CPF_CLIENTE_SELECIONADO" na camada de dados.
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string SELECT_CPF_CLIENTE_SELECIONADO(int IdCliente)
        {
            try
            {
                return ObjDAD.SELECT_CPF_CLIENTE_SELECIONADO(IdCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "INSERIR_VEICULO" na camada de dados.
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
            try
            {
                return ObjDAD.INSERIR_VEICULO(IdCliente, Placa, TipoPlaca, Marca, Modelo, Cor, TipoVeiculo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        ///// <summary>
        ///// Faz chamada da função "PESQUISAR_CLIENTES_COMBO_VEIC" na camada de dados.
        ///// </summary>
        ///// <param name="NomeDigitado"></param>
        ///// <returns></returns>
        ///// <exception cref="Exception"></exception>
        //public DataTable PESQUISAR_CLIENTES_COMBO_VEIC(string NomeDigitado)
        //{
        //    try
        //    {
        //        return ObjDAD.PESQUISAR_CLIENTES_COMBO_VEIC(NomeDigitado);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        #endregion
    }
}
