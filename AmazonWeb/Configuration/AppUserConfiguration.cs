using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonWeb.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");
            builder.Property(a => a.LastName).HasColumnType("text")
                .HasMaxLength(100);
            builder.Property(a => a.FirstName).HasColumnType("text")
               .HasMaxLength(100);
        }
    }
}
