namespace StoreApp.Entities
{
    internal class OrderItem
    {
        public Product Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
