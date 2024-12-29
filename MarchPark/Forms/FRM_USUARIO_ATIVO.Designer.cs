namespace MarchPark.Forms
{
    partial class FRM_USUARIO_ATIVO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_USUARIO_ATIVO));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_USUARIO_ATIVO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_EDITAR = new System.Windows.Forms.Button();
            this.TXT_NOME_ATUAL = new System.Windows.Forms.TextBox();
            this.LBL_ALTERAR_NOME = new System.Windows.Forms.Label();
            this.LBL_LINHA_INFERIOR = new System.Windows.Forms.Label();
            this.LBL_NOME_ATUAL = new System.Windows.Forms.Label();
            this.LBL_NOME_NOVO = new System.Windows.Forms.Label();
            this.TXT_NOME_NOVO = new System.Windows.Forms.TextBox();
            this.LBL_NOVA_SENHA = new System.Windows.Forms.Label();
            this.LBL_SENHA_ATUAL = new System.Windows.Forms.Label();
            this.LBL_ALTERAR_SENHA = new System.Windows.Forms.Label();
            this.MBX_SENHA_ATUAL = new System.Windows.Forms.MaskedTextBox();
            this.MBX_NOVA_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.BTN_VALIDAR_SENHA = new System.Windows.Forms.Button();
            this.MBX_CONFIRMAR_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.LBL_CONFIRMAR_SENHA = new System.Windows.Forms.Label();
            this.BTN_ALTERAR = new System.Windows.Forms.Button();
            this.PICBOX_VALIDAR_SENHA = new System.Windows.Forms.PictureBox();
            this.LBL_VALIDAR_SENHA_NOVA = new System.Windows.Forms.Label();
            this.PICBOX_NOVA_SENHA = new System.Windows.Forms.PictureBox();
            this.PICBOX_CONFIRMAR_SENHA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_VALIDAR_SENHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_NOVA_SENHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_CONFIRMAR_SENHA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarchPark.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(25, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_USUARIO_ATIVO
            // 
            this.LBL_USUARIO_ATIVO.AutoSize = true;
            this.LBL_USUARIO_ATIVO.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_USUARIO_ATIVO.Location = new System.Drawing.Point(94, 46);
            this.LBL_USUARIO_ATIVO.Name = "LBL_USUARIO_ATIVO";
            this.LBL_USUARIO_ATIVO.Size = new System.Drawing.Size(88, 32);
            this.LBL_USUARIO_ATIVO.TabIndex = 1;
            this.LBL_USUARIO_ATIVO.Text = "Label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________";
            // 
            // BTN_EDITAR
            // 
            this.BTN_EDITAR.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_EDITAR.Location = new System.Drawing.Point(533, 55);
            this.BTN_EDITAR.Name = "BTN_EDITAR";
            this.BTN_EDITAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_EDITAR.TabIndex = 0;
            this.BTN_EDITAR.Text = "Editar";
            this.BTN_EDITAR.UseVisualStyleBackColor = true;
            this.BTN_EDITAR.Click += new System.EventHandler(this.BTN_EDITAR_Click);
            // 
            // TXT_NOME_ATUAL
            // 
            this.TXT_NOME_ATUAL.Enabled = false;
            this.TXT_NOME_ATUAL.Location = new System.Drawing.Point(25, 175);
            this.TXT_NOME_ATUAL.Name = "TXT_NOME_ATUAL";
            this.TXT_NOME_ATUAL.Size = new System.Drawing.Size(114, 20);
            this.TXT_NOME_ATUAL.TabIndex = 1;
            // 
            // LBL_ALTERAR_NOME
            // 
            this.LBL_ALTERAR_NOME.AutoSize = true;
            this.LBL_ALTERAR_NOME.Enabled = false;
            this.LBL_ALTERAR_NOME.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ALTERAR_NOME.Location = new System.Drawing.Point(22, 116);
            this.LBL_ALTERAR_NOME.Name = "LBL_ALTERAR_NOME";
            this.LBL_ALTERAR_NOME.Size = new System.Drawing.Size(138, 25);
            this.LBL_ALTERAR_NOME.TabIndex = 6;
            this.LBL_ALTERAR_NOME.Text = "Alterar Nome:";
            // 
            // LBL_LINHA_INFERIOR
            // 
            this.LBL_LINHA_INFERIOR.AutoSize = true;
            this.LBL_LINHA_INFERIOR.Location = new System.Drawing.Point(24, 255);
            this.LBL_LINHA_INFERIOR.Name = "LBL_LINHA_INFERIOR";
            this.LBL_LINHA_INFERIOR.Size = new System.Drawing.Size(313, 13);
            this.LBL_LINHA_INFERIOR.TabIndex = 7;
            this.LBL_LINHA_INFERIOR.Text = "___________________________________________________";
            // 
            // LBL_NOME_ATUAL
            // 
            this.LBL_NOME_ATUAL.AutoSize = true;
            this.LBL_NOME_ATUAL.Location = new System.Drawing.Point(24, 159);
            this.LBL_NOME_ATUAL.Name = "LBL_NOME_ATUAL";
            this.LBL_NOME_ATUAL.Size = new System.Drawing.Size(65, 13);
            this.LBL_NOME_ATUAL.TabIndex = 8;
            this.LBL_NOME_ATUAL.Text = "Nome Atual:";
            // 
            // LBL_NOME_NOVO
            // 
            this.LBL_NOME_NOVO.AutoSize = true;
            this.LBL_NOME_NOVO.Location = new System.Drawing.Point(26, 208);
            this.LBL_NOME_NOVO.Name = "LBL_NOME_NOVO";
            this.LBL_NOME_NOVO.Size = new System.Drawing.Size(67, 13);
            this.LBL_NOME_NOVO.TabIndex = 10;
            this.LBL_NOME_NOVO.Text = "Nome Novo:";
            // 
            // TXT_NOME_NOVO
            // 
            this.TXT_NOME_NOVO.Enabled = false;
            this.TXT_NOME_NOVO.Location = new System.Drawing.Point(27, 224);
            this.TXT_NOME_NOVO.Name = "TXT_NOME_NOVO";
            this.TXT_NOME_NOVO.Size = new System.Drawing.Size(112, 20);
            this.TXT_NOME_NOVO.TabIndex = 2;
            this.TXT_NOME_NOVO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_NOME_NOVO_KeyPress);
            // 
            // LBL_NOVA_SENHA
            // 
            this.LBL_NOVA_SENHA.AutoSize = true;
            this.LBL_NOVA_SENHA.Location = new System.Drawing.Point(28, 378);
            this.LBL_NOVA_SENHA.Name = "LBL_NOVA_SENHA";
            this.LBL_NOVA_SENHA.Size = new System.Drawing.Size(70, 13);
            this.LBL_NOVA_SENHA.TabIndex = 15;
            this.LBL_NOVA_SENHA.Text = "Nova Senha:";
            // 
            // LBL_SENHA_ATUAL
            // 
            this.LBL_SENHA_ATUAL.AutoSize = true;
            this.LBL_SENHA_ATUAL.Location = new System.Drawing.Point(26, 329);
            this.LBL_SENHA_ATUAL.Name = "LBL_SENHA_ATUAL";
            this.LBL_SENHA_ATUAL.Size = new System.Drawing.Size(107, 13);
            this.LBL_SENHA_ATUAL.TabIndex = 13;
            this.LBL_SENHA_ATUAL.Text = "Digite a Senha Atual:";
            // 
            // LBL_ALTERAR_SENHA
            // 
            this.LBL_ALTERAR_SENHA.AutoSize = true;
            this.LBL_ALTERAR_SENHA.Enabled = false;
            this.LBL_ALTERAR_SENHA.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ALTERAR_SENHA.Location = new System.Drawing.Point(24, 286);
            this.LBL_ALTERAR_SENHA.Name = "LBL_ALTERAR_SENHA";
            this.LBL_ALTERAR_SENHA.Size = new System.Drawing.Size(138, 25);
            this.LBL_ALTERAR_SENHA.TabIndex = 12;
            this.LBL_ALTERAR_SENHA.Text = "Alterar Senha:";
            // 
            // MBX_SENHA_ATUAL
            // 
            this.MBX_SENHA_ATUAL.Enabled = false;
            this.MBX_SENHA_ATUAL.Location = new System.Drawing.Point(27, 345);
            this.MBX_SENHA_ATUAL.Name = "MBX_SENHA_ATUAL";
            this.MBX_SENHA_ATUAL.Size = new System.Drawing.Size(112, 20);
            this.MBX_SENHA_ATUAL.TabIndex = 3;
            this.MBX_SENHA_ATUAL.UseSystemPasswordChar = true;
            this.MBX_SENHA_ATUAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MBX_SENHA_ATUAL_KeyPress);
            // 
            // MBX_NOVA_SENHA
            // 
            this.MBX_NOVA_SENHA.Enabled = false;
            this.MBX_NOVA_SENHA.Location = new System.Drawing.Point(27, 394);
            this.MBX_NOVA_SENHA.Name = "MBX_NOVA_SENHA";
            this.MBX_NOVA_SENHA.Size = new System.Drawing.Size(112, 20);
            this.MBX_NOVA_SENHA.TabIndex = 5;
            this.MBX_NOVA_SENHA.UseSystemPasswordChar = true;
            this.MBX_NOVA_SENHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MBX_NOVA_SENHA_KeyPress);
            // 
            // BTN_VALIDAR_SENHA
            // 
            this.BTN_VALIDAR_SENHA.Enabled = false;
            this.BTN_VALIDAR_SENHA.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_VALIDAR_SENHA.Location = new System.Drawing.Point(170, 343);
            this.BTN_VALIDAR_SENHA.Name = "BTN_VALIDAR_SENHA";
            this.BTN_VALIDAR_SENHA.Size = new System.Drawing.Size(64, 23);
            this.BTN_VALIDAR_SENHA.TabIndex = 4;
            this.BTN_VALIDAR_SENHA.Text = "Validar";
            this.BTN_VALIDAR_SENHA.UseVisualStyleBackColor = true;
            this.BTN_VALIDAR_SENHA.Click += new System.EventHandler(this.BTN_VALIDAR_SENHA_Click);
            // 
            // MBX_CONFIRMAR_SENHA
            // 
            this.MBX_CONFIRMAR_SENHA.Enabled = false;
            this.MBX_CONFIRMAR_SENHA.Location = new System.Drawing.Point(25, 439);
            this.MBX_CONFIRMAR_SENHA.Name = "MBX_CONFIRMAR_SENHA";
            this.MBX_CONFIRMAR_SENHA.Size = new System.Drawing.Size(112, 20);
            this.MBX_CONFIRMAR_SENHA.TabIndex = 6;
            this.MBX_CONFIRMAR_SENHA.UseSystemPasswordChar = true;
            this.MBX_CONFIRMAR_SENHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MBX_CONFIRMAR_SENHA_KeyPress);
            this.MBX_CONFIRMAR_SENHA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MBX_CONFIRMAR_SENHA_KeyUp);
            // 
            // LBL_CONFIRMAR_SENHA
            // 
            this.LBL_CONFIRMAR_SENHA.AutoSize = true;
            this.LBL_CONFIRMAR_SENHA.Location = new System.Drawing.Point(26, 423);
            this.LBL_CONFIRMAR_SENHA.Name = "LBL_CONFIRMAR_SENHA";
            this.LBL_CONFIRMAR_SENHA.Size = new System.Drawing.Size(88, 13);
            this.LBL_CONFIRMAR_SENHA.TabIndex = 19;
            this.LBL_CONFIRMAR_SENHA.Text = "Confirmar Senha:";
            // 
            // BTN_ALTERAR
            // 
            this.BTN_ALTERAR.Enabled = false;
            this.BTN_ALTERAR.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_ALTERAR.Location = new System.Drawing.Point(516, 439);
            this.BTN_ALTERAR.Name = "BTN_ALTERAR";
            this.BTN_ALTERAR.Size = new System.Drawing.Size(92, 27);
            this.BTN_ALTERAR.TabIndex = 7;
            this.BTN_ALTERAR.Text = "Alterar";
            this.BTN_ALTERAR.UseVisualStyleBackColor = true;
            this.BTN_ALTERAR.Click += new System.EventHandler(this.BTN_ALTERAR_Click);
            // 
            // PICBOX_VALIDAR_SENHA
            // 
            this.PICBOX_VALIDAR_SENHA.Location = new System.Drawing.Point(145, 343);
            this.PICBOX_VALIDAR_SENHA.Name = "PICBOX_VALIDAR_SENHA";
            this.PICBOX_VALIDAR_SENHA.Size = new System.Drawing.Size(20, 20);
            this.PICBOX_VALIDAR_SENHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX_VALIDAR_SENHA.TabIndex = 22;
            this.PICBOX_VALIDAR_SENHA.TabStop = false;
            // 
            // LBL_VALIDAR_SENHA_NOVA
            // 
            this.LBL_VALIDAR_SENHA_NOVA.AutoSize = true;
            this.LBL_VALIDAR_SENHA_NOVA.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LBL_VALIDAR_SENHA_NOVA.Location = new System.Drawing.Point(26, 467);
            this.LBL_VALIDAR_SENHA_NOVA.Name = "LBL_VALIDAR_SENHA_NOVA";
            this.LBL_VALIDAR_SENHA_NOVA.Size = new System.Drawing.Size(0, 19);
            this.LBL_VALIDAR_SENHA_NOVA.TabIndex = 23;
            // 
            // PICBOX_NOVA_SENHA
            // 
            this.PICBOX_NOVA_SENHA.Enabled = false;
            this.PICBOX_NOVA_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            this.PICBOX_NOVA_SENHA.Location = new System.Drawing.Point(145, 394);
            this.PICBOX_NOVA_SENHA.Name = "PICBOX_NOVA_SENHA";
            this.PICBOX_NOVA_SENHA.Size = new System.Drawing.Size(18, 18);
            this.PICBOX_NOVA_SENHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX_NOVA_SENHA.TabIndex = 24;
            this.PICBOX_NOVA_SENHA.TabStop = false;
            this.PICBOX_NOVA_SENHA.Click += new System.EventHandler(this.PICBOX_NOVA_SENHA_Click);
            // 
            // PICBOX_CONFIRMAR_SENHA
            // 
            this.PICBOX_CONFIRMAR_SENHA.Enabled = false;
            this.PICBOX_CONFIRMAR_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            this.PICBOX_CONFIRMAR_SENHA.Location = new System.Drawing.Point(145, 439);
            this.PICBOX_CONFIRMAR_SENHA.Name = "PICBOX_CONFIRMAR_SENHA";
            this.PICBOX_CONFIRMAR_SENHA.Size = new System.Drawing.Size(18, 18);
            this.PICBOX_CONFIRMAR_SENHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX_CONFIRMAR_SENHA.TabIndex = 25;
            this.PICBOX_CONFIRMAR_SENHA.TabStop = false;
            this.PICBOX_CONFIRMAR_SENHA.Click += new System.EventHandler(this.PICBOX_CONFIRMAR_SENHA_Click);
            // 
            // FRM_USUARIO_ATIVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 500);
            this.ControlBox = false;
            this.Controls.Add(this.PICBOX_CONFIRMAR_SENHA);
            this.Controls.Add(this.PICBOX_NOVA_SENHA);
            this.Controls.Add(this.LBL_VALIDAR_SENHA_NOVA);
            this.Controls.Add(this.PICBOX_VALIDAR_SENHA);
            this.Controls.Add(this.BTN_ALTERAR);
            this.Controls.Add(this.MBX_CONFIRMAR_SENHA);
            this.Controls.Add(this.LBL_CONFIRMAR_SENHA);
            this.Controls.Add(this.BTN_VALIDAR_SENHA);
            this.Controls.Add(this.MBX_NOVA_SENHA);
            this.Controls.Add(this.MBX_SENHA_ATUAL);
            this.Controls.Add(this.LBL_NOVA_SENHA);
            this.Controls.Add(this.LBL_SENHA_ATUAL);
            this.Controls.Add(this.LBL_ALTERAR_SENHA);
            this.Controls.Add(this.LBL_NOME_NOVO);
            this.Controls.Add(this.TXT_NOME_NOVO);
            this.Controls.Add(this.LBL_NOME_ATUAL);
            this.Controls.Add(this.LBL_LINHA_INFERIOR);
            this.Controls.Add(this.LBL_ALTERAR_NOME);
            this.Controls.Add(this.TXT_NOME_ATUAL);
            this.Controls.Add(this.BTN_EDITAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_USUARIO_ATIVO);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 500);
            this.Name = "FRM_USUARIO_ATIVO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_VALIDAR_SENHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_NOVA_SENHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_CONFIRMAR_SENHA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_USUARIO_ATIVO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_EDITAR;
        private System.Windows.Forms.TextBox TXT_NOME_ATUAL;
        private System.Windows.Forms.Label LBL_ALTERAR_NOME;
        private System.Windows.Forms.Label LBL_LINHA_INFERIOR;
        private System.Windows.Forms.Label LBL_NOME_ATUAL;
        private System.Windows.Forms.Label LBL_NOME_NOVO;
        private System.Windows.Forms.TextBox TXT_NOME_NOVO;
        private System.Windows.Forms.Label LBL_NOVA_SENHA;
        private System.Windows.Forms.Label LBL_SENHA_ATUAL;
        private System.Windows.Forms.Label LBL_ALTERAR_SENHA;
        private System.Windows.Forms.MaskedTextBox MBX_SENHA_ATUAL;
        private System.Windows.Forms.MaskedTextBox MBX_NOVA_SENHA;
        private System.Windows.Forms.Button BTN_VALIDAR_SENHA;
        private System.Windows.Forms.MaskedTextBox MBX_CONFIRMAR_SENHA;
        private System.Windows.Forms.Label LBL_CONFIRMAR_SENHA;
        private System.Windows.Forms.Button BTN_ALTERAR;
        private System.Windows.Forms.PictureBox PICBOX_VALIDAR_SENHA;
        private System.Windows.Forms.Label LBL_VALIDAR_SENHA_NOVA;
        private System.Windows.Forms.PictureBox PICBOX_NOVA_SENHA;
        private System.Windows.Forms.PictureBox PICBOX_CONFIRMAR_SENHA;
    }
}