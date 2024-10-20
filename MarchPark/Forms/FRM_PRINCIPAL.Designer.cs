namespace MarchPark.Forms
{
    partial class FRM_PRINCIPAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BTN_INICIAL = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_CAD_CLIENTE = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_CAD_VEICULO = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 525);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(838, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_INICIAL,
            this.BTN_CAD_CLIENTE,
            this.BTN_CAD_VEICULO});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(197, 500);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BTN_INICIAL
            // 
            this.BTN_INICIAL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_INICIAL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BTN_INICIAL.Margin = new System.Windows.Forms.Padding(-4, 0, 1, 2);
            this.BTN_INICIAL.Name = "BTN_INICIAL";
            this.BTN_INICIAL.Size = new System.Drawing.Size(193, 25);
            this.BTN_INICIAL.Text = "Veículos Estacionados";
            this.BTN_INICIAL.Click += new System.EventHandler(this.BTN_INICIAL_Click);
            // 
            // BTN_CAD_CLIENTE
            // 
            this.BTN_CAD_CLIENTE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_CAD_CLIENTE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CAD_CLIENTE.Margin = new System.Windows.Forms.Padding(-4, 0, 1, 2);
            this.BTN_CAD_CLIENTE.Name = "BTN_CAD_CLIENTE";
            this.BTN_CAD_CLIENTE.Size = new System.Drawing.Size(193, 25);
            this.BTN_CAD_CLIENTE.Text = "Cadastro de Clientes";
            this.BTN_CAD_CLIENTE.Click += new System.EventHandler(this.BTN_CAD_CLIENTE_Click_1);
            // 
            // BTN_CAD_VEICULO
            // 
            this.BTN_CAD_VEICULO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN_CAD_VEICULO.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BTN_CAD_VEICULO.Margin = new System.Windows.Forms.Padding(-4, 0, 1, 2);
            this.BTN_CAD_VEICULO.Name = "BTN_CAD_VEICULO";
            this.BTN_CAD_VEICULO.Size = new System.Drawing.Size(193, 25);
            this.BTN_CAD_VEICULO.Text = "Cadastro de Veículos";
            this.BTN_CAD_VEICULO.Click += new System.EventHandler(this.BTN_CAD_VEICULO_Click_1);
            // 
            // FRM_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 550);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(854, 589);
            this.MinimumSize = new System.Drawing.Size(854, 589);
            this.Name = "FRM_PRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_PRINCIPAL";
            this.Load += new System.EventHandler(this.FRM_PRINCIPAL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BTN_CAD_CLIENTE;
        private System.Windows.Forms.ToolStripMenuItem BTN_CAD_VEICULO;
        private System.Windows.Forms.ToolStripMenuItem BTN_INICIAL;
    }
}