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
    /// Formulário de Permissão.
    /// </summary>
    public partial class FRM_PERMISSAO : Form
    {
        private readonly MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        private MarchPark.ENT.Login.MarchPark_TBL_PERMISSAO ObjEnt = new ENT.Login.MarchPark_TBL_PERMISSAO();

        /// <summary>
        /// Construtor da classe FRM_PERMISSAO
        /// Inicializa os componentes do formulário de permissao.
        /// </summary>
        public FRM_PERMISSAO()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para consultar senha de permissao.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool CONSULTAR_SENHA()
        {
            try
            {
                if (MONTAR_ENTIDADE())
                {
                    if (ObjNEG.SELECT_MARCH_PARK_TBL_PERMISSAO(MBX_SENHA.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MBX_SENHA.Text = "";
                        MBX_SENHA.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Favor, preencha corretamente!", " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para montar entidade.
        /// </summary>
        /// <returns>
        /// Retorna um valor booleano indicando de a entidade foi montada com sucesso.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public bool MONTAR_ENTIDADE()
        {
            try
            {
                ObjEnt = new ENT.Login.MarchPark_TBL_PERMISSAO();

                if (MBX_SENHA.Text.Length == 0)
                {
                    return false;
                }

                ObjEnt.SENHA_PERMISSAO = MBX_SENHA.Text;
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
                    BTN_CONFIRMAR_Click(sender, e);
                    e.SuppressKeyPress = true; // Impede que a tecla Enter execute sua ação padrão, como mover o foco ou emitir um beep
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Evento de clique do botão "BTN_CONFIRMAR".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (CONSULTAR_SENHA() == true)
                {
                    this.Hide();
                    MarchPark.Forms.FRM_CAD_USUARIO FRM_CAD_USUARIO = new FRM_CAD_USUARIO();
                    FRM_CAD_USUARIO.FormClosed += (s, args) => this.Close();
                    FRM_CAD_USUARIO.ShowDialog();
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
