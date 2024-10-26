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
    public class CRUD_NEG
    {
        private readonly MarchPark.DAD.CRUD_DADOS ObjDAD = new MarchPark.DAD.CRUD_DADOS();

        #region ADM

        /// <summary>
        /// Faz chamada da função "SELECT_MARCH_PARK_TBL_ADM" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_MARCH_PARK_TBL_ADM(string Usuario, string Senha)
        {
            try
            {
                return ObjDAD.SELECT_MARCH_PARK_TBL_ADM(Usuario, Senha);
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
    }
}
