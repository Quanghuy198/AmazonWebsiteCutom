using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonWeb.Configuration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(p => new { p.ProductId, p.CategoryId }) ;

            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductCategories)
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductCategories)
                .HasForeignKey(p => p.CategoryId);

        }
    }
}
