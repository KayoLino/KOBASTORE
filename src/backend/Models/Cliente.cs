using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Idade { get; set; }
        [Required]
        [Phone]
        public string Telefone { get; set; }

        [Required]
        public string SenhaHash { get; set; }
        public Endereco? Endereco { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
