using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarchPark.Forms
{
    /// <summary>
    /// Formulário de checkout.
    /// </summary>
    public partial class FRM_CHECKOUT : Form
    {
        MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();

        /// <summary>
        /// Construtor da classe FRM_CHECKOUT
        /// Inicializa os componentes do formulário de checkout.
        /// </summary>
        public FRM_CHECKOUT()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para carregar na tela os dados do cliente que saiu do estacionamento.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CARREGAR_DADOS_CLIENTE()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = ObjNEG.SELECT_DADOS_CLIENTE_SAIDA();

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    string cpf = row["CPF"].ToString();
                    string cpfFormatado = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";

                    LBL_NOME_CLIENTE.Text = row["NOME_CLIENTE"].ToString();
                    LBL_CPF_CLIENTE.Text = cpfFormatado;
                    LBL_VEICULO_CLIENTE.Text = row["VEICULO"].ToString();
                    LBL_ENTRADA.Text = "Entrada: " + row["ENTRADA"].ToString();
                    LBL_SAIDA.Text = "Saída: " + row["SAIDA"].ToString();
                    LBL_VALOR.Text = "R$ " + row["VALOR_PAGO"].ToString();

                    dt = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Evento de carregamento do form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_CHECKOUT_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CARREGAR_DADOS_CLIENTE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Evento de clique no botão "BTN_FECHAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_FECHAR_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
