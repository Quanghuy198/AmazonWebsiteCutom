using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AmazonWeb;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Price)
        .IsRequired()
        .HasDefaultValue(0);

        builder.Property(p => p.OriginalPrice)
                .IsRequired()
                .HasDefaultValue(0);

        builder.Property(p => p.ViewCount)
                .IsRequired()
                .HasDefaultValue(0);

        builder.Property(p => p.DateCreated)
                .IsRequired();

        builder.Property(p => p.SeoAlias)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("text");

    }

}