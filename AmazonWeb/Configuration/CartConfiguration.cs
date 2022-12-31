using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AmazonWeb.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Price).HasDefaultValue(0);
            builder.Property(c => c.Quantity).HasMaxLength(100)
                .HasColumnType("text");
            builder.HasOne(c => c.Product).WithMany(p => p.Carts)
                .HasForeignKey(c => c.ProductId);
        }
    }
}
