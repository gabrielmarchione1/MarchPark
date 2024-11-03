using MarchPark.ENT;
using MarchPark.ENT.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
namespace MarchPark.Forms
{
    /// <summary>
    /// Formulário de Login.
    /// </summary>
    public partial class FRM_LOGIN : Form
    {
        public string usuarioAtivo;
        private MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        private MarchPark.ENT.Login.MarchPark_TBL_LOGIN ObjEnt = new ENT.Login.MarchPark_TBL_LOGIN();

        /// <summary>
        /// Construtor da classe FRM_LOGIN
        /// Inicializa os componentes do formulário de login.
        /// </summary>
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para montar entidade.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano indicando se a entidade foi montada com sucesso.
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
        /// Método para consultar usuário.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool CONSULTAR_USUARIO()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (ObjNEG.SELECT_MARCH_PARK_TBL_LOGIN(TXT_USUARIO.Text, MBX_SENHA.Text))
                    {
                        usuarioAtivo = ObjNEG.SELECT_NOME_USUARIO_ATIVO(ObjEnt);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou/e Senha inválido(s)!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_USUARIO.Text = "";
                        MBX_SENHA.Text = "";
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
        /// Evento de entrada do mouse na área do componente "LBL_ADD_USUARIO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBL_ADD_USUARIO_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                LBL_ADD_USUARIO.ForeColor = Color.Blue;
                LBL_ADD_USUARIO.Font = new Font(LBL_ADD_USUARIO.Font, FontStyle.Underline);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de saída do mouse da área do componente "LBL_ADD_USUARIO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBL_ADD_USUARIO_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                LBL_ADD_USUARIO.ForeColor = Color.Black;
                LBL_ADD_USUARIO.Font = new Font(LBL_ADD_USUARIO.Font, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de click no botão "BTN_SAIR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_SAIR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                this.Close();
                Application.Exit();
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
        /// Evento de click na label "LBL_ADD_USUARIO".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LBL_ADD_USUARIO_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                MarchPark.Forms.FRM_PERMISSAO FRM_PERMISSAO = new MarchPark.Forms.FRM_PERMISSAO();
                FRM_PERMISSAO.ShowDialog();
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
        /// Evento de ação no botão "BTN_ENTRAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                if (CONSULTAR_USUARIO() == true)
                {
                    this.Hide();
                    MarchPark.Forms.FRM_PRINCIPAL FRM_PRINCIPAL = new MarchPark.Forms.FRM_PRINCIPAL(usuarioAtivo);
                    FRM_PRINCIPAL.FormClosed += (s, args) => this.Close();
                    FRM_PRINCIPAL.Show();
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
        /// Evento de ação KeyDown na "TXT_USUARIO".
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
        /// Evento de ação KeyDown na "MBX_SENHA".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBX_SENHA_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BTN_ENTRAR_Click(sender, e);
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
            if (e.KeyChar == '\'' || e.KeyChar == '\"' || e.KeyChar == '\\' || e.KeyChar == ' ')
            {
                // Impede a entrada do caractere proibido
                e.Handled = true;
            }
        }
    }
}
