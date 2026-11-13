namespace LoginComInterface
{
    partial class TelaLogin
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
            label5 = new Label();
            label4 = new Label();
            textSenhaL = new TextBox();
            textUsuarioL = new TextBox();
            label1 = new Label();
            btnLoginSQL = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(348, 71);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 14;
            label5.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 180);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "Senha";
            // 
            // textSenhaL
            // 
            textSenhaL.Location = new Point(329, 198);
            textSenhaL.Name = "textSenhaL";
            textSenhaL.PasswordChar = '*';
            textSenhaL.Size = new Size(100, 23);
            textSenhaL.TabIndex = 12;
            // 
            // textUsuarioL
            // 
            textUsuarioL.Location = new Point(329, 145);
            textUsuarioL.Name = "textUsuarioL";
            textUsuarioL.Size = new Size(100, 23);
            textUsuarioL.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 127);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 10;
            label1.Text = "Usuario";
            // 
            // btnLoginSQL
            // 
            btnLoginSQL.Location = new Point(329, 246);
            btnLoginSQL.Name = "btnLoginSQL";
            btnLoginSQL.Size = new Size(100, 25);
            btnLoginSQL.TabIndex = 15;
            btnLoginSQL.Text = "Logar";
            btnLoginSQL.UseVisualStyleBackColor = true;
            btnLoginSQL.Click += btnLoginSQL_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoginSQL);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textSenhaL);
            Controls.Add(textUsuarioL);
            Controls.Add(label1);
            Name = "TelaLogin";
            Text = "TelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox textSenhaL;
        private TextBox textUsuarioL;
        private Label label1;
        private Button btnLoginSQL;
    }
}