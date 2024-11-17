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
    /// Formulário de gerenciamento.
    /// </summary>
    public partial class FRM_GERENCIAMENTO : Form
    {
        private readonly MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        private MarchPark.ENT.Login.MarchPark_TBL_LOGIN ObjEnt = new ENT.Login.MarchPark_TBL_LOGIN();

        /// <summary>
        /// Construtor da classe FRM_GERENCIAMENTO
        /// Inicializa os componentes do formulário de gerenciamento.
        /// </summary>
        public FRM_GERENCIAMENTO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para alterar a tarifa.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void ALTERAR_TARIFA()
        {
            try
            {
                if ((MBX_CARRO.Text != "") && (MBX_MOTO.Text != ""))
                {
                    float tarifaCarro = float.Parse(MBX_CARRO.Text);
                    float tarifaMoto = float.Parse(MBX_MOTO.Text);

                    if ((tarifaCarro > 0) && (tarifaMoto > 0))
                    {
                        ObjNEG.ALTERAR_TARIFA(MBX_CARRO.Text.Replace(",", "."), MBX_MOTO.Text.Replace(",", "."));
                        MessageBox.Show("Tarifa alterada com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tarifa inválida. Preencha corretamente!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha corretamente!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para alterar a senha de permissão.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void ALTERAR_SENHA_PERMISSAO()
        {
            try
            {
                if (MBX_SENHA_PERMISSAO.Text.Length != 0)
                {
                    if (MBX_SENHA_PERMISSAO.Text.Length >= 4)
                    {
                        ObjNEG.ALTERAR_SENHA_PERMISSAO(MBX_SENHA_PERMISSAO.Text);
                        MessageBox.Show("Senha de permissão alterada com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MBX_SENHA_PERMISSAO.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("A senha deve ter 4 caracteres no mínimo!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha corretamente!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para cadastrar usuario.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void INSERIR_USUARIO()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (ObjNEG.SELECT_MARCH_PARK_TBL_LOGIN_EXISTENTE(ObjEnt).Count == 0)
                    {
                        ObjNEG.INSERT_MARCH_PARK_TBL_LOGIN(ObjEnt);
                        MessageBox.Show("Usuário cadastrado com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXT_USUARIO.Text = "";
                        MBX_SENHA.Text = "";
                        MBX_CONFIRMAR_SENHA.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Este nome de usuário já existe!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_USUARIO.Text = "";
                        MBX_SENHA.Text = "";
                        MBX_CONFIRMAR_SENHA.Text = "";
                        TXT_USUARIO.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para montar entidade
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano indicando de a entidade foi montada com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool MONTAR_ENTIDADE()
        {
            try
            {
                ObjEnt = new ENT.Login.MarchPark_TBL_LOGIN();

                if (TXT_USUARIO.Text.Length != 0 && MBX_SENHA.Text.Length != 0 && MBX_CONFIRMAR_SENHA.Text.Length != 0)
                {
                    if (TXT_USUARIO.Text.Length >= 2)
                    {
                        if (MBX_SENHA.Text == MBX_CONFIRMAR_SENHA.Text)
                        {
                            if (MBX_SENHA.Text.Length >= 4)
                            {
                                ObjEnt.NOME_USUARIO = TXT_USUARIO.Text;
                                ObjEnt.SENHA_USUARIO = MBX_SENHA.Text;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("A senha deve ter no mínimo 4 caracteres.", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                MBX_SENHA.Text = "";
                                MBX_CONFIRMAR_SENHA.Text = "";
                                MBX_SENHA.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Senhas diferentes!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MBX_SENHA.Text = "";
                            MBX_CONFIRMAR_SENHA.Text = "";
                            MBX_SENHA.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome de Usuário deve ter 2 caracteres no mínimo!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_USUARIO.Text = "";
                        TXT_USUARIO.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Favor, preencher todos os campos corretamente!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Evento de clique na picbox de ver ou desver a senha nova.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PICBOX_NOVA_SENHA_Click(object sender, EventArgs e)
        {
            if (MBX_SENHA.UseSystemPasswordChar == true)
            {
                MBX_SENHA.UseSystemPasswordChar = false;
                PICBOX_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_desver;
            }
            else
            {
                MBX_SENHA.UseSystemPasswordChar = true;
                PICBOX_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            }
        }

        /// <summary>
        /// Evento de clique na picbox de ver ou desver a senha nova.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PICBOX_CONFIRMAR_SENHA_Click(object sender, EventArgs e)
        {
            if (MBX_CONFIRMAR_SENHA.UseSystemPasswordChar == true)
            {
                MBX_CONFIRMAR_SENHA.UseSystemPasswordChar = false;
                PICBOX_CONFIRMAR_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_desver;
            }
            else
            {
                MBX_CONFIRMAR_SENHA.UseSystemPasswordChar = true;
                PICBOX_CONFIRMAR_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            }
        }

        /// <summary>
        /// Evento de clique na picbox de ver ou desver a senha nova.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PICBOX_SENHA_PERMISSAO_Click(object sender, EventArgs e)
        {
            if (MBX_SENHA_PERMISSAO.UseSystemPasswordChar == true)
            {
                MBX_SENHA_PERMISSAO.UseSystemPasswordChar = false;
                PICBOX_SENHA_PERMISSAO.Image = global::MarchPark.Properties.Resources.olho_senha_desver;
            }
            else
            {
                MBX_SENHA_PERMISSAO.UseSystemPasswordChar = true;
                PICBOX_SENHA_PERMISSAO.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            }
        }

        /// <summary>
        /// Evento de clique no botão de editar tarifa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_EDITAR_TARIFA_Click(object sender, EventArgs e)
        {
            try
            {
                if (BTN_EDITAR_TARIFA.Text == "Editar")
                {
                    LBL_CARRO.Enabled = true;
                    LBL_RS1.Enabled = true;
                    MBX_CARRO.Enabled = true;
                    LBL_MOTO.Enabled = true;
                    LBL_RS2.Enabled = true;
                    MBX_MOTO.Enabled = true;
                    BTN_ALTERAR.Enabled = true;
                    LBL_HORA1.Enabled = true;
                    LBL_HORA2.Enabled = true;
                    LBL_DESC.Enabled = true;

                    MBX_CARRO.Focus();

                    BTN_EDITAR_TARIFA.Text = "Cancelar";
                }
                else
                {
                    LBL_CARRO.Enabled = false;
                    LBL_RS1.Enabled = false;
                    MBX_CARRO.Enabled = false;
                    LBL_MOTO.Enabled = false;
                    LBL_RS2.Enabled = false;
                    MBX_MOTO.Enabled = false;
                    BTN_ALTERAR.Enabled = false;
                    LBL_HORA1.Enabled = false;
                    LBL_HORA2.Enabled = false;
                    LBL_DESC.Enabled = false;

                    MBX_CARRO.Text = ObjNEG.SELECT_VALOR_TARIFA_ATUAL("Carro");
                    MBX_MOTO.Text = ObjNEG.SELECT_VALOR_TARIFA_ATUAL("Moto");

                    BTN_EDITAR_TARIFA.Text = "Editar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique no botão de editar usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_EDITAR_USUARIO_Click(object sender, EventArgs e)
        {
            try
            {
                if (BTN_EDITAR_USUARIO.Text == "Editar")
                {
                    MarchPark.Forms.FRM_PERMISSAO FRM_PERMISSAO = new MarchPark.Forms.FRM_PERMISSAO(2);
                    FRM_PERMISSAO.ShowDialog();

                    if (FRM_PERMISSAO.MONTAR_ENTIDADE() == true)
                    {

                        if (FRM_PERMISSAO.CONSULTAR_SENHA() == true)
                        {
                            groupBox2.Enabled = true;
                            groupBox3.Enabled = true;
                            LBL_USUARIO.Enabled = true;
                            TXT_USUARIO.Enabled = true;
                            LBL_SENHA.Enabled = true;
                            MBX_SENHA.Enabled = true;
                            PICBOX_SENHA.Enabled = true;
                            LBL_CONFIRMAR_SENHA.Enabled = true;
                            MBX_CONFIRMAR_SENHA.Enabled = true;
                            PICBOX_CONFIRMAR_SENHA.Enabled = true;
                            BTN_CADASTRAR.Enabled = true;
                            MBX_SENHA_PERMISSAO.Enabled = true;
                            PICBOX_SENHA_PERMISSAO.Enabled = true;
                            BTN_ALTERAR_SENHA_PERMISSAO.Enabled = true;
                            LBL_LINHA.Enabled = true;
                            BTN_GER_USUARIOS.Enabled = true;

                            BTN_EDITAR_USUARIO.Text = "Cancelar";
                        }
                    }

                }
                else
                {
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    LBL_USUARIO.Enabled = false;
                    TXT_USUARIO.Enabled = false;
                    LBL_SENHA.Enabled = false;
                    MBX_SENHA.Enabled = false;
                    PICBOX_SENHA.Enabled = false;
                    LBL_CONFIRMAR_SENHA.Enabled = false;
                    MBX_CONFIRMAR_SENHA.Enabled = false;
                    PICBOX_CONFIRMAR_SENHA.Enabled = false;
                    BTN_CADASTRAR.Enabled = false;
                    MBX_SENHA_PERMISSAO.Enabled = false;
                    PICBOX_SENHA_PERMISSAO.Enabled = false;
                    BTN_ALTERAR_SENHA_PERMISSAO.Enabled = false;
                    LBL_LINHA.Enabled = false;
                    BTN_GER_USUARIOS.Enabled = false;

                    TXT_USUARIO.Text = "";
                    MBX_SENHA.Text = "";
                    MBX_CONFIRMAR_SENHA.Text = "";
                    MBX_SENHA_PERMISSAO.Text = "";

                    BTN_EDITAR_USUARIO.Text = "Editar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique no botão "BTN_CADASTRAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                INSERIR_USUARIO();
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
        /// Evento de clique no botão "BTN_ALTERAR_SENHA_PERMISSAO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ALTERAR_SENHA_PERMISSAO_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (MessageBox.Show("Realmente deseja alterar a senha de permissão?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ALTERAR_SENHA_PERMISSAO();
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
        /// Evento de ação KeyDown da "TXT_CARRO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_CARRO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MBX_MOTO.Focus();
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de ação KeyDown da "TXT_MOTO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_MOTO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de ação KeyDown da "TXT_USUARIO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_USUARIO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MBX_SENHA.Focus();
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de ação KeyDown da "MBX_SENHA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_SENHA_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MBX_CONFIRMAR_SENHA.Focus();
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de ação KeyDown da "MBX_CONFIRMAR_SENHA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_CONFIRMAR_SENHA_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BTN_CADASTRAR_Click(sender, e);
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de ação KeyDown da "MBX_SENHA_PERMISSAO". 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_SENHA_PERMISSAO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BTN_ALTERAR_SENHA_PERMISSAO_Click(sender, e);
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
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
        private void FRM_GERENCIAMENTO_Load(object sender, EventArgs e)
        {
            try
            {
                MBX_CARRO.Text = ObjNEG.SELECT_VALOR_TARIFA_ATUAL("Carro");
                MBX_MOTO.Text = ObjNEG.SELECT_VALOR_TARIFA_ATUAL("Moto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Realmente deseja alterar a tarifa?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ALTERAR_TARIFA();
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
        /// Evento KeyPress da "MBX_CARRO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_CARRO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado é um número ou a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede a entrada
            }

            // Permitir Backspace e Delete
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }

            //// Verifica o comprimento do texto (removendo os caracteres de máscara)
            string textoAtual = MBX_CARRO.Text.Replace("_", "").Replace(",", "").Replace(".", "");

            if (textoAtual.Length >= 4)
            {
                // Impede a entrada se já tiver 5 caracteres
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento TextChanged da "MBX_MOTO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_MOTO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Captura o texto atual removendo caracteres da máscara
                string textoAtual = MBX_MOTO.Text.Replace("_", "").Replace(",", "").Replace(".", "");

                // Verifica se são 3 dígitos
                if (textoAtual.Length == 3)
                {
                    // Atualiza o texto no formato "0.00"
                    MBX_MOTO.Text = $"{textoAtual.Substring(0, 1)},{textoAtual.Substring(1, 2)}";
                    MBX_MOTO.SelectionStart = MBX_MOTO.Text.Length; // Move o cursor para o final
                }
                // Verifica se são 4 dígitos
                else if (textoAtual.Length == 4)
                {
                    // Atualiza o texto no formato "00,00"
                    MBX_MOTO.Text = $"{textoAtual.Substring(0, 2)},{textoAtual.Substring(2, 2)}";
                    MBX_MOTO.SelectionStart = MBX_MOTO.Text.Length; // Move o cursor para o final
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento Keypress da "MBX_MOTO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_MOTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica se o caractere digitado é um número ou a tecla Backspace
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Impede a entrada
                }

                // Permitir Backspace e Delete
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                {
                    return;
                }

                //// Verifica o comprimento do texto (removendo os caracteres de máscara)
                string textoAtual = MBX_MOTO.Text.Replace("_", "").Replace(",", "").Replace(".", "");

                if (textoAtual.Length >= 4)
                {
                    // Impede a entrada se já tiver 5 caracteres
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento TextChanged da "MBX_CARRO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_CARRO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Captura o texto atual removendo caracteres da máscara
                string textoAtual = MBX_CARRO.Text.Replace("_", "").Replace(",", "").Replace(".", "");

                // Verifica se são 3 dígitos
                if (textoAtual.Length == 3)
                {
                    // Atualiza o texto no formato "0.00"
                    MBX_CARRO.Text = $"{textoAtual.Substring(0, 1)},{textoAtual.Substring(1, 2)}";
                    MBX_CARRO.SelectionStart = MBX_CARRO.Text.Length; // Move o cursor para o final
                }
                // Verifica se são 4 dígitos
                else if (textoAtual.Length == 4)
                {
                    // Atualiza o texto no formato "00,00"
                    MBX_CARRO.Text = $"{textoAtual.Substring(0, 2)},{textoAtual.Substring(2, 2)}";
                    MBX_CARRO.SelectionStart = MBX_CARRO.Text.Length; // Move o cursor para o final
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento Leave da "MBX_CARRO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_CARRO_Leave(object sender, EventArgs e)
        {
            try
            {
                if (MBX_CARRO.Text.Length == 0)
                {
                    MBX_CARRO.Text = ObjNEG.SELECT_VALOR_TARIFA_ATUAL("Carro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento Leave da "MBX_MOTO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_MOTO_Leave(object sender, EventArgs e)
        {
            try
            {
                if (MBX_MOTO.Text.Length == 0)
                {
                    MBX_MOTO.Text = ObjNEG.SELECT_VALOR_TARIFA_ATUAL("Moto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento KeyDown da "MBX_CARRO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_CARRO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MBX_MOTO.Focus();
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento KeyDown da "MBX_MOTO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_MOTO_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BTN_ALTERAR_Click(sender, e);
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
