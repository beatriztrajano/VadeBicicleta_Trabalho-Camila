namespace LoginComInterface
{
    partial class Main
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
            btnLogar = new Button();
            btnCadastrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(335, 130);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(125, 30);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnEntrar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(335, 222);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 30);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(325, 47);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 4;
            label1.Text = "Escolha uma Opção: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnLogar);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogar;
        private Button btnCadastrar;
        private Label label1;
    }
}