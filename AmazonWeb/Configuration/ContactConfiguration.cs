using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonWeb.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasColumnType("text")
                .HasMaxLength(100);
            builder.Property(c => c.Email).HasColumnType("text")
                .HasMaxLength(100);
            builder.Property(c => c.Message).HasColumnType("text")
                .HasMaxLength(100);
            builder.Property(c => c.PhoneNumber).HasColumnType("text")
                .HasMaxLength(100).IsUnicode(false);
            builder.Property(c => c.Status).HasDefaultValue(0);
        }
    }
}
