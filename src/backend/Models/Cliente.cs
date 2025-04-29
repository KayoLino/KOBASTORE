using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string SenhaHash { get; set; }
        public Endereco? Endereco { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
