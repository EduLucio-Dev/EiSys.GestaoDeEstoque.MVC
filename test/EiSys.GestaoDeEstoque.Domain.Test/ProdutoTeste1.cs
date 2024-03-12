using EiSys.GestaoDeEstoque.Domain.Entities;
using FluentAssertions;

namespace EiSys.GestaoDeEstoque.Domain.Test
{
    public class ProdutoTeste1
    {
        [Fact(DisplayName = "Criar de produto")]
        public void CriarPdoduto_ComParametrosValidos_StatusValido()
        {
            Action action = () => new Produto("Sabonete", "Para mãos", 5.50m, 10, "");
            action.Should()
                .NotThrow<EiSys.GestaoDeEstoque.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criar de produto com Id")]
        public void CriarPdoduto_ComIdValido_StatusValido()
        {
            Action action = () => new Produto(1, "Sabonete", "Para mãos", 5.50m, 10, "");
            action.Should()
                .NotThrow<EiSys.GestaoDeEstoque.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criar de produto com Id invalido")]
        public void CriarPdoduto_ComIdInvalido_StatusDeInvalido()
        {
            Action action = () => new Produto(-1, "Sabonete", "Para mãos", 5.50m, 10, "");
            action.Should()
                .Throw<EiSys.GestaoDeEstoque.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Valor Invalido");
        }

    }
}