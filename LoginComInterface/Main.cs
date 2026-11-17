using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginComInterface
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();

            telaLogin.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();

            telaCadastro.ShowDialog();
        }

        private void btnCEstrangeiro_Click(object sender, EventArgs e)
        {
            TelaCadastroEstrangeiro telaCadastroEstrangeiro = new TelaCadastroEstrangeiro();

            telaCadastroEstrangeiro.ShowDialog();
        }
    }
}
