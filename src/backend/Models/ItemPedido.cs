using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }

        [Required]
        public int ProdutoId { get; set; }

        [Required]
        public int PedidoId { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        [Precision(10, 2)]
        public decimal PrecoUnitario { get; set; }

        public Produto Produto { get; set; } 
        public Pedido Pedido { get; set; }  
    }
}
