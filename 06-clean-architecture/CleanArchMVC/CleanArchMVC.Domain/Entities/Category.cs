using CleanArchMVC.Domain.Validation;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }
        public ICollection<Product> Products { get; set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "O id deve ser informado!");
            Id = id;
            ValidateDomain(name);
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(name),
                "A categoria precisa ter um nome!");

            DomainExceptionValidation.When(name.Length < 3,
                "O nome deve ter mais que 3 caracteres.");

            Name = name;
        }

        public void UpdateCategoryName(string name)
        {
            ValidateDomain(name);
        }
    }
}
