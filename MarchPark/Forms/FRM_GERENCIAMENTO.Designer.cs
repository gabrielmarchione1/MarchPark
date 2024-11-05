namespace MarchPark.Forms
{
    partial class FRM_GERENCIAMENTO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_ALTERAR = new System.Windows.Forms.Button();
            this.LBL_RS2 = new System.Windows.Forms.Label();
            this.LBL_RS1 = new System.Windows.Forms.Label();
            this.TXT_MOTO = new System.Windows.Forms.TextBox();
            this.LBL_MOTO = new System.Windows.Forms.Label();
            this.TXT_CARRO = new System.Windows.Forms.TextBox();
            this.LBL_CARRO = new System.Windows.Forms.Label();
            this.BTN_EDITAR_TARIFA = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_EDITAR_USUARIO = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PICBOX_CONFIRMAR_SENHA = new System.Windows.Forms.PictureBox();
            this.PICBOX_SENHA = new System.Windows.Forms.PictureBox();
            this.CKBOX_ADMIN = new System.Windows.Forms.CheckBox();
            this.MBX_CONFIRMAR_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.LBL_CONFIRMAR_SENHA = new System.Windows.Forms.Label();
            this.BTN_CADASTRAR = new System.Windows.Forms.Button();
            this.MBX_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.LBL_SENHA = new System.Windows.Forms.Label();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.LBL_USUARIO = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PICBOX_SENHA_PERMISSAO = new System.Windows.Forms.PictureBox();
            this.BTN_GER_USUARIOS = new System.Windows.Forms.Button();
            this.BTN_ALTERAR_SENHA_PERMISSAO = new System.Windows.Forms.Button();
            this.LBL_LINHA = new System.Windows.Forms.Label();
            this.MBX_SENHA_PERMISSAO = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_CONFIRMAR_SENHA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_SENHA)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_SENHA_PERMISSAO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alterar Tarifa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.BTN_ALTERAR);
            this.groupBox1.Controls.Add(this.LBL_RS2);
            this.groupBox1.Controls.Add(this.LBL_RS1);
            this.groupBox1.Controls.Add(this.TXT_MOTO);
            this.groupBox1.Controls.Add(this.LBL_MOTO);
            this.groupBox1.Controls.Add(this.TXT_CARRO);
            this.groupBox1.Controls.Add(this.LBL_CARRO);
            this.groupBox1.Location = new System.Drawing.Point(49, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // BTN_ALTERAR
            // 
            this.BTN_ALTERAR.Enabled = false;
            this.BTN_ALTERAR.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_ALTERAR.Location = new System.Drawing.Point(157, 86);
            this.BTN_ALTERAR.Name = "BTN_ALTERAR";
            this.BTN_ALTERAR.Size = new System.Drawing.Size(71, 25);
            this.BTN_ALTERAR.TabIndex = 3;
            this.BTN_ALTERAR.Text = "Alterar";
            this.BTN_ALTERAR.UseVisualStyleBackColor = true;
            // 
            // LBL_RS2
            // 
            this.LBL_RS2.AutoSize = true;
            this.LBL_RS2.Enabled = false;
            this.LBL_RS2.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LBL_RS2.Location = new System.Drawing.Point(22, 91);
            this.LBL_RS2.Name = "LBL_RS2";
            this.LBL_RS2.Size = new System.Drawing.Size(23, 13);
            this.LBL_RS2.TabIndex = 6;
            this.LBL_RS2.Text = "R$:";
            // 
            // LBL_RS1
            // 
            this.LBL_RS1.AutoSize = true;
            this.LBL_RS1.Enabled = false;
            this.LBL_RS1.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LBL_RS1.Location = new System.Drawing.Point(22, 38);
            this.LBL_RS1.Name = "LBL_RS1";
            this.LBL_RS1.Size = new System.Drawing.Size(23, 13);
            this.LBL_RS1.TabIndex = 5;
            this.LBL_RS1.Text = "R$:";
            // 
            // TXT_MOTO
            // 
            this.TXT_MOTO.Enabled = false;
            this.TXT_MOTO.Location = new System.Drawing.Point(45, 88);
            this.TXT_MOTO.MaximumSize = new System.Drawing.Size(60, 20);
            this.TXT_MOTO.MinimumSize = new System.Drawing.Size(60, 20);
            this.TXT_MOTO.Name = "TXT_MOTO";
            this.TXT_MOTO.Size = new System.Drawing.Size(60, 20);
            this.TXT_MOTO.TabIndex = 2;
            // 
            // LBL_MOTO
            // 
            this.LBL_MOTO.AutoSize = true;
            this.LBL_MOTO.Enabled = false;
            this.LBL_MOTO.Location = new System.Drawing.Point(28, 72);
            this.LBL_MOTO.Name = "LBL_MOTO";
            this.LBL_MOTO.Size = new System.Drawing.Size(34, 13);
            this.LBL_MOTO.TabIndex = 2;
            this.LBL_MOTO.Text = "Moto:";
            // 
            // TXT_CARRO
            // 
            this.TXT_CARRO.Enabled = false;
            this.TXT_CARRO.Location = new System.Drawing.Point(45, 35);
            this.TXT_CARRO.MaximumSize = new System.Drawing.Size(60, 20);
            this.TXT_CARRO.MinimumSize = new System.Drawing.Size(60, 20);
            this.TXT_CARRO.Name = "TXT_CARRO";
            this.TXT_CARRO.Size = new System.Drawing.Size(60, 20);
            this.TXT_CARRO.TabIndex = 1;
            // 
            // LBL_CARRO
            // 
            this.LBL_CARRO.AutoSize = true;
            this.LBL_CARRO.Enabled = false;
            this.LBL_CARRO.Location = new System.Drawing.Point(28, 19);
            this.LBL_CARRO.Name = "LBL_CARRO";
            this.LBL_CARRO.Size = new System.Drawing.Size(35, 13);
            this.LBL_CARRO.TabIndex = 0;
            this.LBL_CARRO.Text = "Carro:";
            // 
            // BTN_EDITAR_TARIFA
            // 
            this.BTN_EDITAR_TARIFA.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_EDITAR_TARIFA.Location = new System.Drawing.Point(529, 32);
            this.BTN_EDITAR_TARIFA.Name = "BTN_EDITAR_TARIFA";
            this.BTN_EDITAR_TARIFA.Size = new System.Drawing.Size(75, 23);
            this.BTN_EDITAR_TARIFA.TabIndex = 0;
            this.BTN_EDITAR_TARIFA.Text = "Editar";
            this.BTN_EDITAR_TARIFA.UseVisualStyleBackColor = true;
            this.BTN_EDITAR_TARIFA.Click += new System.EventHandler(this.BTN_EDITAR_TARIFA_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(577, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Gerenciar Usuários:";
            // 
            // BTN_EDITAR_USUARIO
            // 
            this.BTN_EDITAR_USUARIO.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_EDITAR_USUARIO.Location = new System.Drawing.Point(529, 241);
            this.BTN_EDITAR_USUARIO.Name = "BTN_EDITAR_USUARIO";
            this.BTN_EDITAR_USUARIO.Size = new System.Drawing.Size(75, 23);
            this.BTN_EDITAR_USUARIO.TabIndex = 4;
            this.BTN_EDITAR_USUARIO.Text = "Editar";
            this.BTN_EDITAR_USUARIO.UseVisualStyleBackColor = true;
            this.BTN_EDITAR_USUARIO.Click += new System.EventHandler(this.BTN_EDITAR_USUARIO_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.PICBOX_CONFIRMAR_SENHA);
            this.groupBox2.Controls.Add(this.PICBOX_SENHA);
            this.groupBox2.Controls.Add(this.CKBOX_ADMIN);
            this.groupBox2.Controls.Add(this.MBX_CONFIRMAR_SENHA);
            this.groupBox2.Controls.Add(this.LBL_CONFIRMAR_SENHA);
            this.groupBox2.Controls.Add(this.BTN_CADASTRAR);
            this.groupBox2.Controls.Add(this.MBX_SENHA);
            this.groupBox2.Controls.Add(this.LBL_SENHA);
            this.groupBox2.Controls.Add(this.TXT_USUARIO);
            this.groupBox2.Controls.Add(this.LBL_USUARIO);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(49, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 171);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastramento:";
            // 
            // PICBOX_CONFIRMAR_SENHA
            // 
            this.PICBOX_CONFIRMAR_SENHA.Enabled = false;
            this.PICBOX_CONFIRMAR_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            this.PICBOX_CONFIRMAR_SENHA.Location = new System.Drawing.Point(111, 138);
            this.PICBOX_CONFIRMAR_SENHA.Name = "PICBOX_CONFIRMAR_SENHA";
            this.PICBOX_CONFIRMAR_SENHA.Size = new System.Drawing.Size(18, 18);
            this.PICBOX_CONFIRMAR_SENHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX_CONFIRMAR_SENHA.TabIndex = 26;
            this.PICBOX_CONFIRMAR_SENHA.TabStop = false;
            this.PICBOX_CONFIRMAR_SENHA.Click += new System.EventHandler(this.PICBOX_CONFIRMAR_SENHA_Click);
            // 
            // PICBOX_SENHA
            // 
            this.PICBOX_SENHA.Enabled = false;
            this.PICBOX_SENHA.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            this.PICBOX_SENHA.Location = new System.Drawing.Point(111, 97);
            this.PICBOX_SENHA.Name = "PICBOX_SENHA";
            this.PICBOX_SENHA.Size = new System.Drawing.Size(18, 18);
            this.PICBOX_SENHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX_SENHA.TabIndex = 25;
            this.PICBOX_SENHA.TabStop = false;
            this.PICBOX_SENHA.Click += new System.EventHandler(this.PICBOX_NOVA_SENHA_Click);
            // 
            // CKBOX_ADMIN
            // 
            this.CKBOX_ADMIN.AutoSize = true;
            this.CKBOX_ADMIN.Enabled = false;
            this.CKBOX_ADMIN.Location = new System.Drawing.Point(144, 50);
            this.CKBOX_ADMIN.Name = "CKBOX_ADMIN";
            this.CKBOX_ADMIN.Size = new System.Drawing.Size(71, 23);
            this.CKBOX_ADMIN.TabIndex = 8;
            this.CKBOX_ADMIN.Text = "Admin";
            this.CKBOX_ADMIN.UseVisualStyleBackColor = true;
            // 
            // MBX_CONFIRMAR_SENHA
            // 
            this.MBX_CONFIRMAR_SENHA.Enabled = false;
            this.MBX_CONFIRMAR_SENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MBX_CONFIRMAR_SENHA.Location = new System.Drawing.Point(8, 138);
            this.MBX_CONFIRMAR_SENHA.MaximumSize = new System.Drawing.Size(97, 20);
            this.MBX_CONFIRMAR_SENHA.MinimumSize = new System.Drawing.Size(97, 20);
            this.MBX_CONFIRMAR_SENHA.Name = "MBX_CONFIRMAR_SENHA";
            this.MBX_CONFIRMAR_SENHA.Size = new System.Drawing.Size(97, 20);
            this.MBX_CONFIRMAR_SENHA.TabIndex = 7;
            this.MBX_CONFIRMAR_SENHA.UseSystemPasswordChar = true;
            // 
            // LBL_CONFIRMAR_SENHA
            // 
            this.LBL_CONFIRMAR_SENHA.AutoSize = true;
            this.LBL_CONFIRMAR_SENHA.Enabled = false;
            this.LBL_CONFIRMAR_SENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LBL_CONFIRMAR_SENHA.Location = new System.Drawing.Point(5, 122);
            this.LBL_CONFIRMAR_SENHA.Name = "LBL_CONFIRMAR_SENHA";
            this.LBL_CONFIRMAR_SENHA.Size = new System.Drawing.Size(86, 13);
            this.LBL_CONFIRMAR_SENHA.TabIndex = 15;
            this.LBL_CONFIRMAR_SENHA.Text = "Confirmar senha:";
            // 
            // BTN_CADASTRAR
            // 
            this.BTN_CADASTRAR.Enabled = false;
            this.BTN_CADASTRAR.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_CADASTRAR.Location = new System.Drawing.Point(145, 135);
            this.BTN_CADASTRAR.Name = "BTN_CADASTRAR";
            this.BTN_CADASTRAR.Size = new System.Drawing.Size(85, 25);
            this.BTN_CADASTRAR.TabIndex = 9;
            this.BTN_CADASTRAR.Text = "Cadastrar";
            this.BTN_CADASTRAR.UseVisualStyleBackColor = true;
            // 
            // MBX_SENHA
            // 
            this.MBX_SENHA.Enabled = false;
            this.MBX_SENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MBX_SENHA.Location = new System.Drawing.Point(8, 97);
            this.MBX_SENHA.MaximumSize = new System.Drawing.Size(97, 20);
            this.MBX_SENHA.MinimumSize = new System.Drawing.Size(97, 20);
            this.MBX_SENHA.Name = "MBX_SENHA";
            this.MBX_SENHA.Size = new System.Drawing.Size(97, 20);
            this.MBX_SENHA.TabIndex = 6;
            this.MBX_SENHA.UseSystemPasswordChar = true;
            // 
            // LBL_SENHA
            // 
            this.LBL_SENHA.AutoSize = true;
            this.LBL_SENHA.Enabled = false;
            this.LBL_SENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LBL_SENHA.Location = new System.Drawing.Point(5, 79);
            this.LBL_SENHA.Name = "LBL_SENHA";
            this.LBL_SENHA.Size = new System.Drawing.Size(41, 13);
            this.LBL_SENHA.TabIndex = 13;
            this.LBL_SENHA.Text = "Senha:";
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.Enabled = false;
            this.TXT_USUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TXT_USUARIO.Location = new System.Drawing.Point(8, 52);
            this.TXT_USUARIO.MaximumSize = new System.Drawing.Size(97, 20);
            this.TXT_USUARIO.MinimumSize = new System.Drawing.Size(97, 20);
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(97, 20);
            this.TXT_USUARIO.TabIndex = 5;
            // 
            // LBL_USUARIO
            // 
            this.LBL_USUARIO.AutoSize = true;
            this.LBL_USUARIO.Enabled = false;
            this.LBL_USUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LBL_USUARIO.Location = new System.Drawing.Point(5, 33);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(46, 13);
            this.LBL_USUARIO.TabIndex = 10;
            this.LBL_USUARIO.Text = "Usuário:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.PICBOX_SENHA_PERMISSAO);
            this.groupBox3.Controls.Add(this.BTN_GER_USUARIOS);
            this.groupBox3.Controls.Add(this.BTN_ALTERAR_SENHA_PERMISSAO);
            this.groupBox3.Controls.Add(this.LBL_LINHA);
            this.groupBox3.Controls.Add(this.MBX_SENHA_PERMISSAO);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.Location = new System.Drawing.Point(339, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 171);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alterar Senha Permissão:";
            // 
            // PICBOX_SENHA_PERMISSAO
            // 
            this.PICBOX_SENHA_PERMISSAO.Enabled = false;
            this.PICBOX_SENHA_PERMISSAO.Image = global::MarchPark.Properties.Resources.olho_senha_ver;
            this.PICBOX_SENHA_PERMISSAO.Location = new System.Drawing.Point(119, 35);
            this.PICBOX_SENHA_PERMISSAO.Name = "PICBOX_SENHA_PERMISSAO";
            this.PICBOX_SENHA_PERMISSAO.Size = new System.Drawing.Size(18, 18);
            this.PICBOX_SENHA_PERMISSAO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX_SENHA_PERMISSAO.TabIndex = 28;
            this.PICBOX_SENHA_PERMISSAO.TabStop = false;
            this.PICBOX_SENHA_PERMISSAO.Click += new System.EventHandler(this.PICBOX_SENHA_PERMISSAO_Click);
            // 
            // BTN_GER_USUARIOS
            // 
            this.BTN_GER_USUARIOS.Enabled = false;
            this.BTN_GER_USUARIOS.Location = new System.Drawing.Point(21, 116);
            this.BTN_GER_USUARIOS.Name = "BTN_GER_USUARIOS";
            this.BTN_GER_USUARIOS.Size = new System.Drawing.Size(200, 31);
            this.BTN_GER_USUARIOS.TabIndex = 12;
            this.BTN_GER_USUARIOS.Text = "Gerenciamento de Usuários";
            this.BTN_GER_USUARIOS.UseVisualStyleBackColor = true;
            // 
            // BTN_ALTERAR_SENHA_PERMISSAO
            // 
            this.BTN_ALTERAR_SENHA_PERMISSAO.Enabled = false;
            this.BTN_ALTERAR_SENHA_PERMISSAO.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_ALTERAR_SENHA_PERMISSAO.Location = new System.Drawing.Point(148, 29);
            this.BTN_ALTERAR_SENHA_PERMISSAO.Name = "BTN_ALTERAR_SENHA_PERMISSAO";
            this.BTN_ALTERAR_SENHA_PERMISSAO.Size = new System.Drawing.Size(73, 25);
            this.BTN_ALTERAR_SENHA_PERMISSAO.TabIndex = 11;
            this.BTN_ALTERAR_SENHA_PERMISSAO.Text = "Alterar";
            this.BTN_ALTERAR_SENHA_PERMISSAO.UseVisualStyleBackColor = true;
            // 
            // LBL_LINHA
            // 
            this.LBL_LINHA.AutoSize = true;
            this.LBL_LINHA.Enabled = false;
            this.LBL_LINHA.Location = new System.Drawing.Point(17, 71);
            this.LBL_LINHA.Name = "LBL_LINHA";
            this.LBL_LINHA.Size = new System.Drawing.Size(213, 19);
            this.LBL_LINHA.TabIndex = 8;
            this.LBL_LINHA.Text = "__________________________________";
            // 
            // MBX_SENHA_PERMISSAO
            // 
            this.MBX_SENHA_PERMISSAO.Enabled = false;
            this.MBX_SENHA_PERMISSAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MBX_SENHA_PERMISSAO.Location = new System.Drawing.Point(21, 32);
            this.MBX_SENHA_PERMISSAO.MaximumSize = new System.Drawing.Size(92, 20);
            this.MBX_SENHA_PERMISSAO.MinimumSize = new System.Drawing.Size(92, 20);
            this.MBX_SENHA_PERMISSAO.Name = "MBX_SENHA_PERMISSAO";
            this.MBX_SENHA_PERMISSAO.Size = new System.Drawing.Size(92, 20);
            this.MBX_SENHA_PERMISSAO.TabIndex = 10;
            this.MBX_SENHA_PERMISSAO.UseSystemPasswordChar = true;
            // 
            // FRM_GERENCIAMENTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 500);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_EDITAR_USUARIO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTN_EDITAR_TARIFA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 500);
            this.Name = "FRM_GERENCIAMENTO";
            this.Text = "FRM_GERENCIAMENTO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_CONFIRMAR_SENHA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_SENHA)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_SENHA_PERMISSAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_MOTO;
        private System.Windows.Forms.Label LBL_CARRO;
        private System.Windows.Forms.Label LBL_RS2;
        private System.Windows.Forms.Label LBL_RS1;
        private System.Windows.Forms.TextBox TXT_MOTO;
        private System.Windows.Forms.TextBox TXT_CARRO;
        private System.Windows.Forms.Button BTN_ALTERAR;
        private System.Windows.Forms.Button BTN_EDITAR_TARIFA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_EDITAR_USUARIO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MBX_CONFIRMAR_SENHA;
        private System.Windows.Forms.Label LBL_CONFIRMAR_SENHA;
        private System.Windows.Forms.Button BTN_CADASTRAR;
        private System.Windows.Forms.MaskedTextBox MBX_SENHA;
        private System.Windows.Forms.Label LBL_SENHA;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Label LBL_USUARIO;
        private System.Windows.Forms.PictureBox PICBOX_CONFIRMAR_SENHA;
        private System.Windows.Forms.PictureBox PICBOX_SENHA;
        private System.Windows.Forms.Label LBL_LINHA;
        private System.Windows.Forms.Button BTN_ALTERAR_SENHA_PERMISSAO;
        private System.Windows.Forms.PictureBox PICBOX_SENHA_PERMISSAO;
        private System.Windows.Forms.MaskedTextBox MBX_SENHA_PERMISSAO;
        private System.Windows.Forms.Button BTN_GER_USUARIOS;
        private System.Windows.Forms.CheckBox CKBOX_ADMIN;
    }
}