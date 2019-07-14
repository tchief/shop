using System;
using FizzWare.NBuilder;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using Shop.Persistence;

namespace Shop.Tests.Persistence
{
    public class CustomersDbContextFactory
    {
        public static (CustomersDbContext, DbContextOptions<CustomersDbContext>) Create()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            var options = new DbContextOptionsBuilder<CustomersDbContext>()
                .UseSqlite(connection)
                .EnableSensitiveDataLogging()
                .Options;

            connection.Open();

            var context = new CustomersDbContext(options);
            context.Database.EnsureCreated();

            var id = 1000;
            var customers = Builder<Customer>.CreateListOfSize(100)
                .All()
                .With(c => c.Id = id++)
                .With(c => c.Name = Faker.Name.FullName())
                .With(c => c.Email = Faker.Internet.Email())
                .Build();

            var customer = new Customer { Id = 1111, Name = "Elon Musk", Email = "elon.musk@mars.com" };
            customers.Add(customer);

            var priceGenerator = new RandomGenerator();
            var daysGenerator = new RandomGenerator();
            id = 1000;

            var orders = Builder<Order>.CreateListOfSize(200)
                .All()
                .With(o => o.Id = id++)
                .With(o => o.Price = priceGenerator.Next(0m, 99999.99m))
                .With(o => o.CreatedDate = DateTime.Now.AddDays(-daysGenerator.Next(1, 300)))
                .With(o => o.CustomerId = Pick<Customer>.RandomItemFrom(customers).Id)
                .Build();

            var order = Builder<Order>.CreateNew()
                .With(o => o.Id = 1234)
                .With(o => o.Price = priceGenerator.Next(0m, 99999.99m))
                .With(o => o.CreatedDate = DateTime.Now.AddDays(-daysGenerator.Next(1, 300)))
                .With(o => o.CustomerId = customer.Id)
                .Build();
            orders.Add(order);

            context.Customers.AddRange(customers);
            context.Orders.AddRange(orders);

            context.SaveChanges();

            return (context, options);
        }

        public static void Dispose(CustomersDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
