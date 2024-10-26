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
    /// Formulário de usuario ativo.
    /// </summary>
    public partial class FRM_USUARIO_ATIVO : Form
    {
        private readonly MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        /// <summary>
        /// Construtor da classe FRM_USUARIO_ATIVO
        /// Inicializa os componentes do formulário de usuario ativo.
        /// </summary>
        public FRM_USUARIO_ATIVO(string UsuarioAtivo)
        {
            InitializeComponent();
            LBL_USUARIO_ATIVO.Text = UsuarioAtivo;
            TXT_NOME_ATUAL.Text = UsuarioAtivo;
        }

        public bool ALTERAR_USUARIO()
        {
            try
            {
                if ((TXT_NOME_NOVO.Text.Length != 0) && (LBL_VALIDAR_SENHA_NOVA.Text == "Senha Válida")) // usuario e senha
                {
                    if (TXT_NOME_NOVO.Text.Length >= 2)
                    {
                        if (MBX_NOVA_SENHA.Text.Length >= 4)
                        {
                            if (MessageBox.Show("Deseja realmente alterar o nome de usuário e senha?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ObjNEG.ALTERAR_USUARIO_SENHA_ATIVO(TXT_NOME_ATUAL.Text, TXT_NOME_NOVO.Text, MBX_NOVA_SENHA.Text, 1);
                                MessageBox.Show("Usuário e Senha alterado com sucesso!\nSerá necessário reiniciar o sistema para validar as alterações.", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("A senha deve ter 4 caracteres no mínimo!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MBX_NOVA_SENHA.Text = "";
                            MBX_CONFIRMAR_SENHA.Text = "";
                            MBX_NOVA_SENHA.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário deve ter 2 caracteres no mínimo!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_NOME_NOVO.Text = "";
                        TXT_NOME_NOVO.Focus();
                        return false;
                    }
                }
                else if ((TXT_NOME_NOVO.Text.Length != 0) && (LBL_VALIDAR_SENHA_NOVA.Text != "Senha Válida")) // usuario
                {
                    if (TXT_NOME_NOVO.Text.Length >= 2)
                    {
                        if (MessageBox.Show("Deseja realmente alterar o nome de usuário?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ObjNEG.ALTERAR_USUARIO_SENHA_ATIVO(TXT_NOME_ATUAL.Text, TXT_NOME_NOVO.Text, MBX_NOVA_SENHA.Text, 2);
                            MessageBox.Show("Usuário alterado com sucesso!\nSerá necessário reiniciar o sistema para validar as alterações.", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário deve ter 2 caracteres no mínimo!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_NOME_NOVO.Text = "";
                        TXT_NOME_NOVO.Focus();
                        return false;
                    }
                }
                else if ((TXT_NOME_NOVO.Text.Length == 0) && (LBL_VALIDAR_SENHA_NOVA.Text == "Senha Válida")) // senha
                {
                    if (MBX_NOVA_SENHA.Text.Length >= 4)
                    {
                        if (MessageBox.Show("Deseja realmente alterar a senha?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ObjNEG.ALTERAR_USUARIO_SENHA_ATIVO(TXT_NOME_ATUAL.Text, TXT_NOME_NOVO.Text, MBX_NOVA_SENHA.Text, 3);
                            MessageBox.Show("Senha alterada com sucesso!\nSerá necessário reiniciar o sistema para validar as alterações.", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A senha deve ter 4 caracteres no mínimo!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MBX_NOVA_SENHA.Text = "";
                        MBX_CONFIRMAR_SENHA.Text = "";
                        MBX_NOVA_SENHA.Focus();
                        return false;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para validar a senha atual.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public bool VALIDAR_SENHA_ATUAL()
        {
            try
            {
                if (MBX_SENHA_ATUAL.Text.Length != 0)
                {
                    if (ObjNEG.VALIDAR_SENHA_ATUAL_USUARIO_ATIVO(TXT_NOME_ATUAL.Text, MBX_SENHA_ATUAL.Text))
                    {
                        LBL_NOVA_SENHA.Enabled = true;
                        MBX_NOVA_SENHA.Enabled = true;
                        LBL_CONFIRMAR_SENHA.Enabled = true;
                        MBX_CONFIRMAR_SENHA.Enabled = true;
                        MBX_SENHA_ATUAL.Enabled = false;
                        PICBOX_NOVA_SENHA.Enabled = true;
                        PICBOX_CONFIRMAR_SENHA.Enabled = true;
                        PICBOX_VALIDAR_SENHA.Image = global::MarchPark.Properties.Resources.validar;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MBX_SENHA_ATUAL.Text = "";
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Favor, preencher o campo de senha atual!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Evento de clique no botão de editar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (BTN_EDITAR.Text == "Editar")
                {
                    LBL_ALTERAR_NOME.Enabled = true;
                    LBL_NOME_ATUAL.Enabled = true;
                    LBL_NOME_NOVO.Enabled = true;
                    TXT_NOME_NOVO.Enabled = true;
                    LBL_LINHA_INFERIOR.Enabled = true;
                    LBL_ALTERAR_SENHA.Enabled = true;
                    LBL_SENHA_ATUAL.Enabled = true;
                    MBX_SENHA_ATUAL.Enabled = true;
                    BTN_VALIDAR_SENHA.Enabled = true;
                    BTN_ALTERAR.Enabled = true;

                    BTN_EDITAR.Text = "Cancelar";
                }
                else
                {
                    LBL_ALTERAR_NOME.Enabled = false;
                    LBL_NOME_ATUAL.Enabled = false;
                    LBL_NOME_NOVO.Enabled = false;
                    TXT_NOME_NOVO.Enabled = false;
                    LBL_LINHA_INFERIOR.Enabled = false;
                    LBL_ALTERAR_SENHA.Enabled = false;
                    LBL_SENHA_ATUAL.Enabled = false;
                    MBX_SENHA_ATUAL.Enabled = false;
                    BTN_VALIDAR_SENHA.Enabled = false;
                    LBL_NOVA_SENHA.Enabled = false;
                    MBX_NOVA_SENHA.Enabled = false;
                    LBL_CONFIRMAR_SENHA.Enabled = false;
                    MBX_CONFIRMAR_SENHA.Enabled = false;
                    BTN_ALTERAR.Enabled = false;
                    PICBOX_NOVA_SENHA.Enabled = false;
                    PICBOX_CONFIRMAR_SENHA.Enabled = false;

                    PICBOX_VALIDAR_SENHA.Image = null;
                    BTN_VALIDAR_SENHA.Visible = true;

                    TXT_NOME_NOVO.Text = "";
                    MBX_SENHA_ATUAL.Text = "";
                    MBX_NOVA_SENHA.Text = "";
                    MBX_CONFIRMAR_SENHA.Text = "";

                    BTN_EDITAR.Text = "Editar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique no botão de validar senha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_VALIDAR_SENHA_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (VALIDAR_SENHA_ATUAL())
                {
                    BTN_VALIDAR_SENHA.Visible = false;
                    BTN_ALTERAR.Enabled = false;
                    MBX_NOVA_SENHA.Focus();
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
        /// Evento de quando uma tecla é solta quando estiver digitando na "MBX_CONFIRMAR_SENHA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_CONFIRMAR_SENHA_KeyUp(object sender, KeyEventArgs e)
        {
            if (MBX_CONFIRMAR_SENHA.Text == "")
            {
                LBL_VALIDAR_SENHA_NOVA.Text = "";
                BTN_ALTERAR.Enabled = false;
            }
            else if (MBX_CONFIRMAR_SENHA.Text == MBX_NOVA_SENHA.Text)
            {
                LBL_VALIDAR_SENHA_NOVA.ForeColor = Color.Green;
                LBL_VALIDAR_SENHA_NOVA.Text = "Senha Válida";
                BTN_ALTERAR.Enabled = true;
            }
            else
            {
                LBL_VALIDAR_SENHA_NOVA.ForeColor = Color.Red;
                LBL_VALIDAR_SENHA_NOVA.Text = "Senha Diferente";
                BTN_ALTERAR.Enabled = false;
            }
        }

        /// <summary>
        /// Impede a entrada de aspas simples ('), aspas duplas (") e barra invertida (\) no TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_SENHA_ATUAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é uma aspa simples, aspa dupla ou barra invertida
            if (e.KeyChar == '\'' || e.KeyChar == '\"' || e.KeyChar == '\\' || e.KeyChar == ' ')
            {
                // Impede a entrada do caractere proibido
                e.Handled = true;
            }
        }

        /// <summary>
        /// Impede a entrada de aspas simples ('), aspas duplas (") e barra invertida (\) no TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_NOVA_SENHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é uma aspa simples, aspa dupla ou barra invertida
            if (e.KeyChar == '\'' || e.KeyChar == '\"' || e.KeyChar == '\\' || e.KeyChar == ' ')
            {
                // Impede a entrada do caractere proibido
                e.Handled = true;
            }
        }

        /// <summary>
        /// Impede a entrada de aspas simples ('), aspas duplas (") e barra invertida (\) no TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MBX_CONFIRMAR_SENHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é uma aspa simples, aspa dupla ou barra invertida
            if (e.KeyChar == '\'' || e.KeyChar == '\"' || e.KeyChar == '\\' || e.KeyChar == ' ')
            {
                // Impede a entrada do caractere proibido
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento de clique na picbox de ver ou desver a senha nova.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PICBOX_NOVA_SENHA_Click(object sender, EventArgs e)
        {
            if (MBX_NOVA_SENHA.UseSystemPasswordChar == true)
            {
                MBX_NOVA_SENHA.UseSystemPasswordChar = false;
                PICBOX_NOVA_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_desver;
            }
            else
            {
                MBX_NOVA_SENHA.UseSystemPasswordChar = true;
                PICBOX_NOVA_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            }
        }

        /// <summary>
        /// Evento de clique na picbox de ver ou desver a confirmação da senha nova.
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
        /// Evento de clique no botão de alterar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                if (ALTERAR_USUARIO())
                {
                    // Armazena o caminho do executável atual
                    string applicationPath = Application.ExecutablePath;

                    // Finaliza a aplicação atual
                    Application.Exit();

                    // Inicia uma nova instância da aplicação
                    System.Diagnostics.Process.Start(applicationPath);
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
        /// Permite apenas letras e números no TextBox, bloqueando todos os caracteres especiais.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_NOME_NOVO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas letras (A-Z, a-z) e números (0-9)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Impede a entrada do caractere não permitido
                e.Handled = true;
            }
        }
    }
}
