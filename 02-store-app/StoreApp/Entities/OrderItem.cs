namespace StoreApp.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product product, double price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
