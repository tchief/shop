using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Persistence.Configuration
{
    // ReSharper disable once UnusedMember.Global
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Name).IsRequired().HasMaxLength(100);
            builder.Property(o => o.Email).IsRequired().HasMaxLength(100);
        }
    }
}
