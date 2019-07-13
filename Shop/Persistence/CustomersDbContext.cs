using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;

namespace Shop.Persistence
{
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var (customers, orders) = RandomEntitiesGenerator.Seed();

            foreach (var customer in customers)
                modelBuilder.Entity<Customer>().HasData(customer);

            foreach (var order in orders)
                modelBuilder.Entity<Order>().HasData(order);
        }

        public override int SaveChanges()
        {
            Validate();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            Validate();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void Validate()
        {
            var entities = (from entry in ChangeTracker.Entries()
                where entry.State == EntityState.Modified || entry.State == EntityState.Added
                select entry.Entity);

            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(entity, validationContext, true);
            }
        }
    }
}