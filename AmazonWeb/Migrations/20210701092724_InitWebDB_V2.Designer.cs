﻿// <auto-generated />
using System;
using AmazonWeb.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AmazonWeb.Migrations
{
    [DbContext(typeof(EDbContext))]
    [Migration("20210701092724_InitWebDB_V2")]
    partial class InitWebDB_V2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("AmazonWeb.Models.AppRole", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppRole");
                });

            modelBuilder.Entity("AmazonWeb.Models.AppUser", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("AmazonWeb.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Quantity")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("AmazonWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsShowOnHome")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .IsUnicode(true)
                        .HasColumnType("text");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("SeoAlias")
                        .HasMaxLength(250)
                        .HasColumnType("text");

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(250)
                        .HasColumnType("text");

                    b.Property<string>("SeoTitle")
                        .HasMaxLength(250)
                        .HasColumnType("text");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("AmazonWeb.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("AmazonWeb.Models.ImageProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsPreview")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("LinkImage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ImageProduct");
                });

            modelBuilder.Entity("AmazonWeb.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("AmazonWeb.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ShipAdress")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<string>("ShipEmail")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<string>("ShipName")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<string>("ShipPhoneNumber")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<byte[]>("UserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("AmazonWeb.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Quantity")
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("AmazonWeb.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("productCategories");
                });

            modelBuilder.Entity("AmazonWeb.Models.ProductTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Detail")
                        .HasColumnType("text");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SeoTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductTranslation");
                });

            modelBuilder.Entity("AmazonWeb.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18, 2)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("SeoAlias")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("text");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<byte[]>("RoleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<byte[]>("UserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<byte[]>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<byte[]>("UserId")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("RoleId")
                        .HasColumnType("varbinary(16)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<byte[]>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("AppUserToken");
                });

            modelBuilder.Entity("AmazonWeb.Models.Cart", b =>
                {
                    b.HasOne("AmazonWeb.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AmazonWeb.Models.Category", b =>
                {
                    b.HasOne("AmazonWeb.Models.Language", "Language")
                        .WithMany("Categories")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("AmazonWeb.Models.ImageProduct", b =>
                {
                    b.HasOne("AmazonWeb.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AmazonWeb.Models.Order", b =>
                {
                    b.HasOne("AmazonWeb.Models.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("AmazonWeb.Models.OrderDetail", b =>
                {
                    b.HasOne("AmazonWeb.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmazonWeb.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AmazonWeb.Models.ProductCategory", b =>
                {
                    b.HasOne("AmazonWeb.Models.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmazonWeb.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AmazonWeb.Models.ProductTranslation", b =>
                {
                    b.HasOne("AmazonWeb.Models.Language", "Language")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmazonWeb.Product", "Product")
                        .WithOne("ProductTranslation")
                        .HasForeignKey("AmazonWeb.Models.ProductTranslation", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AmazonWeb.Models.AppUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AmazonWeb.Models.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("AmazonWeb.Models.Language", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("ProductTranslations");
                });

            modelBuilder.Entity("AmazonWeb.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("AmazonWeb.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Images");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductCategories");

                    b.Navigation("ProductTranslation");
                });
#pragma warning restore 612, 618
        }
    }
}