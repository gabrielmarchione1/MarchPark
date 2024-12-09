namespace MarchPark.Forms
{
    partial class FRM_CAD_VEICULO
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
            this.RBTN_ANTIGA = new System.Windows.Forms.RadioButton();
            this.RBTN_MERCOSUL = new System.Windows.Forms.RadioButton();
            this.CBX_TIPO_VEICULO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_MARCA = new System.Windows.Forms.TextBox();
            this.TXT_COR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_MODELO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MBX_PLACA = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBX_NOME = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_ADICIONAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_ALTERAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_DELETAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_LIMPAR_DADOS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TXT_PESQUISAR_PLACA = new System.Windows.Forms.ToolStripTextBox();
            this.DGV_DADOS = new System.Windows.Forms.DataGridView();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.MBX_CPF = new System.Windows.Forms.MaskedTextBox();
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
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MBX_CPF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RBTN_ANTIGA);
            this.groupBox1.Controls.Add(this.RBTN_MERCOSUL);
            this.groupBox1.Controls.Add(this.CBX_TIPO_VEICULO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXT_MARCA);
            this.groupBox1.Controls.Add(this.TXT_COR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_MODELO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MBX_PLACA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBX_NOME);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // RBTN_ANTIGA
            // 
            this.RBTN_ANTIGA.AutoSize = true;
            this.RBTN_ANTIGA.Location = new System.Drawing.Point(391, 32);
            this.RBTN_ANTIGA.Name = "RBTN_ANTIGA";
            this.RBTN_ANTIGA.Size = new System.Drawing.Size(55, 17);
            this.RBTN_ANTIGA.TabIndex = 3;
            this.RBTN_ANTIGA.Text = "Antiga";
            this.RBTN_ANTIGA.UseVisualStyleBackColor = true;
            this.RBTN_ANTIGA.CheckedChanged += new System.EventHandler(this.RBTN_ANTIGA_CheckedChanged);
            // 
            // RBTN_MERCOSUL
            // 
            this.RBTN_MERCOSUL.AutoSize = true;
            this.RBTN_MERCOSUL.Checked = true;
            this.RBTN_MERCOSUL.Location = new System.Drawing.Point(391, 9);
            this.RBTN_MERCOSUL.Name = "RBTN_MERCOSUL";
            this.RBTN_MERCOSUL.Size = new System.Drawing.Size(68, 17);
            this.RBTN_MERCOSUL.TabIndex = 2;
            this.RBTN_MERCOSUL.TabStop = true;
            this.RBTN_MERCOSUL.Text = "Mercosul";
            this.RBTN_MERCOSUL.UseVisualStyleBackColor = true;
            this.RBTN_MERCOSUL.CheckedChanged += new System.EventHandler(this.RBTN_MERCOSUL_CheckedChanged);
            // 
            // CBX_TIPO_VEICULO
            // 
            this.CBX_TIPO_VEICULO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_TIPO_VEICULO.FormattingEnabled = true;
            this.CBX_TIPO_VEICULO.Location = new System.Drawing.Point(406, 75);
            this.CBX_TIPO_VEICULO.Name = "CBX_TIPO_VEICULO";
            this.CBX_TIPO_VEICULO.Size = new System.Drawing.Size(83, 21);
            this.CBX_TIPO_VEICULO.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tipo:";
            // 
            // TXT_MARCA
            // 
            this.TXT_MARCA.Location = new System.Drawing.Point(13, 75);
            this.TXT_MARCA.Name = "TXT_MARCA";
            this.TXT_MARCA.Size = new System.Drawing.Size(128, 20);
            this.TXT_MARCA.TabIndex = 4;
            // 
            // TXT_COR
            // 
            this.TXT_COR.Location = new System.Drawing.Point(309, 75);
            this.TXT_COR.Name = "TXT_COR";
            this.TXT_COR.Size = new System.Drawing.Size(69, 20);
            this.TXT_COR.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cor:";
            // 
            // TXT_MODELO
            // 
            this.TXT_MODELO.Location = new System.Drawing.Point(160, 75);
            this.TXT_MODELO.Name = "TXT_MODELO";
            this.TXT_MODELO.Size = new System.Drawing.Size(120, 20);
            this.TXT_MODELO.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Marca:";
            // 
            // MBX_PLACA
            // 
            this.MBX_PLACA.Location = new System.Drawing.Point(309, 28);
            this.MBX_PLACA.Name = "MBX_PLACA";
            this.MBX_PLACA.Size = new System.Drawing.Size(69, 20);
            this.MBX_PLACA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Placa:";
            // 
            // CBX_NOME
            // 
            this.CBX_NOME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_NOME.FormattingEnabled = true;
            this.CBX_NOME.Location = new System.Drawing.Point(12, 28);
            this.CBX_NOME.Name = "CBX_NOME";
            this.CBX_NOME.Size = new System.Drawing.Size(129, 21);
            this.CBX_NOME.TabIndex = 0;
            this.CBX_NOME.SelectionChangeCommitted += new System.EventHandler(this.CBX_NOME_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome Cliente:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_ADICIONAR,
            this.toolStripSeparator1,
            this.BTN_ALTERAR,
            this.toolStripSeparator3,
            this.BTN_DELETAR,
            this.toolStripSeparator6,
            this.BTN_LIMPAR_DADOS,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.TXT_PESQUISAR_PLACA});
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
            this.BTN_ADICIONAR.Click += new System.EventHandler(this.BTN_ADICIONAR_Click);
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
            this.BTN_LIMPAR_DADOS.Click += new System.EventHandler(this.BTN_LIMPAR_DADOS_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(94, 22);
            this.toolStripLabel1.Text = "Pesquisar Placa: ";
            // 
            // TXT_PESQUISAR_PLACA
            // 
            this.TXT_PESQUISAR_PLACA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TXT_PESQUISAR_PLACA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXT_PESQUISAR_PLACA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TXT_PESQUISAR_PLACA.Name = "TXT_PESQUISAR_PLACA";
            this.TXT_PESQUISAR_PLACA.Size = new System.Drawing.Size(100, 25);
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
            this.DGV_DADOS.Size = new System.Drawing.Size(641, 369);
            this.DGV_DADOS.TabIndex = 5;
            this.DGV_DADOS.TabStop = false;
            this.DGV_DADOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DADOS_CellClick);
            this.DGV_DADOS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_DADOS_CellFormatting);
            this.DGV_DADOS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_DADOS_DataBindingComplete);
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.HeaderText = "";
            this.checkBoxColumn.Name = "checkBoxColumn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "CPF Cliente:";
            // 
            // MBX_CPF
            // 
            this.MBX_CPF.Enabled = false;
            this.MBX_CPF.Location = new System.Drawing.Point(160, 28);
            this.MBX_CPF.Mask = "000,000,000-00";
            this.MBX_CPF.Name = "MBX_CPF";
            this.MBX_CPF.Size = new System.Drawing.Size(120, 20);
            this.MBX_CPF.TabIndex = 35;
            // 
            // FRM_CAD_VEICULO
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
            this.Name = "FRM_CAD_VEICULO";
            this.Text = "FRM_CAD_VEICULO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_CAD_VEICULO_Load);
            this.Shown += new System.EventHandler(this.FRM_CAD_VEICULO_Shown);
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
        private System.Windows.Forms.ToolStripButton BTN_ADICIONAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTN_ALTERAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BTN_DELETAR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BTN_LIMPAR_DADOS;
        public System.Windows.Forms.DataGridView DGV_DADOS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxColumn;
        private System.Windows.Forms.ComboBox CBX_NOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MBX_PLACA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton RBTN_ANTIGA;
        private System.Windows.Forms.RadioButton RBTN_MERCOSUL;
        private System.Windows.Forms.ComboBox CBX_TIPO_VEICULO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_MARCA;
        private System.Windows.Forms.TextBox TXT_COR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_MODELO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TXT_PESQUISAR_PLACA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MBX_CPF;
    }
}