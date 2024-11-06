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
        /// <summary>
        /// Construtor da classe FRM_GERENCIAMENTO
        /// Inicializa os componentes do formulário de gerenciamento.
        /// </summary>
        public FRM_GERENCIAMENTO()
        {
            InitializeComponent();
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
                    TXT_CARRO.Enabled = true;
                    LBL_MOTO.Enabled = true;
                    LBL_RS2.Enabled = true;
                    TXT_MOTO.Enabled = true;
                    BTN_ALTERAR.Enabled = true;

                    BTN_EDITAR_TARIFA.Text = "Cancelar";
                }
                else
                {
                    LBL_CARRO.Enabled = false;
                    LBL_RS1.Enabled = false;
                    TXT_CARRO.Enabled = false;
                    LBL_MOTO.Enabled = false;
                    LBL_RS2.Enabled = false;
                    TXT_MOTO.Enabled = false;
                    BTN_ALTERAR.Enabled = false;

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
                            CKBOX_ADMIN.Enabled = true;
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
                    CKBOX_ADMIN.Enabled = false;
                    BTN_CADASTRAR.Enabled = false;
                    MBX_SENHA_PERMISSAO.Enabled = false;
                    PICBOX_SENHA_PERMISSAO.Enabled = false;
                    BTN_ALTERAR_SENHA_PERMISSAO.Enabled = false;
                    LBL_LINHA.Enabled = false;
                    BTN_GER_USUARIOS.Enabled = false;

                    BTN_EDITAR_USUARIO.Text = "Editar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
