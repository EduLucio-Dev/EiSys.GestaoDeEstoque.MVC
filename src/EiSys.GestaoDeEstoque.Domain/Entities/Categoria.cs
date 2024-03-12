using EiSys.GestaoDeEstoque.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EiSys.GestaoDeEstoque.Domain.Entities
{
    internal class Categoria : EntitieBase
    {
        public string? Nome { get; private set; }


        //Enriquecimento da nossa classe passando os construtores
        //obrigatorio para alteração dos parametros e validações

        public Categoria(string nome)
        {
            ValidaDominio(nome);
        }


        public Categoria(int id, string nome)
        {
            DomainExceptionValidation.when(id < 0, "Invalid Id value");
            Id = id;
            ValidaDominio(nome);
        }
        public void Update(string nome)
        {
            ValidaDominio(nome);
        }

        //Relacionamento da categoria com o produto
        //Um para muitos
        public ICollection<Produto> Produto { get; set; }

        //Chamada do Exception para as validações dos parametros
        private void ValidaDominio(string nome)
        {
            DomainExceptionValidation.when(string.IsNullOrEmpty(nome),
                "Nome é obrigatorio!");

            DomainExceptionValidation.when(nome.Length < 3,
                "Nome curto minimo 3 caracteres");

            Nome = nome;
        }
    }
}
