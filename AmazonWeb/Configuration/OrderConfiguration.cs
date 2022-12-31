using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonWeb.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.ShipAdress).HasMaxLength(100).HasColumnType("text");
            builder.Property(o => o.ShipEmail).HasMaxLength(100).HasColumnType("text");
            builder.Property(o => o.ShipName).HasMaxLength(100).HasColumnType("text");
            builder.Property(o => o.ShipPhoneNumber).HasMaxLength(100).HasColumnType("text")
                .IsUnicode(false);

            builder.HasOne(u => u.AppUser).WithMany(o => o.Orders).HasForeignKey(u => u.UserId);
        }
    }
}
