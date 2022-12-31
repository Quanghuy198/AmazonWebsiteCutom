using System;
using AmazonWeb.Configuration;
using AmazonWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AmazonWeb.EF
{
    public class EDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {

        public DbSet<AppUser> appUsers { get; set; }
        public DbSet<AppRole> appRoles { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<Contact> contacts { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductTranslation> productTranslations { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }

        public EDbContext(DbContextOptions<EDbContext> options) : base(options)
        {
        }

        public EDbContext()
        {
        }

        private string _connectionString = @"
                Data Source=localhost,1433;
                Initial Catalog=AmazonDB;
                User ID=root;Password=Quanghuy123";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ImageProductConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaim")
                .HasKey(x => x.Id);
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogin")
                .HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaim")
                .HasKey(x => x.Id);
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserToken")
                .HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRole")
                .HasKey(x => new { x.UserId, x.RoleId });
            // base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionString);
        }
    }
}
