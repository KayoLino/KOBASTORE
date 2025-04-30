using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class KobaStoreContext : DbContext
    {
        public KobaStoreContext(DbContextOptions<KobaStoreContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Endereco)
                .WithOne(e => e.Cliente)
                .HasForeignKey<Endereco>(e => e.ClienteId);

            modelBuilder.Entity<Cliente>()
               .HasMany(c => c.RefreshTokens)
               .WithOne(rt => rt.Cliente)
               .HasForeignKey(rt => rt.ClienteId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId);

            modelBuilder.Entity<ItemPedido>()
                .HasOne(i => i.Pedido)
                .WithMany(p => p.Itens)
                .HasForeignKey(p => p.PedidoId);

            modelBuilder.Entity<ItemPedido>()
                .HasOne(p => p.Produto)
                .WithMany()
                .HasForeignKey(i => i.ProdutoId);
        }

    }
}
