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
    /// Formulário de Cadastro de Usuário.
    /// </summary>
    public partial class FRM_CAD_USUARIO : Form
    {
        private readonly MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        private MarchPark.ENT.Login.MarchPark_TBL_LOGIN ObjEnt = new ENT.Login.MarchPark_TBL_LOGIN();

        /// <summary>
        /// Construtor da classe FRM_CAD_USUARIO
        /// Inicializa os componentes do formulário de cadastro de usuário.
        /// </summary>
        public FRM_CAD_USUARIO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para inserir usuário.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano indicando se o usuário foi inserido com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool INSERIR_USUARIO()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (MBX_SENHA.Text == MBX_CONFIRMAR_SENHA.Text)
                    {
                        if (ObjNEG.SELECT_MARCH_PARK_TBL_LOGIN_EXISTENTE(ObjEnt).Count == 0)
                        {
                            ObjNEG.INSERT_MARCH_PARK_TBL_LOGIN(ObjEnt);
                            MessageBox.Show("Usuário cadastrado com sucesso!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Este nome de usuário já existe!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TXT_USUARIO.Text = "";
                            MBX_SENHA.Text = "";
                            MBX_CONFIRMAR_SENHA.Text = "";
                            TXT_USUARIO.Focus();
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

                if (TXT_USUARIO.Text.Length == 0)
                {
                    return false;
                }
                if (MBX_SENHA.Text.Length == 0)
                {
                    return false;
                }
                if (MBX_CONFIRMAR_SENHA.Text.Length == 0)
                {
                    return false;
                }

                ObjEnt.NOME_USUARIO = TXT_USUARIO.Text;
                ObjEnt.SENHA_USUARIO = MBX_SENHA.Text;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Evento de clique do botão "BTN_SAIR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_SAIR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                this.Close();
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
        /// Evento de clique do botão "BTN_CADASTRAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (INSERIR_USUARIO())
                {
                    this.Close();
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
        /// Permite apenas letras e números no TextBox, bloqueando todos os caracteres especiais.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXT_USUARIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas letras (A-Z, a-z) e números (0-9)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Impede a entrada do caractere não permitido
                e.Handled = true;
            }
        }

        /// <summary>
        /// Impede a entrada de aspas simples ('), aspas duplas (") e barra invertida (\) no TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_SENHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é uma aspa simples, aspa dupla ou barra invertida
            if (e.KeyChar == '\'' || e.KeyChar == '\"' || e.KeyChar == '\\')
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
            if (e.KeyChar == '\'' || e.KeyChar == '\"' || e.KeyChar == '\\')
            {
                // Impede a entrada do caractere proibido
                e.Handled = true;
            }
        }
    }
}
