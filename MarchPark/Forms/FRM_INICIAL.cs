using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarchPark.Forms
{
    /// <summary>
    /// Formulário inicial.
    /// </summary>
    public partial class FRM_INICIAL : Form
    {
        MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();

        /// <summary>
        /// Construtor da classe FRM_INICIAL
        /// Inicializa os componentes do formulário inicial.
        /// </summary>
        public FRM_INICIAL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para consultar veiculos estacionados.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_VEICULOS_ESTACIONADOS()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_VEICULOS_ESTACIONADOS();
                DGV_DADOS.CurrentCell = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para carregar a ComboBox de nome.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CARREGAR_COMBO_NOME()
        {
            try
            {
                CBX_NOME.DataSource = ObjNEG.CARREGAR_COMBO_CLIENTES_ENTRADA();
                CBX_NOME.DisplayMember = "NOME_CLIENTE";
                CBX_NOME.ValueMember = "ID_CLIENTE";
                int ID_CLIENTE = Convert.ToInt32(CBX_NOME.SelectedValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para limpar dados dos campos.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void LIMPAR_DADOS()
        {
            try
            {
                CBX_NOME.SelectedIndex = -1;
                MBX_CPF.Text = "";
                CBX_PLACA.SelectedIndex = -1;
                TXT_MARCA_MODELO.Text = "";

                CBX_PLACA.Enabled = false;
                CONSULTAR_VEICULOS_ESTACIONADOS();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Evento de load do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_INICIAL_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                DGV_DADOS.DataSource = ObjNEG.SELECT_VEICULOS_ESTACIONADOS();
                CARREGAR_COMBO_NOME();
                LIMPAR_DADOS();
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
        /// Evento de clique em cada item da lista da ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBX_NOME_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CBX_PLACA.DataSource = ObjNEG.CARREGAR_COMBO_PLACAS(Convert.ToInt32(CBX_NOME.SelectedValue));
                CBX_PLACA.DisplayMember = "PLACA_VEICULO";
                CBX_PLACA.ValueMember = "ID_VEICULO";
                int ID_VEICULO = Convert.ToInt32(CBX_PLACA.SelectedValue);

                CBX_PLACA.SelectedIndex = -1;
                CBX_PLACA.Enabled = true;
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
    }
}
