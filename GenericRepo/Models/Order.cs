namespace GenericRepo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public int CustomerId { get; set; } // For Foreign Key. If We don't do it, EF will create shadow property
        public Customer Customer { get; set; } = null!; //Navigation Property, One Customer by Order 

        public ICollection<OrderDetail> OrderDetails { get; set; } = null!; //Navigational Property
    }
}