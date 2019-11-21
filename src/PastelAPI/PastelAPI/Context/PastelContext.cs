using Microsoft.EntityFrameworkCore;
using PastelAPI.Models;

namespace PastelAPI.Context
{
    public class PastelContext : DbContext
    {
        public PastelContext(DbContextOptions<PastelContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<PedidoItem> PedidoItens { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Setor> Setores { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasIndex(e => e.Username).IsUnique();
            modelBuilder.Entity<PedidoItem>().HasKey(e => new { e.ProdutoId, e.PedidoId });

            modelBuilder.Seed();
        }
    }
}
