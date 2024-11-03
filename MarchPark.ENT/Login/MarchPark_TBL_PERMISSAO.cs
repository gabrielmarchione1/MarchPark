using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarchPark.ENT.Login
{
    /// <summary>
    /// Classe MarchPark_TBL_PERMISSAO
    /// </summary>
    [Table(Name = "MarchPark_TBL_PERMISSAO")]
    public class MarchPark_TBL_PERMISSAO
    {
        string _SENHA_PERMISSAO;
        /// <summary>
        /// COLUNA USUARIO_ADM
        /// </summary>
        [Column(Storage = "_SENHA_PERMISSAO", CanBeNull = false)]
        public string SENHA_PERMISSAO { get { return _SENHA_PERMISSAO; } set { _SENHA_PERMISSAO = value; } }
    }
}
