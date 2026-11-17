namespace LoginComInterface
{
    partial class TelaCadastroEstrangeiro
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
            lblNomeArquivo = new Label();
            btnImage = new Button();
            picDocumento = new PictureBox();
            btnCadastrarESql = new Button();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            textSenhaCE = new TextBox();
            textCartaoCCE = new TextBox();
            textPassaporte = new TextBox();
            label2 = new Label();
            textUsuarioCE = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picDocumento).BeginInit();
            SuspendLayout();
            // 
            // lblNomeArquivo
            // 
            lblNomeArquivo.AutoSize = true;
            lblNomeArquivo.Location = new Point(544, 104);
            lblNomeArquivo.Name = "lblNomeArquivo";
            lblNomeArquivo.Size = new Size(85, 15);
            lblNomeArquivo.TabIndex = 27;
            lblNomeArquivo.Text = "Nome Arquivo";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(544, 188);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(100, 25);
            btnImage.TabIndex = 26;
            btnImage.Text = "Escolher Foto";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // picDocumento
            // 
            picDocumento.BorderStyle = BorderStyle.FixedSingle;
            picDocumento.Location = new Point(544, 122);
            picDocumento.Name = "picDocumento";
            picDocumento.Size = new Size(100, 50);
            picDocumento.SizeMode = PictureBoxSizeMode.Zoom;
            picDocumento.TabIndex = 25;
            picDocumento.TabStop = false;
            // 
            // btnCadastrarESql
            // 
            btnCadastrarESql.Location = new Point(330, 335);
            btnCadastrarESql.Name = "btnCadastrarESql";
            btnCadastrarESql.Size = new Size(100, 25);
            btnCadastrarESql.TabIndex = 24;
            btnCadastrarESql.Text = "Cadastrar";
            btnCadastrarESql.UseVisualStyleBackColor = true;
            btnCadastrarESql.Click += btnCadastrarESql_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 262);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 23;
            label3.Text = "Cartão de Crédito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(341, 48);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 22;
            label5.Text = "Cadastro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 157);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 21;
            label4.Text = "Senha";
            // 
            // textSenhaCE
            // 
            textSenhaCE.Location = new Point(330, 175);
            textSenhaCE.Name = "textSenhaCE";
            textSenhaCE.PasswordChar = '*';
            textSenhaCE.Size = new Size(100, 23);
            textSenhaCE.TabIndex = 20;
            // 
            // textCartaoCCE
            // 
            textCartaoCCE.Location = new Point(330, 280);
            textCartaoCCE.Name = "textCartaoCCE";
            textCartaoCCE.Size = new Size(100, 23);
            textCartaoCCE.TabIndex = 19;
            // 
            // textPassaporte
            // 
            textPassaporte.Location = new Point(330, 226);
            textPassaporte.Name = "textPassaporte";
            textPassaporte.Size = new Size(100, 23);
            textPassaporte.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 208);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 17;
            label2.Text = "Passaporte";
            // 
            // textUsuarioCE
            // 
            textUsuarioCE.Location = new Point(330, 122);
            textUsuarioCE.Name = "textUsuarioCE";
            textUsuarioCE.Size = new Size(100, 23);
            textUsuarioCE.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 104);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 15;
            label1.Text = "Usuario";
            // 
            // TelaCadastroEstrangeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNomeArquivo);
            Controls.Add(btnImage);
            Controls.Add(picDocumento);
            Controls.Add(btnCadastrarESql);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textSenhaCE);
            Controls.Add(textCartaoCCE);
            Controls.Add(textPassaporte);
            Controls.Add(label2);
            Controls.Add(textUsuarioCE);
            Controls.Add(label1);
            Name = "TelaCadastroEstrangeiro";
            Text = "TelaCadastroEstrangeiro";
            ((System.ComponentModel.ISupportInitialize)picDocumento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeArquivo;
        private Button btnImage;
        private PictureBox picDocumento;
        private Button btnCadastrarESql;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox textSenhaCE;
        private TextBox textCartaoCCE;
        private TextBox textPassaporte;
        private Label label2;
        private TextBox textUsuarioCE;
        private Label label1;
    }
}