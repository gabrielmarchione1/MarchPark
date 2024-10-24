namespace MarchPark.Forms
{
    partial class FRM_RELATORIO
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_ADICIONAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_ALTERAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_CONSULTAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_DELETAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_LIMPAR_DADOS = new System.Windows.Forms.ToolStripButton();
            this.DGV_DADOS = new System.Windows.Forms.DataGridView();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGV_DADOS);
            this.splitContainer1.Size = new System.Drawing.Size(641, 500);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_ADICIONAR,
            this.toolStripSeparator1,
            this.BTN_ALTERAR,
            this.toolStripSeparator2,
            this.BTN_CONSULTAR,
            this.toolStripSeparator3,
            this.BTN_DELETAR,
            this.toolStripSeparator6,
            this.BTN_LIMPAR_DADOS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_ADICIONAR
            // 
            this.BTN_ADICIONAR.Image = global::MarchPark.Properties.Resources.add;
            this.BTN_ADICIONAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_ADICIONAR.Name = "BTN_ADICIONAR";
            this.BTN_ADICIONAR.Size = new System.Drawing.Size(78, 22);
            this.BTN_ADICIONAR.Text = "Adicionar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_ALTERAR
            // 
            this.BTN_ALTERAR.Image = global::MarchPark.Properties.Resources.alterar;
            this.BTN_ALTERAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_ALTERAR.Name = "BTN_ALTERAR";
            this.BTN_ALTERAR.Size = new System.Drawing.Size(62, 22);
            this.BTN_ALTERAR.Text = "Alterar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_CONSULTAR
            // 
            this.BTN_CONSULTAR.Image = global::MarchPark.Properties.Resources.consultar1;
            this.BTN_CONSULTAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_CONSULTAR.Name = "BTN_CONSULTAR";
            this.BTN_CONSULTAR.Size = new System.Drawing.Size(78, 22);
            this.BTN_CONSULTAR.Text = "Consultar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_DELETAR
            // 
            this.BTN_DELETAR.Image = global::MarchPark.Properties.Resources.deletar;
            this.BTN_DELETAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_DELETAR.Name = "BTN_DELETAR";
            this.BTN_DELETAR.Size = new System.Drawing.Size(64, 22);
            this.BTN_DELETAR.Text = "Deletar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_LIMPAR_DADOS
            // 
            this.BTN_LIMPAR_DADOS.Image = global::MarchPark.Properties.Resources.limpar;
            this.BTN_LIMPAR_DADOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_LIMPAR_DADOS.Name = "BTN_LIMPAR_DADOS";
            this.BTN_LIMPAR_DADOS.Size = new System.Drawing.Size(64, 22);
            this.BTN_LIMPAR_DADOS.Text = "Limpar";
            // 
            // DGV_DADOS
            // 
            this.DGV_DADOS.AllowUserToAddRows = false;
            this.DGV_DADOS.AllowUserToDeleteRows = false;
            this.DGV_DADOS.AllowUserToResizeRows = false;
            this.DGV_DADOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_DADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxColumn});
            this.DGV_DADOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DADOS.Location = new System.Drawing.Point(0, 0);
            this.DGV_DADOS.Name = "DGV_DADOS";
            this.DGV_DADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DADOS.ShowCellToolTips = false;
            this.DGV_DADOS.Size = new System.Drawing.Size(641, 411);
            this.DGV_DADOS.TabIndex = 5;
            this.DGV_DADOS.TabStop = false;
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.HeaderText = "";
            this.checkBoxColumn.Name = "checkBoxColumn";
            // 
            // FRM_RELATORIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 500);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 500);
            this.Name = "FRM_RELATORIO";
            this.Text = "FRM_RELATORIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTN_ADICIONAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTN_ALTERAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTN_CONSULTAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BTN_DELETAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BTN_LIMPAR_DADOS;
        public System.Windows.Forms.DataGridView DGV_DADOS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
    }
}