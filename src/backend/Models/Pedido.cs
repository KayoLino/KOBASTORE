using backend.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        [Required]
        [Precision(10, 2)]
        public decimal ValorTotal { get; set; }

        [Required]
        public PedidoStatus Status { get; set; }

        public Cliente Cliente { get; set; } 
        public IEnumerable<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
    }
}
