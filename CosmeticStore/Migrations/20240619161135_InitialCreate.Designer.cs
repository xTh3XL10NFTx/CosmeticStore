﻿// <auto-generated />
using System;
using CosmeticStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CosmeticStore.Migrations
{
    [DbContext(typeof(BeautyCareDbContext))]
    [Migration("20240619161135_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CosmeticStore.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfReviews")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PromotionalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = false,
                            Category = "",
                            CreatedAt = new DateTime(2024, 6, 19, 16, 11, 34, 947, DateTimeKind.Utc).AddTicks(2987),
                            Description = "",
                            ImageUrl = "",
                            Ingredients = "",
                            IsFeatured = false,
                            Name = "Product 1",
                            NumberOfReviews = 0,
                            Price = 10.00m,
                            PromotionalPrice = 0.0m,
                            Rating = 0.0,
                            UpdatedAt = new DateTime(2024, 6, 19, 16, 11, 34, 947, DateTimeKind.Utc).AddTicks(2988),
                            Weight = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Availability = false,
                            Category = "",
                            CreatedAt = new DateTime(2024, 6, 19, 16, 11, 34, 947, DateTimeKind.Utc).AddTicks(2991),
                            Description = "",
                            ImageUrl = "",
                            Ingredients = "",
                            IsFeatured = false,
                            Name = "Product 2",
                            NumberOfReviews = 0,
                            Price = 15.00m,
                            PromotionalPrice = 0.0m,
                            Rating = 0.0,
                            UpdatedAt = new DateTime(2024, 6, 19, 16, 11, 34, 947, DateTimeKind.Utc).AddTicks(2991),
                            Weight = 0.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
