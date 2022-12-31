using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonWeb.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Language");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Name)
                    .IsRequired()
                    .HasColumnType("text");
            builder.Property(l => l.IsDefault)
                    .IsRequired()
                    .HasDefaultValue(false);

        }
    }
}
