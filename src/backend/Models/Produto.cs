using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Precision(10, 2)]
        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        [Required]
        public int Estoque { get; set; }

        [Required]
        public string Categoria { get; set; }
    }
}
