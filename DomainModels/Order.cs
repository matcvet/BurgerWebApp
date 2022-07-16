namespace DomainModels
{
    public class Order
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal TotalPrice => OrderItems == null ? 0 : OrderItems.Sum(x => x.Quantity * x.MenuItem.Price);

        public Order()
        {

        }
        public Order(int phoneNumber, string address, string note, List<OrderItem> items)
        {
            PhoneNumber = phoneNumber;
            Address = address;
            Note = note;
            OrderItems = items;
        }

        public Order(int id, int phoneNumber, string address, string note, List<OrderItem> items)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            Address = address;
            Note = note;
            OrderItems = items;
        }

    }
}
