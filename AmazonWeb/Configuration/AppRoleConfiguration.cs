using System;
using AmazonWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmazonWeb.Configuration
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRole");
            builder.HasKey(r => r.Id);
            builder.Property(a => a.Description).HasMaxLength(200)
                .HasColumnType("text");
        }
    }
}