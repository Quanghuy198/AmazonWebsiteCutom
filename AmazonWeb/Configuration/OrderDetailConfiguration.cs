using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AmazonWeb.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(o => new { o.OrderId, o.ProductId });

            builder.Property(o => o.Quantity)
                    .HasColumnType("text").HasMaxLength(100);
            builder.Property(o => o.Price)
                    .HasDefaultValue(0);
            builder.HasOne(o => o.Order).WithMany(od => od.OrderDetails).HasForeignKey(o => o.OrderId);
            builder.HasOne(o => o.Product).WithMany(p => p.OrderDetails).HasForeignKey(o => o.ProductId);
        }
    }
}
