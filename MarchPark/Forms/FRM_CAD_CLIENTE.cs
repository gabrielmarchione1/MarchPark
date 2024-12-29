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
using System.Xml.Linq;

namespace MarchPark.Forms
{
    /// <summary>
    /// Formulário de cadastro de clientes.
    /// </summary>
    public partial class FRM_CAD_CLIENTE : Form
    {
        MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        private int ID_CLIENTE;
        private List<string> listaCampos = new List<string>();

        /// <summary>
        /// Construtor da classe FRM_CAD_CLIENTE
        /// Inicializa os componentes do formulário de cadastro de cliente.
        /// </summary>
        public FRM_CAD_CLIENTE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para deletar clientes.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DELETAR_CLIENTES()
        {
            try
            {
                if (MessageBox.Show("Deseja realmente deletar este(s) cliente(s)?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<string> idClientes = new List<string>();

                    foreach (DataGridViewRow item in DGV_DADOS.Rows)
                    {
                        if (Convert.ToBoolean(item.Cells["checkBoxColumn"].Value) == true)
                        {
                            idClientes.Add(item.Cells["ID_CLIENTE"].Value.ToString());
                        }
                    }

                    if (idClientes.Count > 0)
                    {
                        ObjNEG.DELETAR_CLIENTES(idClientes);
                        MessageBox.Show("Cliente(s) deletado(s) com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CONSULTAR_CLIENTES();
                        LIMPAR_DADOS();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Selecione pelo menos uma linha!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para alterar cliente.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ALTERAR_CLIENTE()
        {
            try
            {
                bool CamposValidados = true;
                listaCampos = new List<string>();

                if (TXT_NOME.Text.Length == 0)
                {
                    listaCampos.Add("Nome");
                    CamposValidados = false;
                }

                if (MBX_CPF.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Length != 11)
                {
                    listaCampos.Add("CPF");
                    CamposValidados = false;
                }

                if (MBX_DATA_NASCIMENTO.Text.Replace("/", "").Replace(" ", "").Length != 8 || Convert.ToInt32(MBX_DATA_NASCIMENTO.Text.Substring(0, 2)) > 31 || Convert.ToInt32(MBX_DATA_NASCIMENTO.Text.Substring(3, 2)) > 12 || Convert.ToInt32(MBX_DATA_NASCIMENTO.Text.Substring(6, 4)) >= 2024)
                {
                    listaCampos.Add("Data Nascimento");
                    CamposValidados = false;
                }

                if ((MBX_TELEFONE.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Length != 0) && (MBX_TELEFONE.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Length != 11))
                {
                    listaCampos.Add("Telefone");
                    CamposValidados = false;
                }

                if ((TXT_EMAIL.Text.Length != 0) && (!TXT_EMAIL.Text.Contains("@") || !TXT_EMAIL.Text.Contains(".com")))
                {
                    listaCampos.Add("Email");
                    CamposValidados = false;
                }


                if (CamposValidados)
                {
                    ObjNEG.ALTERAR_CLIENTE(TXT_NOME.Text, MBX_CPF.Text.Replace(".", "").Replace("-", ""), MBX_DATA_NASCIMENTO.Text, MBX_TELEFONE.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""), TXT_EMAIL.Text, ID_CLIENTE);
                    MessageBox.Show("Cliente alterado com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CONSULTAR_CLIENTES();
                    LIMPAR_DADOS();
                    listaCampos = null;
                    ID_CLIENTE = 0;
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
        /// Método para trazer pra tela os dados do cliente a ser alterado.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void MONTAR_ALTERACAO()
        {
            try
            {
                BTN_ADICIONAR.Enabled = false;
                BTN_DELETAR.Enabled = false;
                MBX_CPF.Enabled = false;
                MBX_DATA_NASCIMENTO.Enabled = false;
                DGV_DADOS.Enabled = false;
                TXT_PESQUISAR_NOME.Enabled = false;

                BTN_LIMPAR_DADOS.Text = "Limpar/Desfazer";

                ID_CLIENTE = Convert.ToInt32(DGV_DADOS.CurrentRow.Cells["ID_CLIENTE"].Value.ToString());
                TXT_NOME.Text = DGV_DADOS.CurrentRow.Cells["NOME"].Value.ToString();
                MBX_CPF.Text = DGV_DADOS.CurrentRow.Cells["CPF"].Value.ToString();
                MBX_DATA_NASCIMENTO.Text = DGV_DADOS.CurrentRow.Cells["NASCIMENTO"].Value.ToString();
                MBX_TELEFONE.Text = DGV_DADOS.CurrentRow.Cells["TELEFONE"].Value.ToString();
                TXT_EMAIL.Text = DGV_DADOS.CurrentRow.Cells["EMAIL"].Value.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir cliente.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_CLIENTE()
        {
            try
            {
                bool CamposValidados = true;
                listaCampos = new List<string>();

                if (TXT_NOME.Text.Length == 0)
                {
                    listaCampos.Add("Nome");
                    CamposValidados = false;
                }

                if (MBX_CPF.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Length != 11)
                {
                    listaCampos.Add("CPF");
                    CamposValidados = false;
                }

                if (MBX_DATA_NASCIMENTO.Text.Replace("/", "").Replace(" ", "").Length != 8 || Convert.ToInt32(MBX_DATA_NASCIMENTO.Text.Substring(0, 2)) > 31 || Convert.ToInt32(MBX_DATA_NASCIMENTO.Text.Substring(3, 2)) > 12 || Convert.ToInt32(MBX_DATA_NASCIMENTO.Text.Substring(6, 4)) >= 2024)
                {
                    listaCampos.Add("Data Nascimento");
                    CamposValidados = false;
                }

                if ((MBX_TELEFONE.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Length != 0) && (MBX_TELEFONE.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Length != 11))
                {
                    listaCampos.Add("Telefone");
                    CamposValidados = false;
                }

                if ((TXT_EMAIL.Text.Length != 0) && (!TXT_EMAIL.Text.Contains("@") || !TXT_EMAIL.Text.Contains(".com")))
                {
                    listaCampos.Add("Email");
                    CamposValidados = false;
                }


                if (CamposValidados)
                {
                    if (!ObjNEG.SELECT_CLIENTE_EXISTENTE(MBX_CPF.Text.Replace(".", "").Replace("-", "").Replace(" ", "")))
                    {
                        ObjNEG.INSERIR_CLIENTE(TXT_NOME.Text, MBX_CPF.Text.Replace(".", "").Replace("-", ""), MBX_DATA_NASCIMENTO.Text, MBX_TELEFONE.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""), TXT_EMAIL.Text);
                        MessageBox.Show("Cliente inserido com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CONSULTAR_CLIENTES();
                        LIMPAR_DADOS();
                        listaCampos = null;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Este CPF já existe!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MBX_CPF.Focus();
                        return false;
                    }                  
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
        /// Método para pesquisar clientes especifícos.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void PESQUISAR_CLIENTES()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.PESQUISAR_CLIENTES_ESPECIFICO(TXT_PESQUISAR_NOME.Text);
                DGV_DADOS.CurrentCell = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para consultar clientes.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void CONSULTAR_CLIENTES()
        {
            try
            {
                DGV_DADOS.DataSource = null;
                DGV_DADOS.DataSource = ObjNEG.SELECT_CLIENTES();
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
                DGV_DADOS.Columns["ID_CLIENTE"].Visible = false;
                DGV_DADOS.Columns["NASCIMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGV_DADOS.Columns["TELEFONE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //DGV_DADOS.Columns["CPF"].DefaultCellStyle.Format = $@"000,000,000-00";
                DGV_DADOS.AutoResizeColumns();
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
                BTN_ADICIONAR.Enabled = true;
                BTN_DELETAR.Enabled = true;
                MBX_CPF.Enabled = true;
                MBX_DATA_NASCIMENTO.Enabled = true;
                DGV_DADOS.Enabled = true;
                TXT_PESQUISAR_NOME.Enabled = true;

                BTN_LIMPAR_DADOS.Text = "Limpar";

                TXT_NOME.Text = "";
                MBX_CPF.Text = "";
                TXT_PESQUISAR_NOME.Text = "";
                MBX_DATA_NASCIMENTO.Text = "";
                MBX_TELEFONE.Text = "";
                TXT_EMAIL.Text = "";

                foreach (DataGridViewRow row in DGV_DADOS.Rows)
                {
                    row.Cells["checkBoxColumn"].Value = false;
                }

                DGV_DADOS.CurrentCell = null;

                TXT_NOME.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
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

                if (DGV_DADOS.Columns[e.ColumnIndex].Name == "TELEFONE")
                {
                    if (e.Value != null && e.Value is string telefone && telefone.Length == 11) // Exemplo para números com 11 dígitos
                    {
                        // Aplica a formatação no estilo: (00) 00000-0000
                        e.Value = $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
                        e.FormattingApplied = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de carregamento do form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_CAD_CLIENTE_Load(object sender, EventArgs e)
        {
            try
            {
                CONSULTAR_CLIENTES();
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
        private void FRM_CAD_CLIENTE_Shown(object sender, EventArgs e)
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
        /// Evento para cada ação da "TXT_PESQUISAR_NOME".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_PESQUISAR_NOME_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                PESQUISAR_CLIENTES();
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
                INSERIR_CLIENTE();
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
                MONTAR_ALTERACAO();
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
        /// Evento de clique no botão "BTN_ALTERAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (MessageBox.Show("Deseja realmente alterar este cliente?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ALTERAR_CLIENTE();
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

        /// <summary>
        /// Evento de clique no botão "BTN_DELETAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_DELETAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DELETAR_CLIENTES(); 
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
        /// Evento KeyPress da "TXT_NOME".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_NOME_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas letras, espaço e a tecla de backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a tecla
            }
        }
    }
}
