namespace backend.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataPedido { get; set; }
        public IEnumerable<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        public decimal ValorTotal { get; set; }
        public string Status { get; set; }
    }
}
