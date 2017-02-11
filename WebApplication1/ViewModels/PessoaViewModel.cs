using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PessoaViewModel
    {
        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório.")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }

        [MaxLength(20)]
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [Required]
        public string Captcha { get; set; }

        public bool Ativo { get; set; }
    }
}