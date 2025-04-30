using System.ComponentModel.DataAnnotations;

namespace backend.DTOs.Auth
{
    public class RegisterDTO
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos")]
        public string CPF { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

      

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        [MinLength(6)]
        public string Senha { get; set; }

    }
}
