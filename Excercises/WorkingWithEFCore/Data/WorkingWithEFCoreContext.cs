using WorkingWithEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace WorkingWithEFCore.Data
{
    public class WorkingWithEFCoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderedDetail> OrderedDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=WorkingWithEFCore;Integrated Security=True;Trusted_Connection=True;Encrypt=False");
        }
    }
}
