using EiSys.GestaoDeEstoque.Domain.Entities;
using FluentAssertions;

namespace EiSys.GestaoDeEstoque.Domain.Test
{
    public class CategoriaTest1
    {
        [Fact(DisplayName = "Criar Categoria")]
        public void CriarPdoduto_ComParametrosValidos_StatusValido()
        {
            Action action = () => new Categoria("Banheiro");
            action.Should()
                .NotThrow<EiSys.GestaoDeEstoque.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criar de produto com Id")]
        public void CriarPdoduto_ComIdValido_StatusValido()
        {
            Action action = () => new Categoria(1, "Banheiro");
            action.Should()
                .NotThrow<EiSys.GestaoDeEstoque.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Criar de produto com Id invalido")]
        public void CriarPdoduto_ComIdInvalido_StatusDeInvalido()
        {
            Action action = () => new Categoria(-1, "Banheiro");
            action.Should()
                .Throw<EiSys.GestaoDeEstoque.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Valor Invalido");
        }
    }
}
