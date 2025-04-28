using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Rua { get; set; }

        [Required]
        [MaxLength(10)]
        public string Numero { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; } 

        [Required]
        [MaxLength(9)]
        public string Cep { get; set; } 

        public string? Complemento { get; set; } 

        [Required]
        public int ClienteId { get; set; } 

        public Cliente Cliente { get; set; } 
    }
}
