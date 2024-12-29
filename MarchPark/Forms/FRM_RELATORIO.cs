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
    /// Formulário de relatório.
    /// </summary>
    public partial class FRM_RELATORIO : Form
    {
        MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();

        /// <summary>
        /// Construtor da classe FRM_RELATORIO
        /// Inicializa os componentes do formulário de relatório.
        /// </summary>
        public FRM_RELATORIO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Métódo para consultar o histórico do estacionamento filtrando pelo CPF do cliente.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_HISTORICO_CPF()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_HISTORICO_CPF(TXT_CPF.Text);
                DGV_DADOS.CurrentCell = null;

                CONTAR_TOTAL_REGISTROS();
                ADICIONAR_LINHA_TOTAL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Métódo para consultar o histórico do estacionamento filtrando pela placa do veículo.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_HISTORICO_PLACA()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_HISTORICO_PLACA(TXT_PLACA.Text);
                DGV_DADOS.CurrentCell = null;

                CONTAR_TOTAL_REGISTROS();
                ADICIONAR_LINHA_TOTAL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Métódo para consultar o histórico do estacionamento filtrando por um range de data de entrada.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_HISTORICO_DATA_ENTRADA_RANGE()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_HISTORICO_DATA_ENTRADA_RANGE(DTP1_ENTRADA_RANGE.Value.ToString(), DTP2_ENTRADA_RANGE.Value.ToString());
                DGV_DADOS.CurrentCell = null;

                CONTAR_TOTAL_REGISTROS();
                ADICIONAR_LINHA_TOTAL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para criar a linha de total no GridView.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void ADICIONAR_LINHA_TOTAL()
        {
            try
            {
                if (DGV_DADOS.Rows.Count > 0)
                {
                    DataTable dt = (DataTable)DGV_DADOS.DataSource;

                    decimal total = dt.AsEnumerable().Sum(row => row.Field<decimal>("VALOR PAGO"));

                    // Adiciona uma linha com o total
                    DataRow totalRow = dt.NewRow();
                    totalRow["VEÍCULO"] = "Total"; // Coluna de descrição
                    totalRow["VALOR PAGO"] = total;       // Coluna de valor
                    dt.Rows.Add(totalRow);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para contar o número de registros.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONTAR_TOTAL_REGISTROS()
        {
            try
            {
                if (DGV_DADOS.Rows.Count == 1)
                {
                    LBL_REGISTROS.Text = DGV_DADOS.Rows.Count.ToString() + " Registro";
                }
                else
                {
                    LBL_REGISTROS.Text = DGV_DADOS.Rows.Count.ToString() + " Registros";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Métódo para consultar o histórico do estacionamento filtrando pela data de entrada.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_HISTORICO_DATA_ENTRADA()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_HISTORICO_DATA_ENTRADA(DTP_ENTRADA.Value.ToString());
                DGV_DADOS.CurrentCell = null;

                CONTAR_TOTAL_REGISTROS();
                ADICIONAR_LINHA_TOTAL();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para carregar a ComboBox de Consultar Por.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CARREGAR_COMBO_CONSULTAR()
        {
            try
            {
                List<string> listaTiposFiltros = new List<string>()
                {
                    "Data Entrada",
                    "Range Data Entrada",
                    "Placa",
                    "CPF"
                };

                CBX_CONSULTAR_POR.DataSource = listaTiposFiltros;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para limpar dados.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void LIMPAR_DADOS()
        {
            try
            {
                CBX_CONSULTAR_POR.SelectedIndex = -1;

                BTN_CONSULTAR.Visible = false;
                SEP_CONSULTAR.Visible = false;
                LBL_ENTRADA_RANGE.Visible = false;
                DTP1_ENTRADA_RANGE.Visible = false;
                DTP2_ENTRADA_RANGE.Visible = false;
                LBL_ATE_RANGE.Visible = false;
                LBL_PLACA.Visible = false;
                TXT_PLACA.Visible = false;
                LBL_CPF.Visible = false;
                TXT_CPF.Visible = false;
                LBL_DATA_ENTRADA.Visible = false;
                DTP_ENTRADA.Visible = false;

                TXT_PLACA.Text = "";
                TXT_CPF.Text = "";

                CONSULTAR_HISTORICO();
                DGV_DADOS.CurrentCell = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Métódo para consultar o histórico total do estacionamento.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_HISTORICO()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_HISTORICO();
                DGV_DADOS.CurrentCell = null;

                CONTAR_TOTAL_REGISTROS();
                ADICIONAR_LINHA_TOTAL();
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
                DGV_DADOS.Columns["NOME CLIENTE"].Visible = false;
                DGV_DADOS.Columns["PLACA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGV_DADOS.Columns["VALOR PAGO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGV_DADOS.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Configurar o DataGridView para não quebrar o texto no cabeçalho
                DGV_DADOS.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // Ajustar a altura automaticamente (opcional)
                DGV_DADOS.AutoResizeColumnHeadersHeight();

                // Configurando linha de total.
                foreach (DataGridViewRow row in DGV_DADOS.Rows)
                {
                    // Verifica se a célula da coluna "VEÍCULO" contém o texto "Total"
                    if (row.Cells["VEÍCULO"].Value?.ToString() == "Total")
                    {
                        // Aplica o estilo na célula de descrição
                        row.Cells["VEÍCULO"].Style.Font = new Font(DGV_DADOS.Font, FontStyle.Bold); // Negrito
                        row.Cells["VEÍCULO"].Style.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhar à direita

                        // Aplica o estilo na célula do valor
                        row.Cells["VALOR PAGO"].Style.Font = new Font(DGV_DADOS.Font, FontStyle.Bold); // Negrito
                        //row.Cells["VALOR"].Style.ForeColor = Color.DarkGreen; // Cor do texto (opcional)

                        //row.Cells["VEÍCULO"].Style.BackColor = SystemColors.ControlLight;
                        //row.Cells["VALOR PAGO"].Style.BackColor = SystemColors.ControlLight;

                        row.DefaultCellStyle.BackColor = SystemColors.ControlLight; // Cor de fundo
                        //row.DefaultCellStyle.BackColor = Color.LightGray; // Cor de fundo
                    }
                }

                DGV_DADOS.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Evento de carregamento do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_RELATORIO_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_HISTORICO();
                CARREGAR_COMBO_CONSULTAR();
                CBX_CONSULTAR_POR.SelectedIndex = -1;
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
        /// Evento para formatar as celulas.
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
        /// Evento de quando o formulário aparece pela primeira vez.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_RELATORIO_Shown(object sender, EventArgs e)
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
        /// Evento de clique em cada item da lista da ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBX_CONSULTAR_POR_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                switch (CBX_CONSULTAR_POR.Text)
                {
                    case "Data Entrada":

                        CONSULTAR_HISTORICO();

                        BTN_CONSULTAR.Visible = false;
                        SEP_CONSULTAR.Visible = false;
                        LBL_ENTRADA_RANGE.Visible = false;
                        DTP1_ENTRADA_RANGE.Visible = false;
                        DTP2_ENTRADA_RANGE.Visible = false;
                        LBL_ATE_RANGE.Visible = false;
                        LBL_PLACA.Visible = false;
                        TXT_PLACA.Visible = false;
                        LBL_CPF.Visible = false;
                        TXT_CPF.Visible = false;

                        LBL_DATA_ENTRADA.Visible = true;
                        DTP_ENTRADA.Visible = true;

                        break;

                    case "Range Data Entrada":

                        CONSULTAR_HISTORICO();

                        LBL_PLACA.Visible = false;
                        TXT_PLACA.Visible = false;
                        LBL_CPF.Visible = false;
                        TXT_CPF.Visible = false;
                        LBL_DATA_ENTRADA.Visible = false;
                        DTP_ENTRADA.Visible = false;

                        BTN_CONSULTAR.Visible = true;
                        SEP_CONSULTAR.Visible = true;
                        LBL_ENTRADA_RANGE.Visible = true;
                        DTP1_ENTRADA_RANGE.Visible = true;
                        DTP2_ENTRADA_RANGE.Visible = true;
                        LBL_ATE_RANGE.Visible = true;

                        break;

                    case "Placa":

                        CONSULTAR_HISTORICO();

                        BTN_CONSULTAR.Visible = false;
                        SEP_CONSULTAR.Visible = false;
                        LBL_CPF.Visible = false;
                        TXT_CPF.Visible = false;
                        LBL_DATA_ENTRADA.Visible = false;
                        DTP_ENTRADA.Visible = false;
                        LBL_ENTRADA_RANGE.Visible = false;
                        DTP1_ENTRADA_RANGE.Visible = false;
                        DTP2_ENTRADA_RANGE.Visible = false;
                        LBL_ATE_RANGE.Visible = false;

                        LBL_PLACA.Visible = true;
                        TXT_PLACA.Visible = true;

                        break;

                    case "CPF":

                        CONSULTAR_HISTORICO();

                        BTN_CONSULTAR.Visible = false;
                        SEP_CONSULTAR.Visible = false;
                        LBL_DATA_ENTRADA.Visible = false;
                        DTP_ENTRADA.Visible = false;
                        LBL_ENTRADA_RANGE.Visible = false;
                        DTP1_ENTRADA_RANGE.Visible = false;
                        DTP2_ENTRADA_RANGE.Visible = false;
                        LBL_ATE_RANGE.Visible = false;
                        LBL_PLACA.Visible = false;
                        TXT_PLACA.Visible = false;

                        LBL_CPF.Visible = true;
                        TXT_CPF.Visible = true;

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento para cada vez que o valor da "DTP_ENTRADA" mudar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DTP_ENTRADA_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_HISTORICO_DATA_ENTRADA();
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
        /// Evento de clique no botão "BTN_CONSULTAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CONSULTAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_HISTORICO_DATA_ENTRADA_RANGE();
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
        /// Evento para cada ação da "TXT_PLACA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_PLACA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_HISTORICO_PLACA();
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
        /// Evento para cada ação da "TXT_PLACA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_CPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                CONSULTAR_HISTORICO_CPF();
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
