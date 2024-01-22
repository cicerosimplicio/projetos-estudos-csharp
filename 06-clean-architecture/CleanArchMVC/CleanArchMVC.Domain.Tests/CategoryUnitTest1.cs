using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Validation;
using FluentAssertions;
using System.Runtime.ConstrainedExecution;

namespace CleanArchMVC.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact (DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjetctValidState()
        {
            Action action = () => new Category(1, "roupas");
            action.Should()
                .NotThrow<DomainExceptionValidation>();
        }

        [Fact]
        public void CreateCategory_NegativeValueId_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "roupas");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("O id deve ser informado!");
        }

        [Fact]
        public void CreateCategory_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "ro");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("O nome deve ter mais que 3 caracteres.");
        }

        [Fact]
        public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, "");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("A categoria precisa ter um nome!");
        }

        [Fact]
        public void CreateCategory_WithNullNameValue_DomainExceptionInvalidName()
        {
            Action action = () => new Category(1, null);
            action.Should()
                .Throw<DomainExceptionValidation>();
        }
    }
}