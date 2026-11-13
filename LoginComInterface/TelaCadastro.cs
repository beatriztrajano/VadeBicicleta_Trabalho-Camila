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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrarSql_Click(object sender, EventArgs e)
        {
            string usuario = textUsuarioC.Text;
            string senha = textSenhaC.Text;
            string cpf = textCPFC.Text;
            string cartao = textCartaoCC.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(cartao))
            {
                MessageBox.Show("Preencha todos os campos requeridos", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new LoginDbContext())
            {
                if (context.Logins.Any(x => x.Usuario == usuario))
                {
                    MessageBox.Show("Usuário já existe!", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

                context.Logins.Add(new Login(usuario, senhaHash, cpf, cartao));
                context.SaveChanges();

                MessageBox.Show("Usuario Cadastrado com sucesso", "[SUCESSO]", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
        }
    }
}
