namespace MarchPark.Forms
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.LBL_USUARIO = new System.Windows.Forms.Label();
            this.LBL_SENHA = new System.Windows.Forms.Label();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.MBX_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.BTN_SAIR = new System.Windows.Forms.Button();
            this.BTN_ENTRAR = new System.Windows.Forms.Button();
            this.LBL_ADD_USUARIO = new System.Windows.Forms.Label();
            this.LBL_SUBTITULO = new System.Windows.Forms.Label();
            this.PICBOX = new System.Windows.Forms.PictureBox();
            this.LBL_TITULO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_USUARIO
            // 
            this.LBL_USUARIO.AutoSize = true;
            this.LBL_USUARIO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_USUARIO.Location = new System.Drawing.Point(55, 204);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(75, 19);
            this.LBL_USUARIO.TabIndex = 1;
            this.LBL_USUARIO.Text = "Usuário:";
            // 
            // LBL_SENHA
            // 
            this.LBL_SENHA.AutoSize = true;
            this.LBL_SENHA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_SENHA.Location = new System.Drawing.Point(55, 255);
            this.LBL_SENHA.Name = "LBL_SENHA";
            this.LBL_SENHA.Size = new System.Drawing.Size(64, 19);
            this.LBL_SENHA.TabIndex = 2;
            this.LBL_SENHA.Text = "Senha:";
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Location = new System.Drawing.Point(59, 228);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(174, 20);
            this.TXT_USUARIO.TabIndex = 0;
            this.TXT_USUARIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_USUARIO_KeyDown);
            this.TXT_USUARIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_USUARIO_KeyPress);
            // 
            // MBX_SENHA
            // 
            this.MBX_SENHA.Location = new System.Drawing.Point(59, 278);
            this.MBX_SENHA.Name = "MBX_SENHA";
            this.MBX_SENHA.Size = new System.Drawing.Size(174, 20);
            this.MBX_SENHA.TabIndex = 1;
            this.MBX_SENHA.UseSystemPasswordChar = true;
            this.MBX_SENHA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MBX_SENHA_KeyDown);
            this.MBX_SENHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MBX_SENHA_KeyPress);
            // 
            // BTN_SAIR
            // 
            this.BTN_SAIR.Font = new System.Drawing.Font("Arial", 9F);
            this.BTN_SAIR.Location = new System.Drawing.Point(271, 278);
            this.BTN_SAIR.Name = "BTN_SAIR";
            this.BTN_SAIR.Size = new System.Drawing.Size(75, 23);
            this.BTN_SAIR.TabIndex = 4;
            this.BTN_SAIR.Text = "Sair";
            this.BTN_SAIR.UseVisualStyleBackColor = true;
            this.BTN_SAIR.Click += new System.EventHandler(this.BTN_SAIR_Click);
            // 
            // BTN_ENTRAR
            // 
            this.BTN_ENTRAR.Font = new System.Drawing.Font("Arial", 9F);
            this.BTN_ENTRAR.Location = new System.Drawing.Point(271, 228);
            this.BTN_ENTRAR.Name = "BTN_ENTRAR";
            this.BTN_ENTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ENTRAR.TabIndex = 3;
            this.BTN_ENTRAR.Text = "Entrar";
            this.BTN_ENTRAR.UseVisualStyleBackColor = true;
            this.BTN_ENTRAR.Click += new System.EventHandler(this.BTN_ENTRAR_Click);
            // 
            // LBL_ADD_USUARIO
            // 
            this.LBL_ADD_USUARIO.AutoSize = true;
            this.LBL_ADD_USUARIO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ADD_USUARIO.Location = new System.Drawing.Point(56, 312);
            this.LBL_ADD_USUARIO.Name = "LBL_ADD_USUARIO";
            this.LBL_ADD_USUARIO.Size = new System.Drawing.Size(120, 16);
            this.LBL_ADD_USUARIO.TabIndex = 2;
            this.LBL_ADD_USUARIO.Text = "Adicionar Usuário";
            this.LBL_ADD_USUARIO.Click += new System.EventHandler(this.LBL_ADD_USUARIO_Click);
            this.LBL_ADD_USUARIO.MouseEnter += new System.EventHandler(this.LBL_ADD_USUARIO_MouseEnter);
            this.LBL_ADD_USUARIO.MouseLeave += new System.EventHandler(this.LBL_ADD_USUARIO_MouseLeave);
            // 
            // LBL_SUBTITULO
            // 
            this.LBL_SUBTITULO.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SUBTITULO.Location = new System.Drawing.Point(56, 171);
            this.LBL_SUBTITULO.Name = "LBL_SUBTITULO";
            this.LBL_SUBTITULO.Size = new System.Drawing.Size(298, 23);
            this.LBL_SUBTITULO.TabIndex = 8;
            this.LBL_SUBTITULO.Text = "Sistema de Gerenciamento de Estacionamento";
            // 
            // PICBOX
            // 
            this.PICBOX.BackColor = System.Drawing.Color.Transparent;
            this.PICBOX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PICBOX.Image = global::MarchPark.Properties.Resources.foto_login1;
            this.PICBOX.Location = new System.Drawing.Point(12, 45);
            this.PICBOX.Name = "PICBOX";
            this.PICBOX.Size = new System.Drawing.Size(381, 123);
            this.PICBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICBOX.TabIndex = 9;
            this.PICBOX.TabStop = false;
            // 
            // LBL_TITULO
            // 
            this.LBL_TITULO.AutoSize = true;
            this.LBL_TITULO.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITULO.Location = new System.Drawing.Point(80, 9);
            this.LBL_TITULO.Name = "LBL_TITULO";
            this.LBL_TITULO.Size = new System.Drawing.Size(264, 61);
            this.LBL_TITULO.TabIndex = 10;
            this.LBL_TITULO.Text = "MarchPark";
            this.LBL_TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 374);
            this.Controls.Add(this.LBL_TITULO);
            this.Controls.Add(this.PICBOX);
            this.Controls.Add(this.LBL_SUBTITULO);
            this.Controls.Add(this.LBL_ADD_USUARIO);
            this.Controls.Add(this.BTN_ENTRAR);
            this.Controls.Add(this.BTN_SAIR);
            this.Controls.Add(this.MBX_SENHA);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.LBL_SENHA);
            this.Controls.Add(this.LBL_USUARIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_LOGIN";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadCli";
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_USUARIO;
        private System.Windows.Forms.Label LBL_SENHA;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.MaskedTextBox MBX_SENHA;
        private System.Windows.Forms.Button BTN_SAIR;
        private System.Windows.Forms.Button BTN_ENTRAR;
        private System.Windows.Forms.Label LBL_ADD_USUARIO;
        private System.Windows.Forms.Label LBL_SUBTITULO;
        private System.Windows.Forms.PictureBox PICBOX;
        private System.Windows.Forms.Label LBL_TITULO;
    }
}