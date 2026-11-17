namespace LoginComInterface
{
    partial class TelaCadastro
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
            label1 = new Label();
            textUsuarioC = new TextBox();
            textCPFC = new TextBox();
            label2 = new Label();
            textCartaoCC = new TextBox();
            textSenhaC = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnCadastrarSql = new Button();
            picDocumento = new PictureBox();
            btnImage = new Button();
            lblNomeArquivo = new Label();
            ((System.ComponentModel.ISupportInitialize)picDocumento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 85);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // textUsuarioC
            // 
            textUsuarioC.Location = new Point(330, 103);
            textUsuarioC.Name = "textUsuarioC";
            textUsuarioC.Size = new Size(100, 23);
            textUsuarioC.TabIndex = 1;
            // 
            // textCPFC
            // 
            textCPFC.Location = new Point(330, 207);
            textCPFC.Name = "textCPFC";
            textCPFC.Size = new Size(100, 23);
            textCPFC.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 189);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // textCartaoCC
            // 
            textCartaoCC.Location = new Point(330, 261);
            textCartaoCC.Name = "textCartaoCC";
            textCartaoCC.Size = new Size(100, 23);
            textCartaoCC.TabIndex = 5;
            // 
            // textSenhaC
            // 
            textSenhaC.Location = new Point(330, 156);
            textSenhaC.Name = "textSenhaC";
            textSenhaC.PasswordChar = '*';
            textSenhaC.Size = new Size(100, 23);
            textSenhaC.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 138);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(341, 29);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 9;
            label5.Text = "Cadastro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 243);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 10;
            label3.Text = "Cartão de Crédito";
            // 
            // btnCadastrarSql
            // 
            btnCadastrarSql.Location = new Point(330, 316);
            btnCadastrarSql.Name = "btnCadastrarSql";
            btnCadastrarSql.Size = new Size(100, 25);
            btnCadastrarSql.TabIndex = 11;
            btnCadastrarSql.Text = "Cadastrar";
            btnCadastrarSql.UseVisualStyleBackColor = true;
            btnCadastrarSql.Click += btnCadastrarSql_Click;
            // 
            // picDocumento
            // 
            picDocumento.BorderStyle = BorderStyle.FixedSingle;
            picDocumento.Location = new Point(544, 103);
            picDocumento.Name = "picDocumento";
            picDocumento.Size = new Size(100, 50);
            picDocumento.SizeMode = PictureBoxSizeMode.Zoom;
            picDocumento.TabIndex = 12;
            picDocumento.TabStop = false;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(544, 169);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(100, 25);
            btnImage.TabIndex = 13;
            btnImage.Text = "Escolher Foto";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // lblNomeArquivo
            // 
            lblNomeArquivo.AutoSize = true;
            lblNomeArquivo.Location = new Point(544, 85);
            lblNomeArquivo.Name = "lblNomeArquivo";
            lblNomeArquivo.Size = new Size(85, 15);
            lblNomeArquivo.TabIndex = 14;
            lblNomeArquivo.Text = "Nome Arquivo";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNomeArquivo);
            Controls.Add(btnImage);
            Controls.Add(picDocumento);
            Controls.Add(btnCadastrarSql);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textSenhaC);
            Controls.Add(textCartaoCC);
            Controls.Add(textCPFC);
            Controls.Add(label2);
            Controls.Add(textUsuarioC);
            Controls.Add(label1);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            ((System.ComponentModel.ISupportInitialize)picDocumento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textUsuarioC;
        private TextBox textCPFC;
        private Label label2;
        private TextBox textCartaoCC;
        private TextBox textSenhaC;
        private Label label4;
        private Label label5;
        private Label label3;
        private Button btnCadastrarSql;
        private PictureBox picDocumento;
        private Button btnImage;
        private Label lblNomeArquivo;
    }
}