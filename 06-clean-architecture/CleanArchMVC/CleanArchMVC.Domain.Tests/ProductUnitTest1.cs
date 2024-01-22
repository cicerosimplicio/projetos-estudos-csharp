using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Validation;
using FluentAssertions;

namespace CleanArchMVC.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create Product With Valid State")]
        public void CreateProduct_WithValidParameters_ResultObjetctValidState()
        {
            Action action = () => new Product(1, "Produto 1", "Descrição produto 1", 9.99m, 99, "Imagem do produto 1");
            action.Should()
                .NotThrow<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativeValueId_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Produto 1", "Descrição produto 1", 9.99m, 99, "Imagem do produto 1");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("O id deve ser informado.");
        }

        [Fact]
        public void CreateProduct_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Product(1, "Pr", "Descrição produto 1", 9.99m, 99, "Imagem do produto 1");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("O nome deve ter mais que 3 caracteres.");
        }

        [Fact]
        public void CreateProduct_LongNameValue_DomainExceptionLongName()
        {
            Action action = () => new Product(1, "Produto 1", "Descrição produto 1", 9.99m, 99, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbccccccccccccccccccccccccccccccccccccccccccccdddddddddddddddddddddddddddeeeeeeeeeeeeeeeeeeeeefffffffffffffffffffffffgggggggggggggggggggggggggggggggggggghhhhhhhhhhhhhhhhhhhhhhhhh");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("O link da imagem não pode exceder 250 caracteres.");
        }

        [Fact]
        public void CreateProduct_WithNullImageName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(1, "Produto 1", "Descrição produto 1", 9.99m, 99, null);
            action.Should()
                .NotThrow<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WithEmptyImageName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(1, "Produto 1", "Descrição produto 1", 9.99m, 99, "");
            action.Should()
                .NotThrow<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativePriceValue_DomainExceptionInvalidValue()
        {
            Action action = () => new Product(1, "Produto 1", "Descrição produto 1", -9.99m, 99, "Imagem do produto 1");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Preço inválido.");
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(5)]
        public void CreateProduct_WithInvalidStockValue_DomainExceptionIvalidStock(int value)
        {
            Action action = () => new Product(1, "Produto 1", "Descrição produto 1", 9.99m, value, "Imagem do produto 1");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Stock inválido.");
        }
    }
}
