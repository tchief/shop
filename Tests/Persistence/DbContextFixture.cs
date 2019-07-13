using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using Shop.Persistence;
using Xunit;

namespace Shop.Tests.Persistence
{
    public class DbContextFixture : IDisposable
    {
        public CustomersDbContext Context { get; }
        public Customer Customer { get; }
        public DbContextOptions<CustomersDbContext> Options { get; }

        public DbContextFixture()
        {
            (Context, Options) = CustomersDbContextFactory.Create();
            Customer = Context.Customers.First();
        }

        public void Dispose() => CustomersDbContextFactory.Dispose(Context);
    }

    [CollectionDefinition("DbContextFixtureCollection")]
    public class DbContextFixtureCollection : ICollectionFixture<DbContextFixture> { }
}