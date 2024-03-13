using EiSys.GestaoDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EiSys.GestaoDeEstoque.Data.Entities_Configuration
{
    // Classe interna que implementa IEntityTypeConfiguration para configurar o mapeamento da entidade Categoria
    internal class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        // Método de configuração obrigatório da interface IEntityTypeConfiguration
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();

            builder.HasData(
                new Categoria(1, "Material Escolar"),
                new Categoria(2, "Eletronicos"),
                new Categoria(3, "Acessorios")
                );
        }
    }

}
