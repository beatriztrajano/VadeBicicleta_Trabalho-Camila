using LoginComInterface.Context;
using LoginComInterface.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginComInterface
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnLoginSQL_Click(object sender, EventArgs e)
        {
            string usuario = textUsuarioL.Text;
            string senha = textSenhaL.Text;

            using (var context = new LoginDbContext())
            {
                Login? user = context.Logins.FirstOrDefault(x => x.Usuario == usuario);

                if (user is null || !BCrypt.Net.BCrypt.Verify(senha, user.Senha))
                {
                    MessageBox.Show("Usuário ou senha inválidos", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Logado", "[INFO]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuPrincipal tela = new MenuPrincipal();
                    tela.ShowDialog();
                }

            }
        }
    }
}
