using Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalogo.Infrastructure.EntitiesConfiguration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        //public void Configure(EntityTypeBuilder<Categoria> builder)
        //{
        //    builder.HasKey(t => t.Id);
        //    builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
        //    builder.Property(p => p.ImagemUrl).HasMaxLength(100).IsRequired();

        //    builder.HasData(
        //      new Categoria(1, "Material Escolar", "material.jpg"),
        //      new Categoria(2, "Eletrônicos", "eletronicos.jpg"),
        //      new Categoria(3, "Acessórios", "acessorios.jpg")
        //    );
        //}
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).IsRequired();
            builder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.ImagemUrl).HasColumnType("varchar(100)").IsRequired();
            builder.ToTable("Categoria");
        }
    }
}
