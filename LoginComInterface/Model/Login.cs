using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoginComInterface.Model
{
    [Index(nameof(Usuario), IsUnique = true)]
    [Index(nameof(CPF), IsUnique = true)]
    [Index(nameof(Passaporte), IsUnique = true)]
    public class Login
    {
        public Login()
        {

        }

        // Construtor padrão (Nacional / CPF)
        public Login(string user, string senha, string? cpf, string cartao, string? caminhoDocumento = null)
        {
            Usuario = user;
            Senha = senha;
            CPF = cpf;
            CartaoCredito = cartao;
            CaminhoDocumento = caminhoDocumento;
        }

        // Construtor completo (Estrangeiro ou com Passaporte)
        public Login(string user, string senha, string? cpf, string? passaporte, string cartao, string? caminhoDocumento = null)
        {
            Usuario = user;
            Senha = senha;
            CPF = cpf;
            Passaporte = passaporte;
            CartaoCredito = cartao;
            CaminhoDocumento = caminhoDocumento;
        }

        [Key]
        [Column("id")]
        public int LoginId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("usuario")]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("senha")]
        public string Senha { get; set; }

        [MaxLength(11)]
        [Column("cpf")]
        public string? CPF { get; set; }

        [MaxLength(20)]
        [Column("passaporte")]
        public string? Passaporte { get; set; }

        [Required, MaxLength(25)]
        [Column("cartao")]
        public string CartaoCredito { get; set; }

        [MaxLength(255)]
        [Column("caminho_documento")]
        public string? CaminhoDocumento { get; set; }
    }
}
