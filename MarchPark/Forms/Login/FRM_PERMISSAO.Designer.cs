namespace MarchPark.Forms
{
    partial class FRM_PERMISSAO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PERMISSAO));
            this.BTN_CONFIRMAR = new System.Windows.Forms.Button();
            this.MBX_SENHA = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_CONFIRMAR
            // 
            this.BTN_CONFIRMAR.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_CONFIRMAR.Location = new System.Drawing.Point(186, 47);
            this.BTN_CONFIRMAR.Name = "BTN_CONFIRMAR";
            this.BTN_CONFIRMAR.Size = new System.Drawing.Size(85, 25);
            this.BTN_CONFIRMAR.TabIndex = 5;
            this.BTN_CONFIRMAR.Text = "Confirmar";
            this.BTN_CONFIRMAR.UseVisualStyleBackColor = true;
            this.BTN_CONFIRMAR.Click += new System.EventHandler(this.BTN_CONFIRMAR_Click);
            // 
            // MBX_SENHA
            // 
            this.MBX_SENHA.Location = new System.Drawing.Point(18, 50);
            this.MBX_SENHA.Name = "MBX_SENHA";
            this.MBX_SENHA.Size = new System.Drawing.Size(152, 20);
            this.MBX_SENHA.TabIndex = 4;
            this.MBX_SENHA.UseSystemPasswordChar = true;
            this.MBX_SENHA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MBX_SENHA_KeyDown);
            this.MBX_SENHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MBX_SENHA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a Senha de Permissão:";
            // 
            // FRM_PERMISSAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 93);
            this.Controls.Add(this.BTN_CONFIRMAR);
            this.Controls.Add(this.MBX_SENHA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PERMISSAO";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Permissão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CONFIRMAR;
        private System.Windows.Forms.MaskedTextBox MBX_SENHA;
        private System.Windows.Forms.Label label1;
    }
}