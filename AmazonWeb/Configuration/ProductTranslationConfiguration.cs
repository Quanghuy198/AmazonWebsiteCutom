using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonWeb.Configuration
{
    public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslation");

            builder.HasKey(p => p.Id);

            builder.HasOne(pt => pt.Product).WithOne(p => p.ProductTranslation)
                .HasForeignKey<ProductTranslation>(p => p.ProductId);

            builder.HasOne(pt => pt.Language).WithMany(p => p.ProductTranslations)
                .HasForeignKey(pt => pt.LanguageId);

            builder.Property(p => p.Name).IsRequired()
                    .IsUnicode().HasMaxLength(50);
            builder.Property(p => p.Description).IsRequired()
                .HasColumnType("text");
            builder.Property(p => p.SeoDescription).IsRequired()
                .HasColumnType("text");
            builder.Property(p => p.SeoTitle).IsRequired()
                .HasColumnType("text");

        }
    }
}
