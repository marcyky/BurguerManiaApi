using apiBurguer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace apiBurguer.Data.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Preco).IsRequired();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1100);
            builder.Property(x => x.Ingredientes).IsRequired().HasMaxLength(1000);
        }
    }
}
