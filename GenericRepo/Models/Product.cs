namespace GenericRepo.Models
{
    public class Product
    {
        public int Id { get; set; }
        //non nullable strings, remove the warning. 
        public string Name { get; set; } = null!;
        public double Price { get; set; }

        public ICollection<Order> Orders { get; set; } = null!; //Navigation property in EF.

        // it indicates the customer have Zero Or More Orders
        //Create One - to - Many relationship in the database 

    }
}
