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
        /// <summary>
        /// Construtor da classe FRM_CAD_VEICULO
        /// Inicializa os componentes do formulário de cadastro de veículo.
        /// </summary>
        public FRM_CAD_VEICULO()
        {
            InitializeComponent();
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
                MBX_PLACA.Mask = "AAA0A00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " MarchPark ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
