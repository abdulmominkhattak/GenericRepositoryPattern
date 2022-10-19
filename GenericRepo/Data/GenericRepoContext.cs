using GenericRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepo.Data
{
    public class GenericRepoContext :DbContext
    {
   
     
        public GenericRepoContext(DbContextOptions<GenericRepoContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set;  }


     


    }
}
