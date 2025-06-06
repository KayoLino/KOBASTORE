﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public Produto Produto { get; set; } 
        public Pedido Pedido { get; set; }  
    }
}
