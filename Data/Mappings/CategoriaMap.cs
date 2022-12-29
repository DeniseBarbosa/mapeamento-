using Mapeamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapeamento.Data.Mappings{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>

    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
        }
    }
}