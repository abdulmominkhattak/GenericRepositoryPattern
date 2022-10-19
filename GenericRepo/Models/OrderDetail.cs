namespace GenericRepo.Models
{
    public class OrderDetail
    {
        //Intersectional Table that facilitates, Many to Many Relationship. 
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; } //Foreign key
        public int OrderId { get; set; } //Foreign key

        public Order Order { get; set; } = null!; // Navigation Property for Order
        public Product Product { get; set; } = null!; //Navigation Property for Product
    }
}