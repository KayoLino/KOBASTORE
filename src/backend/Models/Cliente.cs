namespace backend.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
