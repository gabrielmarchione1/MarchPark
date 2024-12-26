using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarchPark.NEG
{
    /// <summary>
    /// Classe CRUD NEG do formulário de entrada/saída.
    /// </summary>
    public class FRM_INICIAL_NEG
    {
        MarchPark.DAD.ConnectionFactory ObjDAD = new DAD.ConnectionFactory();

        /// <summary>
        /// Método para registrar a saída do veículo.
        /// </summary>
        /// <param name="IdEntrada"></param>
        /// <param name="IdCliente"></param>
        /// <param name="IdVeiculo"></param>
        /// <param name="Entrada"></param>
        /// <param name="Tarifa"></param>
        /// <exception cref="Exception"></exception>
        public void REGISTRAR_SAIDA_VEICULO(int IdEntrada, int IdCliente, int IdVeiculo, string Entrada, decimal Tarifa)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id_entrada", SqlDbType.Int) { Value = IdEntrada },
                    new SqlParameter("@id_cliente", SqlDbType.Int) { Value = IdCliente },
                    new SqlParameter("@id_veiculo", SqlDbType.Int) { Value = IdVeiculo },
                    new SqlParameter("@entrada", SqlDbType.DateTime) { Value = Entrada },
                    new SqlParameter("@tarifa", SqlDbType.Decimal) { Value = Tarifa }
                };

                ObjDAD.EXECUTA_SP_SEM_RETORNO("dbo.MarchPark_SP_REGISTRAR_SAIDA_VEICULO", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
