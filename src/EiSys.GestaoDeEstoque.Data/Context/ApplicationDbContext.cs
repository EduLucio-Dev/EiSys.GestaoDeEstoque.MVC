using EiSys.GestaoDeEstoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EiSys.GestaoDeEstoque.Data.Context
{
    // Classe que representa o contexto do banco de dados, herdando da classe DbContext do Entity Framework
    public class ApplicationDbContext : DbContext
    {
        // Construtor que recebe opções de contexto e repassa para a classe base
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        // Definindo DbSet para as entidades Categoria e Produto, permitindo interação com o banco de dados
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        // Sobrescrevendo o método de configuração do modelo para aplicar configurações de mapeamento ORM
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            // Chamando a implementação da classe base
            base.OnModelCreating(Builder);

            // Sobrescrevendo o método de configuração do modelo para aplicar automaticamente as configurações de mapeamento 
            // contidas no mesmo assembly que a classe ApplicationDbContext. Isso evita a necessidade de configurar cada entidade manualmente.
            Builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }
    }

}
