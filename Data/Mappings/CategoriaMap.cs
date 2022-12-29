using Mapeamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapeamento.Data.Mappings{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>

    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey( x=> x.Id);

            builder.Property( x=> x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired() // não aceita valores nulos
                .HasColumnName("Nome") // nome coluna
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80); // max de caracteres


            builder.Property(x => x.Slug)
                .IsRequired() // não aceita valores nulos
                .HasColumnName("Nome") // nome coluna
                .HasColumnType("VARCHAR")
                .HasMaxLength(80); // max de caracteres
        }
    }
}