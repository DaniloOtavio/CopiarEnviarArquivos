namespace CopiaCompactaFiscal
{
    partial class ConfigEmail
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
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtSenha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtServidor = new TextBox();
            btnSair = new Button();
            button1 = new Button();
            rdoTLS = new RadioButton();
            rdoSSL = new RadioButton();
            portaSMTP = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)portaSMTP).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 50;
            label2.Text = "E-Mail Remetente";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 27);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 23);
            txtEmail.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 52;
            label1.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 71);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(249, 23);
            txtSenha.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 54;
            label3.Text = "Porta SMTP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 97);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 56;
            label4.Text = "Servidor SMTP";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(86, 115);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(175, 23);
            txtServidor.TabIndex = 55;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(152, 169);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(109, 42);
            btnSair.TabIndex = 57;
            btnSair.Text = "Fechar";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 169);
            button1.Name = "button1";
            button1.Size = new Size(109, 42);
            button1.TabIndex = 58;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rdoTLS
            // 
            rdoTLS.AutoSize = true;
            rdoTLS.Location = new Point(13, 144);
            rdoTLS.Name = "rdoTLS";
            rdoTLS.Size = new Size(43, 19);
            rdoTLS.TabIndex = 59;
            rdoTLS.TabStop = true;
            rdoTLS.Text = "TLS";
            rdoTLS.UseVisualStyleBackColor = true;
            // 
            // rdoSSL
            // 
            rdoSSL.AutoSize = true;
            rdoSSL.Location = new Point(62, 144);
            rdoSSL.Name = "rdoSSL";
            rdoSSL.Size = new Size(43, 19);
            rdoSSL.TabIndex = 59;
            rdoSSL.TabStop = true;
            rdoSSL.Text = "SSL";
            rdoSSL.UseVisualStyleBackColor = true;
            // 
            // portaSMTP
            // 
            portaSMTP.Location = new Point(13, 115);
            portaSMTP.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            portaSMTP.Name = "portaSMTP";
            portaSMTP.Size = new Size(67, 23);
            portaSMTP.TabIndex = 60;
            // 
            // ConfigEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 222);
            ControlBox = false;
            Controls.Add(portaSMTP);
            Controls.Add(rdoSSL);
            Controls.Add(rdoTLS);
            Controls.Add(button1);
            Controls.Add(btnSair);
            Controls.Add(label4);
            Controls.Add(txtServidor);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Name = "ConfigEmail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfigEmail";
            Load += ConfigEmail_Load;
            ((System.ComponentModel.ISupportInitialize)portaSMTP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtSenha;
        private Label label3;
        private Label label4;
        private TextBox txtServidor;
        private Button btnSair;
        private Button button1;
        private RadioButton rdoTLS;
        private RadioButton rdoSSL;
        private NumericUpDown portaSMTP;
    }
}