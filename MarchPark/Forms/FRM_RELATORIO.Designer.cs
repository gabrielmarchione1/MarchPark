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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_RELATORIO));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_CPF = new System.Windows.Forms.Label();
            this.TXT_CPF = new System.Windows.Forms.TextBox();
            this.LBL_PLACA = new System.Windows.Forms.Label();
            this.TXT_PLACA = new System.Windows.Forms.TextBox();
            this.DTP2_ENTRADA_RANGE = new System.Windows.Forms.DateTimePicker();
            this.LBL_ATE_RANGE = new System.Windows.Forms.Label();
            this.DTP1_ENTRADA_RANGE = new System.Windows.Forms.DateTimePicker();
            this.LBL_ENTRADA_RANGE = new System.Windows.Forms.Label();
            this.LBL_DATA_ENTRADA = new System.Windows.Forms.Label();
            this.DTP_ENTRADA = new System.Windows.Forms.DateTimePicker();
            this.CBX_CONSULTAR_POR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_CONSULTAR = new System.Windows.Forms.ToolStripButton();
            this.SEP_CONSULTAR = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_LIMPAR_DADOS = new System.Windows.Forms.ToolStripButton();
            this.LBL_REGISTROS = new System.Windows.Forms.ToolStripLabel();
            this.DGV_DADOS = new System.Windows.Forms.DataGridView();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_GERAR_RELATORIO = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.LBL_CPF);
            this.groupBox1.Controls.Add(this.TXT_CPF);
            this.groupBox1.Controls.Add(this.LBL_PLACA);
            this.groupBox1.Controls.Add(this.TXT_PLACA);
            this.groupBox1.Controls.Add(this.DTP2_ENTRADA_RANGE);
            this.groupBox1.Controls.Add(this.LBL_ATE_RANGE);
            this.groupBox1.Controls.Add(this.DTP1_ENTRADA_RANGE);
            this.groupBox1.Controls.Add(this.LBL_ENTRADA_RANGE);
            this.groupBox1.Controls.Add(this.LBL_DATA_ENTRADA);
            this.groupBox1.Controls.Add(this.DTP_ENTRADA);
            this.groupBox1.Controls.Add(this.CBX_CONSULTAR_POR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // LBL_CPF
            // 
            this.LBL_CPF.AutoSize = true;
            this.LBL_CPF.Location = new System.Drawing.Point(168, 14);
            this.LBL_CPF.Name = "LBL_CPF";
            this.LBL_CPF.Size = new System.Drawing.Size(30, 13);
            this.LBL_CPF.TabIndex = 11;
            this.LBL_CPF.Text = "CPF:";
            this.LBL_CPF.Visible = false;
            // 
            // TXT_CPF
            // 
            this.TXT_CPF.Location = new System.Drawing.Point(171, 30);
            this.TXT_CPF.Name = "TXT_CPF";
            this.TXT_CPF.Size = new System.Drawing.Size(100, 20);
            this.TXT_CPF.TabIndex = 10;
            this.TXT_CPF.Visible = false;
            this.TXT_CPF.TextChanged += new System.EventHandler(this.TXT_CPF_TextChanged);
            // 
            // LBL_PLACA
            // 
            this.LBL_PLACA.AutoSize = true;
            this.LBL_PLACA.Location = new System.Drawing.Point(168, 14);
            this.LBL_PLACA.Name = "LBL_PLACA";
            this.LBL_PLACA.Size = new System.Drawing.Size(37, 13);
            this.LBL_PLACA.TabIndex = 9;
            this.LBL_PLACA.Text = "Placa:";
            this.LBL_PLACA.Visible = false;
            // 
            // TXT_PLACA
            // 
            this.TXT_PLACA.Location = new System.Drawing.Point(171, 30);
            this.TXT_PLACA.Name = "TXT_PLACA";
            this.TXT_PLACA.Size = new System.Drawing.Size(100, 20);
            this.TXT_PLACA.TabIndex = 8;
            this.TXT_PLACA.Visible = false;
            this.TXT_PLACA.TextChanged += new System.EventHandler(this.TXT_PLACA_TextChanged);
            // 
            // DTP2_ENTRADA_RANGE
            // 
            this.DTP2_ENTRADA_RANGE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP2_ENTRADA_RANGE.Location = new System.Drawing.Point(290, 30);
            this.DTP2_ENTRADA_RANGE.Name = "DTP2_ENTRADA_RANGE";
            this.DTP2_ENTRADA_RANGE.Size = new System.Drawing.Size(84, 20);
            this.DTP2_ENTRADA_RANGE.TabIndex = 7;
            this.DTP2_ENTRADA_RANGE.Visible = false;
            // 
            // LBL_ATE_RANGE
            // 
            this.LBL_ATE_RANGE.AutoSize = true;
            this.LBL_ATE_RANGE.Location = new System.Drawing.Point(262, 33);
            this.LBL_ATE_RANGE.Name = "LBL_ATE_RANGE";
            this.LBL_ATE_RANGE.Size = new System.Drawing.Size(23, 13);
            this.LBL_ATE_RANGE.TabIndex = 6;
            this.LBL_ATE_RANGE.Text = "Até";
            this.LBL_ATE_RANGE.Visible = false;
            // 
            // DTP1_ENTRADA_RANGE
            // 
            this.DTP1_ENTRADA_RANGE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP1_ENTRADA_RANGE.Location = new System.Drawing.Point(171, 31);
            this.DTP1_ENTRADA_RANGE.Name = "DTP1_ENTRADA_RANGE";
            this.DTP1_ENTRADA_RANGE.Size = new System.Drawing.Size(84, 20);
            this.DTP1_ENTRADA_RANGE.TabIndex = 5;
            this.DTP1_ENTRADA_RANGE.Visible = false;
            // 
            // LBL_ENTRADA_RANGE
            // 
            this.LBL_ENTRADA_RANGE.AutoSize = true;
            this.LBL_ENTRADA_RANGE.Location = new System.Drawing.Point(232, 14);
            this.LBL_ENTRADA_RANGE.Name = "LBL_ENTRADA_RANGE";
            this.LBL_ENTRADA_RANGE.Size = new System.Drawing.Size(88, 13);
            this.LBL_ENTRADA_RANGE.TabIndex = 4;
            this.LBL_ENTRADA_RANGE.Text = "Data de Entrada:";
            this.LBL_ENTRADA_RANGE.Visible = false;
            // 
            // LBL_DATA_ENTRADA
            // 
            this.LBL_DATA_ENTRADA.AutoSize = true;
            this.LBL_DATA_ENTRADA.Location = new System.Drawing.Point(168, 14);
            this.LBL_DATA_ENTRADA.Name = "LBL_DATA_ENTRADA";
            this.LBL_DATA_ENTRADA.Size = new System.Drawing.Size(88, 13);
            this.LBL_DATA_ENTRADA.TabIndex = 3;
            this.LBL_DATA_ENTRADA.Text = "Data de Entrada:";
            this.LBL_DATA_ENTRADA.Visible = false;
            // 
            // DTP_ENTRADA
            // 
            this.DTP_ENTRADA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_ENTRADA.Location = new System.Drawing.Point(171, 30);
            this.DTP_ENTRADA.Name = "DTP_ENTRADA";
            this.DTP_ENTRADA.Size = new System.Drawing.Size(84, 20);
            this.DTP_ENTRADA.TabIndex = 2;
            this.DTP_ENTRADA.Visible = false;
            this.DTP_ENTRADA.ValueChanged += new System.EventHandler(this.DTP_ENTRADA_ValueChanged);
            // 
            // CBX_CONSULTAR_POR
            // 
            this.CBX_CONSULTAR_POR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_CONSULTAR_POR.FormattingEnabled = true;
            this.CBX_CONSULTAR_POR.Location = new System.Drawing.Point(12, 30);
            this.CBX_CONSULTAR_POR.Name = "CBX_CONSULTAR_POR";
            this.CBX_CONSULTAR_POR.Size = new System.Drawing.Size(125, 21);
            this.CBX_CONSULTAR_POR.TabIndex = 1;
            this.CBX_CONSULTAR_POR.SelectionChangeCommitted += new System.EventHandler(this.CBX_CONSULTAR_POR_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar por:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_CONSULTAR,
            this.SEP_CONSULTAR,
            this.BTN_LIMPAR_DADOS,
            this.LBL_REGISTROS,
            this.toolStripSeparator1,
            this.BTN_GERAR_RELATORIO});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_CONSULTAR
            // 
            this.BTN_CONSULTAR.Image = global::MarchPark.Properties.Resources.consultar1;
            this.BTN_CONSULTAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_CONSULTAR.Name = "BTN_CONSULTAR";
            this.BTN_CONSULTAR.Size = new System.Drawing.Size(78, 22);
            this.BTN_CONSULTAR.Text = "Consultar";
            this.BTN_CONSULTAR.Visible = false;
            this.BTN_CONSULTAR.Click += new System.EventHandler(this.BTN_CONSULTAR_Click);
            // 
            // SEP_CONSULTAR
            // 
            this.SEP_CONSULTAR.Name = "SEP_CONSULTAR";
            this.SEP_CONSULTAR.Size = new System.Drawing.Size(6, 25);
            this.SEP_CONSULTAR.Visible = false;
            // 
            // BTN_LIMPAR_DADOS
            // 
            this.BTN_LIMPAR_DADOS.Image = global::MarchPark.Properties.Resources.limpar;
            this.BTN_LIMPAR_DADOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_LIMPAR_DADOS.Name = "BTN_LIMPAR_DADOS";
            this.BTN_LIMPAR_DADOS.Size = new System.Drawing.Size(113, 22);
            this.BTN_LIMPAR_DADOS.Text = "Limpar/Desfazer";
            this.BTN_LIMPAR_DADOS.Click += new System.EventHandler(this.BTN_LIMPAR_DADOS_Click);
            // 
            // LBL_REGISTROS
            // 
            this.LBL_REGISTROS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LBL_REGISTROS.Font = new System.Drawing.Font("Segoe UI", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LBL_REGISTROS.Name = "LBL_REGISTROS";
            this.LBL_REGISTROS.Size = new System.Drawing.Size(64, 22);
            this.LBL_REGISTROS.Text = "Registros";
            // 
            // DGV_DADOS
            // 
            this.DGV_DADOS.AllowUserToAddRows = false;
            this.DGV_DADOS.AllowUserToDeleteRows = false;
            this.DGV_DADOS.AllowUserToResizeRows = false;
            this.DGV_DADOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_DADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DADOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_DADOS.Location = new System.Drawing.Point(0, 0);
            this.DGV_DADOS.Name = "DGV_DADOS";
            this.DGV_DADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DADOS.ShowCellToolTips = false;
            this.DGV_DADOS.Size = new System.Drawing.Size(641, 411);
            this.DGV_DADOS.TabIndex = 5;
            this.DGV_DADOS.TabStop = false;
            this.DGV_DADOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_DADOS_CellFormatting);
            this.DGV_DADOS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_DADOS_DataBindingComplete);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_GERAR_RELATORIO
            // 
            this.BTN_GERAR_RELATORIO.Image = global::MarchPark.Properties.Resources.excel;
            this.BTN_GERAR_RELATORIO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_GERAR_RELATORIO.Name = "BTN_GERAR_RELATORIO";
            this.BTN_GERAR_RELATORIO.Size = new System.Drawing.Size(105, 22);
            this.BTN_GERAR_RELATORIO.Text = "Gerar Relatório";
            this.BTN_GERAR_RELATORIO.Click += new System.EventHandler(this.BTN_GERAR_RELATORIO_Click);
            // 
            // FRM_RELATORIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 500);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 500);
            this.Name = "FRM_RELATORIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_RELATORIO_Load);
            this.Shown += new System.EventHandler(this.FRM_RELATORIO_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTN_LIMPAR_DADOS;
        public System.Windows.Forms.DataGridView DGV_DADOS;
        private System.Windows.Forms.ComboBox CBX_CONSULTAR_POR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_ENTRADA;
        private System.Windows.Forms.Label LBL_DATA_ENTRADA;
        private System.Windows.Forms.DateTimePicker DTP2_ENTRADA_RANGE;
        private System.Windows.Forms.Label LBL_ATE_RANGE;
        private System.Windows.Forms.DateTimePicker DTP1_ENTRADA_RANGE;
        private System.Windows.Forms.Label LBL_ENTRADA_RANGE;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label LBL_PLACA;
        private System.Windows.Forms.TextBox TXT_PLACA;
        private System.Windows.Forms.Label LBL_CPF;
        private System.Windows.Forms.TextBox TXT_CPF;
        private System.Windows.Forms.ToolStripLabel LBL_REGISTROS;
        private System.Windows.Forms.ToolStripButton BTN_CONSULTAR;
        private System.Windows.Forms.ToolStripSeparator SEP_CONSULTAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTN_GERAR_RELATORIO;
    }
}