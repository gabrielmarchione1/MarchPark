using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MarchPark.Forms
{
    /// <summary>
    /// Formulário inicial.
    /// </summary>
    public partial class FRM_INICIAL : Form
    {
        MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        MarchPark.NEG.FRM_INICIAL_NEG ObjNEG_SAIDA = new NEG.FRM_INICIAL_NEG();

        /// <summary>
        /// Construtor da classe FRM_INICIAL
        /// Inicializa os componentes do formulário inicial.
        /// </summary>
        public FRM_INICIAL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para registrar a saída do veículo.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void REGISTRAR_SAIDA()
        {
            try
            {
                string tipoVeiculo;

                if (DGV_DADOS.CurrentRow.Cells["TIPO VEICULO"].Value.ToString() == "Carro")
                {
                    tipoVeiculo = "Carro";
                }
                else
                {
                    tipoVeiculo = "Moto";
                }

                string tarifa = ObjNEG.SELECT_VALOR_TARIFA_ATUAL(tipoVeiculo);
                decimal tarifaConvertida = decimal.Parse(tarifa);

                ObjNEG_SAIDA.REGISTRAR_SAIDA_VEICULO(Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["ID_ENTRADA"].Value.ToString()), Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["ID_CLIENTE"].Value.ToString()), Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["ID_VEICULO"].Value.ToString()), DGV_DADOS.CurrentRow.Cells["ENTRADA"].Value.ToString(), tarifaConvertida);
                CONSULTAR_VEICULOS_ESTACIONADOS();

                MarchPark.Forms.FRM_CHECKOUT FRM_CHECKOUT = new MarchPark.Forms.FRM_CHECKOUT();
                SystemSounds.Asterisk.Play();
                FRM_CHECKOUT.ShowDialog();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para registrar entrada de veículo.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool REGISTRAR_ENTRADA()
        {
            try
            {
                if (CBX_NOME.SelectedIndex != -1)
                {
                    if (CBX_PLACA.SelectedIndex != -1)
                    {
                        ObjNEG.REGISTRAR_ENTRADA(Convert.ToInt32(CBX_NOME.SelectedValue), Convert.ToInt32(CBX_PLACA.SelectedValue));
                        MessageBox.Show("Entrada registrada com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CONSULTAR_VEICULOS_ESTACIONADOS();
                        LIMPAR_DADOS();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Selecione a placa!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione algum veículo!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para pesquisar os veículos estacionados pela placa.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void PESQUISAR_VEICULOS_ESTACIONADOS()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.PESQUISAR_VEICULOS_ESTACIONADOS(TXT_BUSCAR_PLACA.Text);
                DGV_DADOS.CurrentCell = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
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
                TXT_BUSCAR_PLACA.Text = "";
                LBL_TARIFA.Text = "";

                CBX_PLACA.Enabled = false;

                foreach (DataGridViewRow row in DGV_DADOS.Rows)
                {
                    row.Cells["checkBoxColumn"].Value = false;
                }

                DGV_DADOS.CurrentCell = null;
                //CONSULTAR_VEICULOS_ESTACIONADOS();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para layout do GridView.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void LAYOUT_GRID()
        {
            try
            {
                DGV_DADOS.Columns["ID_ENTRADA"].Visible = false;
                DGV_DADOS.Columns["ID_VEICULO"].Visible = false;
                DGV_DADOS.Columns["ID_CLIENTE"].Visible = false;
                DGV_DADOS.Columns["TIPO VEICULO"].Visible = false;
                DGV_DADOS.Columns["PLACA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Configurar o DataGridView para não quebrar o texto no cabeçalho
                DGV_DADOS.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // Ajustar a altura automaticamente (opcional)
                DGV_DADOS.AutoResizeColumnHeadersHeight();

                //DGV_DADOS.Columns["CPF"].DefaultCellStyle.Format = $@"000,000,000-00";
                DGV_DADOS.AutoResizeColumns();
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

                if (CBX_NOME.SelectedIndex != -1)
                {
                    MBX_CPF.Text = ObjNEG.SELECT_CPF_CLIENTE_SELECIONADO(Convert.ToInt32(CBX_NOME.SelectedValue));
                }

                CBX_PLACA.DataSource = ObjNEG.CARREGAR_COMBO_PLACAS(Convert.ToInt32(CBX_NOME.SelectedValue));
                CBX_PLACA.DisplayMember = "PLACA_VEICULO";
                CBX_PLACA.ValueMember = "ID_VEICULO";
                int ID_VEICULO = Convert.ToInt32(CBX_PLACA.SelectedValue);

                CBX_PLACA.SelectedIndex = -1;
                CBX_PLACA.Enabled = true;
                TXT_MARCA_MODELO.Text = "";
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
        /// Evento de preenchimento do GridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_DADOS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                DGV_DADOS.AutoResizeColumns();
                foreach (DataGridViewColumn coluna in DGV_DADOS.Columns)
                {
                    coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    coluna.ReadOnly = true;
                }

                LAYOUT_GRID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de quando o formulario aparece pela primeira vez.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_INICIAL_Shown(object sender, EventArgs e)
        {
            try
            {
                DGV_DADOS.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique na linha do GridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_DADOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool cell_checked = false;
                if (e.RowIndex >= 0)
                {
                    cell_checked = Convert.ToBoolean(DGV_DADOS.CurrentRow.Cells["checkBoxColumn"].Value);

                    if (cell_checked == true)
                    {
                        DGV_DADOS.CurrentRow.Cells["checkBoxColumn"].Value = false;
                    }
                    else if (cell_checked == false)
                    {
                        DGV_DADOS.CurrentRow.Cells["checkBoxColumn"].Value = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de formatação das linhas do GridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_DADOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (DGV_DADOS.Columns[e.ColumnIndex].Name == "CPF")
                {
                    if (e.Value != null)
                    {
                        string cpf = e.Value.ToString();
                        if (cpf.Length == 11 && long.TryParse(cpf, out _))
                        {
                            e.Value = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_LIMPAR_DADOS_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
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
        private void CBX_PLACA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (CBX_NOME.SelectedIndex != -1)
                {
                    TXT_MARCA_MODELO.Text = ObjNEG.SELECT_INFORMACOES_VEICULO_SELECIONADO(Convert.ToInt32(CBX_NOME.SelectedValue), CBX_PLACA.Text);
                }

                LBL_TARIFA.Text = "R$ " + ObjNEG.SELECT_VALOR_TARIFA_ATUAL(ObjNEG.TIPO_VEICULO(Convert.ToInt32(CBX_PLACA.SelectedValue))) + "/h";
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
        /// Evento para cada ação da "TXT_BUSCAR_PLACA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_BUSCAR_PLACA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PESQUISAR_VEICULOS_ESTACIONADOS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique no botão "BTN_REGISTRAR_ENTRADA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_REGISTRAR_ENTRADA_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                REGISTRAR_ENTRADA();
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
        /// Evento de duplo clique na linha selecionada do GridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_DADOS_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string nomeVeiculo = DGV_DADOS.CurrentRow.Cells["MARCA"].Value.ToString() + " " + DGV_DADOS.CurrentRow.Cells["MODELO"].Value.ToString() + " " + DGV_DADOS.CurrentRow.Cells["COR"].Value.ToString();

                if (MessageBox.Show($"Deseja realmente registrar a saída do veículo {nomeVeiculo} da placa: {DGV_DADOS.CurrentRow.Cells["PLACA"].Value.ToString()}?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    REGISTRAR_SAIDA();
                }

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
