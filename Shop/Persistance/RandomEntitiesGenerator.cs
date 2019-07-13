using System;
using System.Collections.Generic;
using FizzWare.NBuilder;
using Shop.Domain.Entities;

namespace Shop.Persistance
{
    internal static class RandomEntitiesGenerator
    {
        public static (IList<Customer>, IList<Order>) Seed()
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

            return (customers, orders);
        }
    }
}
