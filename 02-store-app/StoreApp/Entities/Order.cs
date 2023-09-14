using StoreApp.Entities.Enums;
using System.Text;

namespace StoreApp.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            double sum = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("----- Order Sumary -----");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Order Status: {Status.ToString()}");
            sb.AppendLine($"Client: {Client.Name} { Client.BirthDate.ToString("dd/MM/yyyy") } - {Client.Email}");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"Product name: {item.Product.Name}, Quantity: {item.Quantity}, Price: {item.Price}");
                sum += item.SubTotal();
            }

            sb.AppendLine($"Total price: {sum.ToString("F2")}");

            return sb.ToString();
        }
    }
}
