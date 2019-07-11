using System;
using FizzWare.NBuilder;
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
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Order>().ToTable("Orders");
            
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var customers = Builder<Customer>.CreateListOfSize(100)
                .All()
                    .With(c => c.Name = Faker.Name.FullName())
                    .With(c => c.Email = Faker.Internet.Email())
                .Build();

            var priceGenerator = new RandomGenerator();
            var daysGenerator = new RandomGenerator();

            var orders = Builder<Order>.CreateListOfSize(200)
                .All()
                    .With(o => o.Price = priceGenerator.Next(0m, 99999.99m))
                    .With(o => o.CreatedDate = DateTime.Now.AddDays(-daysGenerator.Next(1, 300)))
                    .With(o => o.CustomerId = Pick<Customer>.RandomItemFrom(customers).Id)
                .Build();

            foreach (var customer in customers)
                modelBuilder.Entity<Customer>().HasData(customer);

            foreach (var order in orders)
                modelBuilder.Entity<Order>().HasData(order);
        }
    }
}