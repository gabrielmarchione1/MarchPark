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
    /// Formulário de cadastro de veículo.
    /// </summary>
    public partial class FRM_CAD_VEICULO : Form
    {
        MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        private List<string> listaCampos = new List<string>();

        /// <summary>
        /// Construtor da classe FRM_CAD_VEICULO
        /// Inicializa os componentes do formulário de cadastro de veículo.
        /// </summary>
        public FRM_CAD_VEICULO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para cadastrar veiculo.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_VEICULO()
        {
            try
            {
                bool CamposValidados = true;
                listaCampos = new List<string>();
                string tipoPlaca;

                if (RBTN_MERCOSUL.Checked)
                {
                    tipoPlaca = "Mercosul";
                }
                else
                {
                    tipoPlaca = "Antiga";
                }


                if (CBX_NOME.SelectedIndex == -1)
                {
                    listaCampos.Add("Nome");
                    CamposValidados = false;
                }

                if (MBX_PLACA.Text.Replace("-", "").Length != 7)
                {
                    listaCampos.Add("Placa");
                    CamposValidados = false;
                }

                if (TXT_MARCA.Text.Length == 0)
                {
                    listaCampos.Add("Marca");
                    CamposValidados = false;
                }

                if (TXT_MODELO.Text.Length == 0)
                {
                    listaCampos.Add("Modelo");
                    CamposValidados = false;
                }

                if (TXT_COR.Text.Length == 0)
                {
                    listaCampos.Add("Cor");
                    CamposValidados = false;
                }

                if (CBX_TIPO_VEICULO.SelectedIndex == -1)
                {
                    listaCampos.Add("Tipo");
                    CamposValidados = false;
                }


                if (CamposValidados)
                {
                    ObjNEG.INSERIR_VEICULO(Convert.ToInt32(CBX_NOME.SelectedValue), MBX_PLACA.Text.ToUpper(), tipoPlaca, TXT_MARCA.Text, TXT_MODELO.Text, TXT_COR.Text, CBX_TIPO_VEICULO.SelectedValue.ToString());
                    MessageBox.Show("Veículo cadastrado com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CONSULTAR_VEICULOS();
                    LIMPAR_DADOS();
                    listaCampos = null;
                    return true;
                }
                else
                {
                    string camposInvalidos = string.Join(", ", listaCampos.ConvertAll(u => $"{u}"));

                    MessageBox.Show($"Campos Inválidos: {camposInvalidos}", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para consultar veiculos.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_VEICULOS()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_VEICULOS();
                DGV_DADOS.CurrentCell = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para carregar as ComboBox.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CARREGAR_COMBOS()
        {
            try
            {
                CBX_NOME.DataSource = ObjNEG.CARREGAR_COMBO_CLIENTES();
                CBX_NOME.DisplayMember = "NOME_CLIENTE";
                CBX_NOME.ValueMember = "ID_CLIENTE";
                int ID_CLIENTE = Convert.ToInt32(CBX_NOME.SelectedValue);


                List<String> tiposVeiculos = new List<String>()
                {
                    "Carro",
                    "Moto"
                };

                CBX_TIPO_VEICULO.DataSource = tiposVeiculos;
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
                CBX_TIPO_VEICULO.SelectedIndex = -1;
                RBTN_MERCOSUL.Checked = true;

                BTN_ADICIONAR.Enabled = true;
                BTN_DELETAR.Enabled = true;
                //MBX_CPF.Enabled = true;
                //MBX_DATA_NASCIMENTO.Enabled = true;
                DGV_DADOS.Enabled = true;

                BTN_LIMPAR_DADOS.Text = "Limpar";

                MBX_CPF.Text = "";
                MBX_PLACA.Text = "";
                TXT_PESQUISAR_PLACA.Text = "";
                TXT_MARCA.Text = "";
                TXT_MODELO.Text = "";
                TXT_COR.Text = "";

                foreach (DataGridViewRow row in DGV_DADOS.Rows)
                {
                    row.Cells["checkBoxColumn"].Value = false;
                }

                DGV_DADOS.CurrentCell = null;
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
                DGV_DADOS.Columns["ID_VEICULO"].Visible = false;
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
        /// Evento de check do radio button de placa mercosul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBTN_MERCOSUL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MBX_PLACA.Mask = "AAA0A00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de check do radio button de placa antiga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBTN_ANTIGA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                MBX_PLACA.Mask = "AAA-0000";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_CAD_VEICULO_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                DGV_DADOS.DataSource = ObjNEG.SELECT_VEICULOS();
                MBX_PLACA.Mask = "AAA0A00";
                CARREGAR_COMBOS();
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
        /// Evento de quando o formulario aparece pela primeira vez.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_CAD_VEICULO_Shown(object sender, EventArgs e)
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
        /// Evento de clique em cada item da lista da ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBX_NOME_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (CBX_NOME.SelectedIndex != -1)
                {
                    MBX_CPF.Text = ObjNEG.SELECT_CPF_CLIENTE_SELECIONADO(Convert.ToInt32(CBX_NOME.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique no botão "BTN_LIMPAR_DADOS".
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
        /// Evento de clique no botão "BTN_ADICIONAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ADICIONAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                INSERIR_VEICULO();
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

        ///// <summary>
        ///// Evento para cada ação da "CBX_NOME".
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void CBX_NOME_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Capturar o texto digitado
        //        string textoDigitado = CBX_NOME.Text;

        //        // Filtrar a lista com base no texto digitado
        //        // Atualizar os itens do ComboBox com a lista filtrada
        //        CBX_NOME.DataSource = ObjNEG.PESQUISAR_CLIENTES_COMBO_VEIC(textoDigitado);

        //        // Reabrir o dropdown para mostrar os resultados
        //        CBX_NOME.DroppedDown = true;

        //        // Posicionar o cursor ao final do texto digitado
        //        CBX_NOME.SelectionStart = textoDigitado.Length;
        //        CBX_NOME.SelectionLength = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
