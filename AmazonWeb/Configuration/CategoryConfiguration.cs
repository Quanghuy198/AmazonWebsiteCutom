using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonWeb.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.Id);
            builder.Property(t => t.IsShowOnHome)
                    .IsRequired()
                    .HasDefaultValue(false);
            builder.Property(t => t.ParentId)
                    .HasDefaultValue(0);
            builder.Property(t => t.Status)
                    .IsRequired()
                    .HasDefaultValue(0);

            builder.HasOne(ct => ct.Language).WithMany(l => l.Categories)
            .HasForeignKey(ct => ct.LanguageId);

            builder.Property(p => p.Name).HasColumnType("text")
                .IsUnicode().HasMaxLength(250);
            builder.Property(p => p.SeoDescription)
                .HasColumnType("text").HasMaxLength(250);
            builder.Property(p => p.SeoTitle)
                .HasColumnType("text").HasMaxLength(250);
            builder.Property(p => p.SeoAlias)
                .HasColumnType("text").HasMaxLength(250);
        }
    }
}
