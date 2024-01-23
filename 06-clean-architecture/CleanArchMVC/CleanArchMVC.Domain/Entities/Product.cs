using CleanArchMVC.Domain.Validation;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "O id deve ser informado.");
            Id = id;
            ValidateDomain(name, description, price, stock, image);
        }

        public void UpdateProduct(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(name),
                "O produto deve ter um nome.");

            DomainExceptionValidation.When(name.Length < 3,
                "O nome deve ter mais que 3 caracteres.");

            DomainExceptionValidation.When(String.IsNullOrEmpty(description),
                "A categoria deve ser definida.");

            DomainExceptionValidation.When(price < 0,
                "Preço inválido.");

            DomainExceptionValidation.When(stock < 0,
                "Stock inválido.");

            DomainExceptionValidation.When(image?.Length > 250,
                "O link da imagem não pode exceder 250 caracteres.");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
    }
}
