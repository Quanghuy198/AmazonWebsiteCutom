using System;

using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ImageProductConfiguration : IEntityTypeConfiguration<ImageProduct>
{
    public void Configure(EntityTypeBuilder<ImageProduct> builder)
    {
        builder.ToTable("ImageProduct");

        builder.HasKey(p => p.Id);
        builder.Property(i => i.LinkImage).HasColumnType("tinyint");
        builder.Property(i => i.LinkImage).HasMaxLength(100).HasColumnType("text").IsRequired();
        builder.Property(i => i.IsPreview).HasDefaultValue(false).IsRequired();
        builder.HasOne(p => p.Product).WithMany(i => i.Images).HasForeignKey(p=>p.ProductId);
    }


}

    