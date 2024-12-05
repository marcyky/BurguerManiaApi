using apiBurguer.Models;
using Microsoft.EntityFrameworkCore;

namespace apiBurguer.Data
{
    public class BurguerManiaDBContext : DbContext
    {
        public BurguerManiaDBContext(DbContextOptions<BurguerManiaDBContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<PedidoModel> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
