using CreateEFCoreDB.Config;
using CreateEFCoreDB.Model;
using Microsoft.EntityFrameworkCore;

namespace CreateEFCoreDB
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order2Product> OrdersProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        public Context(DbContextOptions options) : base(options) { }

        public Context() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerConfig.SetEntityBuilder(modelBuilder.Entity<Customer>());
            OrderConfig.SetEntityBuilder(modelBuilder.Entity<Order>());
            OrderProductsConfig.SetEntityBuilder(modelBuilder.Entity<Order2Product>());
            ProductConfig.SetEntityBuilder(modelBuilder.Entity<Product>());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-96VBMK9\SQLEXPRESS;Initial Catalog=efExampleDb;Integrated Security=True");
        }
    }
}
