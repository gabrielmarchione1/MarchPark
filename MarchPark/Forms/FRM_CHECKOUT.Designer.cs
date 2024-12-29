namespace MarchPark.Forms
{
    partial class FRM_CHECKOUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CHECKOUT));
            this.BTN_FECHAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_VALOR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_SAIDA = new System.Windows.Forms.Label();
            this.LBL_ENTRADA = new System.Windows.Forms.Label();
            this.LBL_VEICULO_CLIENTE = new System.Windows.Forms.Label();
            this.LBL_CPF_CLIENTE = new System.Windows.Forms.Label();
            this.LBL_NOME_CLIENTE = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_FECHAR
            // 
            this.BTN_FECHAR.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BTN_FECHAR.Location = new System.Drawing.Point(123, 293);
            this.BTN_FECHAR.Name = "BTN_FECHAR";
            this.BTN_FECHAR.Size = new System.Drawing.Size(77, 31);
            this.BTN_FECHAR.TabIndex = 0;
            this.BTN_FECHAR.Text = "Fechar";
            this.BTN_FECHAR.UseVisualStyleBackColor = true;
            this.BTN_FECHAR.Click += new System.EventHandler(this.BTN_FECHAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MarchPark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "___________________________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_VALOR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LBL_SAIDA);
            this.groupBox1.Controls.Add(this.LBL_ENTRADA);
            this.groupBox1.Controls.Add(this.LBL_VEICULO_CLIENTE);
            this.groupBox1.Controls.Add(this.LBL_CPF_CLIENTE);
            this.groupBox1.Controls.Add(this.LBL_NOME_CLIENTE);
            this.groupBox1.Location = new System.Drawing.Point(43, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // LBL_VALOR
            // 
            this.LBL_VALOR.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LBL_VALOR.Location = new System.Drawing.Point(9, 165);
            this.LBL_VALOR.Name = "LBL_VALOR";
            this.LBL_VALOR.Size = new System.Drawing.Size(221, 21);
            this.LBL_VALOR.TabIndex = 6;
            this.LBL_VALOR.Text = "VALOR";
            this.LBL_VALOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(24, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "______________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL A PAGAR:";
            // 
            // LBL_SAIDA
            // 
            this.LBL_SAIDA.Location = new System.Drawing.Point(6, 104);
            this.LBL_SAIDA.Name = "LBL_SAIDA";
            this.LBL_SAIDA.Size = new System.Drawing.Size(224, 26);
            this.LBL_SAIDA.TabIndex = 4;
            this.LBL_SAIDA.Text = "Saída";
            this.LBL_SAIDA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_ENTRADA
            // 
            this.LBL_ENTRADA.Location = new System.Drawing.Point(6, 82);
            this.LBL_ENTRADA.Name = "LBL_ENTRADA";
            this.LBL_ENTRADA.Size = new System.Drawing.Size(224, 22);
            this.LBL_ENTRADA.TabIndex = 3;
            this.LBL_ENTRADA.Text = "Entrada";
            this.LBL_ENTRADA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_VEICULO_CLIENTE
            // 
            this.LBL_VEICULO_CLIENTE.Location = new System.Drawing.Point(6, 59);
            this.LBL_VEICULO_CLIENTE.Name = "LBL_VEICULO_CLIENTE";
            this.LBL_VEICULO_CLIENTE.Size = new System.Drawing.Size(224, 22);
            this.LBL_VEICULO_CLIENTE.TabIndex = 2;
            this.LBL_VEICULO_CLIENTE.Text = "Veículo Cliente";
            this.LBL_VEICULO_CLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_CPF_CLIENTE
            // 
            this.LBL_CPF_CLIENTE.Location = new System.Drawing.Point(6, 36);
            this.LBL_CPF_CLIENTE.Name = "LBL_CPF_CLIENTE";
            this.LBL_CPF_CLIENTE.Size = new System.Drawing.Size(224, 22);
            this.LBL_CPF_CLIENTE.TabIndex = 1;
            this.LBL_CPF_CLIENTE.Text = "CPF Cliente";
            this.LBL_CPF_CLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_NOME_CLIENTE
            // 
            this.LBL_NOME_CLIENTE.Location = new System.Drawing.Point(6, 14);
            this.LBL_NOME_CLIENTE.Name = "LBL_NOME_CLIENTE";
            this.LBL_NOME_CLIENTE.Size = new System.Drawing.Size(224, 22);
            this.LBL_NOME_CLIENTE.TabIndex = 0;
            this.LBL_NOME_CLIENTE.Text = "Nome Cliente";
            this.LBL_NOME_CLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_CHECKOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_FECHAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(341, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(341, 375);
            this.Name = "FRM_CHECKOUT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.FRM_CHECKOUT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_FECHAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_VEICULO_CLIENTE;
        private System.Windows.Forms.Label LBL_CPF_CLIENTE;
        private System.Windows.Forms.Label LBL_NOME_CLIENTE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_SAIDA;
        private System.Windows.Forms.Label LBL_ENTRADA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_VALOR;
    }
}