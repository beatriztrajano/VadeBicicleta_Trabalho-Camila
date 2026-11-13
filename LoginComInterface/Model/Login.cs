using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoginComInterface.Model
{
    [Index(nameof(Usuario), IsUnique = true)]
    public class Login
    {
        public Login()
        {

        }

        public Login(string user, string senha, string cpf, string cartao)
        {
            Usuario = user;
            Senha = senha;
            CPF = cpf;
            CartaoCredito = cartao;
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

        [Required, MaxLength(11)]
        [Column("cpf")]
        public string CPF { get; set; }

        [Required, MaxLength(25)]
        [Column("cartao")]
        public string CartaoCredito { get; set; }
    }
}
