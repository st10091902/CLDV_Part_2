using Microsoft.EntityFrameworkCore;

namespace CLDV_Part_2.Models
{
    public class KhumaloCraftContext : DbContext
    {
        public KhumaloCraftContext(DbContextOptions<KhumaloCraftContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
