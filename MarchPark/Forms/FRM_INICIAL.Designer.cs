namespace MarchPark.Forms
{
    partial class FRM_INICIAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_INICIAL));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MBX_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_MARCA_MODELO = new System.Windows.Forms.TextBox();
            this.CBX_PLACA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBX_NOME = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_REGISTRAR_ENTRADA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TXT_BUSCAR_PLACA = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_LIMPAR_DADOS = new System.Windows.Forms.ToolStripButton();
            this.LBL_TARIFA = new System.Windows.Forms.ToolStripLabel();
            this.DGV_DADOS = new System.Windows.Forms.DataGridView();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
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
            this.splitContainer1.SplitterDistance = 104;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MBX_CPF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXT_MARCA_MODELO);
            this.groupBox1.Controls.Add(this.CBX_PLACA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBX_NOME);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // MBX_CPF
            // 
            this.MBX_CPF.Enabled = false;
            this.MBX_CPF.Location = new System.Drawing.Point(190, 34);
            this.MBX_CPF.Mask = "000,000,000-00";
            this.MBX_CPF.Name = "MBX_CPF";
            this.MBX_CPF.Size = new System.Drawing.Size(120, 20);
            this.MBX_CPF.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "CPF Cliente:";
            // 
            // TXT_MARCA_MODELO
            // 
            this.TXT_MARCA_MODELO.Enabled = false;
            this.TXT_MARCA_MODELO.Location = new System.Drawing.Point(434, 34);
            this.TXT_MARCA_MODELO.Name = "TXT_MARCA_MODELO";
            this.TXT_MARCA_MODELO.Size = new System.Drawing.Size(195, 20);
            this.TXT_MARCA_MODELO.TabIndex = 33;
            // 
            // CBX_PLACA
            // 
            this.CBX_PLACA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_PLACA.Enabled = false;
            this.CBX_PLACA.FormattingEnabled = true;
            this.CBX_PLACA.Location = new System.Drawing.Point(334, 34);
            this.CBX_PLACA.Name = "CBX_PLACA";
            this.CBX_PLACA.Size = new System.Drawing.Size(79, 21);
            this.CBX_PLACA.TabIndex = 3;
            this.CBX_PLACA.SelectionChangeCommitted += new System.EventHandler(this.CBX_PLACA_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa Veículo:";
            // 
            // CBX_NOME
            // 
            this.CBX_NOME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_NOME.FormattingEnabled = true;
            this.CBX_NOME.Location = new System.Drawing.Point(17, 34);
            this.CBX_NOME.Name = "CBX_NOME";
            this.CBX_NOME.Size = new System.Drawing.Size(157, 21);
            this.CBX_NOME.TabIndex = 1;
            this.CBX_NOME.SelectionChangeCommitted += new System.EventHandler(this.CBX_NOME_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_REGISTRAR_ENTRADA,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TXT_BUSCAR_PLACA,
            this.toolStripSeparator2,
            this.BTN_LIMPAR_DADOS,
            this.LBL_TARIFA});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_REGISTRAR_ENTRADA
            // 
            this.BTN_REGISTRAR_ENTRADA.Image = global::MarchPark.Properties.Resources.validar;
            this.BTN_REGISTRAR_ENTRADA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_REGISTRAR_ENTRADA.Name = "BTN_REGISTRAR_ENTRADA";
            this.BTN_REGISTRAR_ENTRADA.Size = new System.Drawing.Size(116, 22);
            this.BTN_REGISTRAR_ENTRADA.Text = "Registrar Entrada";
            this.BTN_REGISTRAR_ENTRADA.Click += new System.EventHandler(this.BTN_REGISTRAR_ENTRADA_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel1.Text = "Buscar Placa:";
            // 
            // TXT_BUSCAR_PLACA
            // 
            this.TXT_BUSCAR_PLACA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TXT_BUSCAR_PLACA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXT_BUSCAR_PLACA.Name = "TXT_BUSCAR_PLACA";
            this.TXT_BUSCAR_PLACA.Size = new System.Drawing.Size(100, 25);
            this.TXT_BUSCAR_PLACA.TextChanged += new System.EventHandler(this.TXT_BUSCAR_PLACA_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BTN_LIMPAR_DADOS
            // 
            this.BTN_LIMPAR_DADOS.Image = global::MarchPark.Properties.Resources.limpar;
            this.BTN_LIMPAR_DADOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_LIMPAR_DADOS.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.BTN_LIMPAR_DADOS.Name = "BTN_LIMPAR_DADOS";
            this.BTN_LIMPAR_DADOS.Size = new System.Drawing.Size(64, 22);
            this.BTN_LIMPAR_DADOS.Text = "Limpar";
            this.BTN_LIMPAR_DADOS.Click += new System.EventHandler(this.BTN_LIMPAR_DADOS_Click);
            // 
            // LBL_TARIFA
            // 
            this.LBL_TARIFA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LBL_TARIFA.Font = new System.Drawing.Font("Segoe UI", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LBL_TARIFA.Name = "LBL_TARIFA";
            this.LBL_TARIFA.Size = new System.Drawing.Size(46, 22);
            this.LBL_TARIFA.Text = "Tarifa";
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
            this.DGV_DADOS.Size = new System.Drawing.Size(641, 395);
            this.DGV_DADOS.TabIndex = 3;
            this.DGV_DADOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DADOS_CellClick);
            this.DGV_DADOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_DADOS_CellFormatting);
            this.DGV_DADOS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_DADOS_DataBindingComplete);
            this.DGV_DADOS.DoubleClick += new System.EventHandler(this.DGV_DADOS_DoubleClick);
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.HeaderText = "";
            this.checkBoxColumn.Name = "checkBoxColumn";
            // 
            // FRM_INICIAL
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
            this.Name = "FRM_INICIAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_INICIAL_Load);
            this.Shown += new System.EventHandler(this.FRM_INICIAL_Shown);
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
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        public System.Windows.Forms.DataGridView DGV_DADOS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
        private System.Windows.Forms.ToolStripButton BTN_REGISTRAR_ENTRADA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TXT_BUSCAR_PLACA;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBX_PLACA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBX_NOME;
        private System.Windows.Forms.TextBox TXT_MARCA_MODELO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTN_LIMPAR_DADOS;
        private System.Windows.Forms.MaskedTextBox MBX_CPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripLabel LBL_TARIFA;
    }
}