using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;

namespace Shop.Persistance
{
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Customer>().HasData(new Customer() { Id = 1, Name = "Elon Mask", Email = "elonmask@mars.com" });
        }
    }
}