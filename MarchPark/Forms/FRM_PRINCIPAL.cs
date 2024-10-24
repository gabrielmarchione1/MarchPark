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
    /// Formulário principal.
    /// </summary>
    public partial class FRM_PRINCIPAL : Form
    {
        private MarchPark.NEG.CRUD_NEG ObjNEG = new NEG.CRUD_NEG();
        /// <summary>
        /// Construtor da classe FRM_PRINCIPAL
        /// Inicializa os componentes do formulário de cadastro de usuário.
        /// </summary>
        public FRM_PRINCIPAL(string UsuarioAtivo)
        {
            InitializeComponent();
            LBL_USUARIO_ATIVO.Text = UsuarioAtivo;
        }

        /// <summary>
        /// Evento para fechar o form ativo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento de clique no botão de cadastro de veículos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CAD_VEICULO_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Text == "FRM_CAD_VEICULO")
                    {
                        return;
                    }
                }

                Cursor = Cursors.WaitCursor;
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_CAD_VEICULO child = new FRM_CAD_VEICULO();
                child.MdiParent = this;
                child.Dock = DockStyle.Fill;
                child.Show();

                foreach (ToolStripMenuItem botao in menuStrip1.Items)
                {
                    botao.BackColor = SystemColors.ControlLight;
                }

                BTN_CAD_VEICULO.BackColor = Color.Silver;
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
        /// Evento de clique no botão de cadastro de clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CAD_CLIENTE_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Text == "FRM_CAD_CLIENTE")
                    {
                        return;
                    }
                }

                Cursor = Cursors.WaitCursor;
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_CAD_CLIENTE child = new FRM_CAD_CLIENTE();
                child.MdiParent = this;
                child.Dock = DockStyle.Fill;
                child.Show();

                foreach (ToolStripMenuItem botao in menuStrip1.Items)
                {
                    botao.BackColor = SystemColors.ControlLight;
                }

                BTN_CAD_CLIENTE.BackColor = Color.Silver;
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
        /// Evento de Load do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_PRINCIPAL_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                FRM_INICIAL child = new FRM_INICIAL();
                child.MdiParent = this;
                child.Dock = DockStyle.Fill;
                child.Show();

                BTN_INICIAL.BackColor = Color.Silver;
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
        /// Evento de clique no botão da tela inicial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_INICIAL_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Text == "FRM_INICIAL")
                    {
                        return;
                    }
                }

                Cursor = Cursors.WaitCursor;
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_INICIAL child = new FRM_INICIAL();
                child.MdiParent = this;
                child.Dock = DockStyle.Fill;
                child.Show();

                foreach (ToolStripMenuItem botao in menuStrip1.Items)
                {
                    botao.BackColor = SystemColors.ControlLight;
                }

                BTN_INICIAL.BackColor = Color.Silver;
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
        /// Evento de clique no botão da tela de relatório.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_RELATORIO_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Text == "FRM_RELATORIO")
                    {
                        return;
                    }
                }

                Cursor = Cursors.WaitCursor;
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_RELATORIO child = new FRM_RELATORIO();
                child.MdiParent = this;
                child.Dock = DockStyle.Fill;
                child.Show();

                foreach (ToolStripMenuItem botao in menuStrip1.Items)
                {
                    botao.BackColor = SystemColors.ControlLight;
                }

                BTN_RELATORIO.BackColor = Color.Silver;
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
        /// Evento de clique no botão da tela de gerenciamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_GERENCIAMENTO_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Text == "FRM_GERENCIAMENTO")
                    {
                        return;
                    }
                }

                Cursor = Cursors.WaitCursor;
                CloseAllToolStripMenuItem_Click(null, null);

                FRM_GERENCIAMENTO child = new FRM_GERENCIAMENTO();
                child.MdiParent = this;
                child.Dock = DockStyle.Fill;
                child.Show();

                foreach (ToolStripMenuItem botao in menuStrip1.Items)
                {
                    botao.BackColor = SystemColors.ControlLight;
                }

                BTN_GERENCIAMENTO.BackColor = Color.Silver;
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

        private void BTN_SAIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fazer Logoff?", " MarchPark ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                MarchPark.Forms.FRM_LOGIN FRM_LOGIN = new MarchPark.Forms.FRM_LOGIN();
                FRM_LOGIN.FormClosed += (s, args) => this.Close();
                FRM_LOGIN.Show();
            }
        }

    }
}
