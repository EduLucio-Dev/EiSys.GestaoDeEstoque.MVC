
using EiSys.GestaoDeEstoque.Domain.Validation;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace EiSys.GestaoDeEstoque.Domain.Entities
{
    sealed class Produto : EntitieBase
    {
        public string? Nome { get; private set; }
        public string? Descricao { get; private set; }
        public double Preco {  get; private set; }
        public int Estoque { get; set; }
        public string? Imagem { get; private set; }

        public Produto(string nome, string descricao, double preco, int estoque, string imagem)
        {
            ValidaDominio(nome, descricao, preco, estoque, imagem);
        }

        public Produto(int id, string nome, string descricao, double preco, int estoque, string imagem)
        {
            DomainExceptionValidation.when(id < 0, "Valor Invalido");
            Id = id;
            ValidaDominio(nome, descricao, preco, estoque, imagem);
        }

        public void update(string nome, string descricao, double preco, int estoque, string imagem, int idCategoria)
        {
            ValidaDominio(nome, descricao, preco, estoque, imagem);
            IdCategoria = idCategoria;
        }


        private void ValidaDominio(string nome, string descricao, double preco,int estoque, string imagem)
        {
            //Validamos se o nome for menor que 3 caracteres
            //se o nome vem como nulo. 
            DomainExceptionValidation.when(nome.Length < 3,"Nome muito pequeno, minimo requerido 3 caracteres");
            DomainExceptionValidation.when(string.IsNullOrEmpty(nome),"Nome é obrigatorio!");

            //Validamos se a descrição contem valores e se tem o minimo de 5 caracteres
            DomainExceptionValidation.when(descricao.Length < 5, "Descrição pequena, minimo requerido 5 caracteres");
            DomainExceptionValidation.when(string.IsNullOrEmpty(descricao), "Descrição é obrigatorio!");

            //validamos o preço se é valor valido
            DomainExceptionValidation.when(preco < 0, "Preço invalido");

            //Validamos a quantidade de estoque
            DomainExceptionValidation.when(estoque < 0, "Estoque invalido");

            //Validamos a descrição imagem se a quantidade maxima exceder 250 caracteres
            DomainExceptionValidation.when(imagem.Length > 250,
                "Invalid image name, too long, maximum 250 characters");

            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Imagem = imagem;
        }

        public int IdCategoria { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
