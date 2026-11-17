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
    public partial class TelaCadastroEstrangeiro : Form
    {
        private byte[]? _documentoBytes;
        private string? _extensaoDocumento;

        public TelaCadastroEstrangeiro()
        {
            InitializeComponent();
        }

        private async void btnCadastrarESql_Click_1(object sender, EventArgs e)
        {
            string usuario = textUsuarioCE.Text;
            string senha = textSenhaCE.Text;
            string passaporte = textPassaporte.Text;
            string cartao = textCartaoCCE.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(passaporte) || string.IsNullOrEmpty(cartao))
            {
                MessageBox.Show("Preencha todos os campos requeridos", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnCadastrarESql.Enabled = false;

                string? caminhoSalvo = null;

                // 1. Se anexou documento/foto, envia para o Bucket Privado
                if (_documentoBytes != null && !string.IsNullOrEmpty(_extensaoDocumento))
                {
                    caminhoSalvo = await SupabaseStorageService.UploadArquivoAsync(_documentoBytes, _extensaoDocumento, usuario);
                }

                // 2. Grava no banco apenas a string com o caminho do arquivo
                using (var context = new LoginDbContext())
                {
                    if (context.Logins.Any(x => x.Usuario == usuario))
                    {
                        MessageBox.Show("Usuário já existe!", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

                    context.Logins.Add(new Login(usuario, senhaHash, null, passaporte, cartao, caminhoSalvo));
                    context.SaveChanges();

                    MessageBox.Show("Usuário cadastrado com sucesso!", "[SUCESSO]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no cadastro: {ex.Message}", "[ERRO]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCadastrarESql.Enabled = true;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Anexar foto ou PDF do documento";
                openFileDialog.Filter = "Documentos (*.jpg;*.jpeg;*.png;*.pdf)|*.jpg;*.jpeg;*.png;*.pdf";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = openFileDialog.FileName;
                    FileInfo infoArquivo = new FileInfo(caminhoArquivo);

                    // 1. Limite de tamanho (ex: máximo 5 MB) para evitar travamentos ou estouro no banco
                    if (infoArquivo.Length > 5 * 1024 * 1024)
                    {
                        MessageBox.Show("O arquivo deve ter no máximo 5 MB.", "Arquivo muito grande", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _extensaoDocumento = infoArquivo.Extension.ToLower();
                    _documentoBytes = File.ReadAllBytes(caminhoArquivo);
                    lblNomeArquivo.Text = infoArquivo.Name; // Exibe o nome do arquivo selecionado

                    // 2. Se for imagem, exibe a prévia no PictureBox; se for PDF, limpa a prévia visual
                    if (_extensaoDocumento != ".pdf")
                    {
                        using (var stream = new MemoryStream(_documentoBytes))
                        {
                            picDocumento.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        picDocumento.Image = null;
                    }
                }
            }
        }
    }
}
