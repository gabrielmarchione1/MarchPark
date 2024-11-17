using MarchPark.DAD;
using MarchPark.ENT.Login;
using System;
using System.Collections.Generic;
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

        #endregion
    }
}
