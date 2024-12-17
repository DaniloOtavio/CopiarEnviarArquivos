namespace CopiaCompactaFiscal
{
    partial class FRMInicio
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
            btnSair = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblAreaTrabalho = new Label();
            lblProcessados = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pbProcessados = new ProgressBar();
            btnProcessar = new Button();
            btnProcurar = new Button();
            txtPasta = new TextBox();
            txtAno = new NumericUpDown();
            txtMes = new NumericUpDown();
            tabPage2 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btnConfigEmail = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMes).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(402, 272);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(109, 42);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(503, 254);
            tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(lblAreaTrabalho);
            tabPage1.Controls.Add(lblProcessados);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(pbProcessados);
            tabPage1.Controls.Add(btnProcessar);
            tabPage1.Controls.Add(btnProcurar);
            tabPage1.Controls.Add(txtPasta);
            tabPage1.Controls.Add(txtAno);
            tabPage1.Controls.Add(txtMes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(495, 226);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Processamento";
            // 
            // lblAreaTrabalho
            // 
            lblAreaTrabalho.AutoSize = true;
            lblAreaTrabalho.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAreaTrabalho.Location = new Point(6, 133);
            lblAreaTrabalho.Name = "lblAreaTrabalho";
            lblAreaTrabalho.Size = new Size(94, 13);
            lblAreaTrabalho.TabIndex = 48;
            lblAreaTrabalho.Text = "PathAreaTrabalho";
            // 
            // lblProcessados
            // 
            lblProcessados.AutoSize = true;
            lblProcessados.Location = new Point(4, 203);
            lblProcessados.Name = "lblProcessados";
            lblProcessados.Size = new Size(154, 15);
            lblProcessados.TabIndex = 47;
            lblProcessados.Text = "0 de 0 arquivos processados";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 120);
            label11.Name = "label11";
            label11.Size = new Size(298, 13);
            label11.TabIndex = 46;
            label11.Text = "Arquivos processados serão armazenados na área de trabalho";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 159);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 45;
            label10.Text = "Progresso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 47);
            label8.Name = "label8";
            label8.Size = new Size(106, 15);
            label8.TabIndex = 44;
            label8.Text = "Caminho Arquivos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 3);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 42;
            label7.Text = "Ano";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 43;
            label6.Text = "Mês";
            // 
            // pbProcessados
            // 
            pbProcessados.Location = new Point(4, 177);
            pbProcessados.Name = "pbProcessados";
            pbProcessados.Size = new Size(480, 23);
            pbProcessados.TabIndex = 41;
            // 
            // btnProcessar
            // 
            btnProcessar.Location = new Point(6, 94);
            btnProcessar.Name = "btnProcessar";
            btnProcessar.Size = new Size(202, 23);
            btnProcessar.TabIndex = 40;
            btnProcessar.Text = "Processar Arquivos";
            btnProcessar.UseVisualStyleBackColor = true;
            btnProcessar.Click += btnProcessar_Click;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(409, 65);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(75, 23);
            btnProcurar.TabIndex = 39;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // txtPasta
            // 
            txtPasta.Enabled = false;
            txtPasta.Location = new Point(6, 66);
            txtPasta.Name = "txtPasta";
            txtPasta.Size = new Size(397, 23);
            txtPasta.TabIndex = 38;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(79, 21);
            txtAno.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(67, 23);
            txtAno.TabIndex = 37;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(6, 21);
            txtMes.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            txtMes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(67, 23);
            txtMes.TabIndex = 36;
            txtMes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(495, 226);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Envio de E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 48;
            label3.Text = "Assunto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 47);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 48;
            label2.Text = "Assunto";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(6, 109);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(483, 111);
            textBox3.TabIndex = 47;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(6, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 23);
            textBox2.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(339, 15);
            label1.TabIndex = 46;
            label1.Text = "Destinatários (Use ponto e vírgula ';' para separar os endereços)";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(6, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(483, 23);
            textBox1.TabIndex = 45;
            // 
            // btnConfigEmail
            // 
            btnConfigEmail.Location = new Point(12, 272);
            btnConfigEmail.Name = "btnConfigEmail";
            btnConfigEmail.Size = new Size(109, 42);
            btnConfigEmail.TabIndex = 20;
            btnConfigEmail.Text = "Configurações E-mail";
            btnConfigEmail.UseVisualStyleBackColor = true;
            btnConfigEmail.Click += btnConfigEmail_Click;
            // 
            // FRMInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 318);
            ControlBox = false;
            Controls.Add(btnConfigEmail);
            Controls.Add(tabControl1);
            Controls.Add(btnSair);
            Name = "FRMInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compactador Fiscal";
            Load += FRMInicio_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAno).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMes).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSair;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblAreaTrabalho;
        private Label lblProcessados;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private ProgressBar pbProcessados;
        private Button btnProcessar;
        private Button btnProcurar;
        private TextBox txtPasta;
        private NumericUpDown txtAno;
        private NumericUpDown txtMes;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button btnConfigEmail;
    }
}