using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Persistence.Configuration
{
    // ReSharper disable once UnusedMember.Global
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.HasKey(o => o.Id);

            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.Price).IsRequired();

            builder.Property(o => o.CustomerId);
            builder.HasIndex(o => o.CustomerId);
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .HasConstraintName("FK_Orders_Customers_CustomerId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
