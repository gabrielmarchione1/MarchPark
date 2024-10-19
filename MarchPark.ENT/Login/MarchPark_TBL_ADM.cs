using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarchPark.ENT.Login
{
    /// <summary>
    /// Classe MarchPark_TBL_ADM
    /// </summary>
    [Table(Name = "MarchPark_TBL_ADM")]
    public class MarchPark_TBL_ADM
    {
        string _USUARIO_ADM;
        /// <summary>
        /// COLUNA USUARIO_ADM
        /// </summary>
        [Column(Storage = "_USUARIO_ADM", CanBeNull = false)]
        public string USUARIO_ADM { get { return _USUARIO_ADM; } set { _USUARIO_ADM = value; } }

        string _SENHA_ADM;
        /// <summary>
        /// COLUNA SENHA_ADM
        /// </summary>
        [Column(Storage = "_SENHA_ADM", CanBeNull = false)]
        public string SENHA_ADM { get { return _SENHA_ADM; } set { _SENHA_ADM = value; } }
    }
}
