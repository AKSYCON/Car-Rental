﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

namespace backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250219072447_UpdateUserTable")]
    partial class UpdateUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backend.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ApprovedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("backend.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RentalPricePerDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "White",
                            DateAdded = new DateTime(2025, 2, 19, 7, 24, 47, 431, DateTimeKind.Utc).AddTicks(2237),
                            IsAvailable = true,
                            Make = "Toyota",
                            Model = "Corolla",
                            Picture = "/pictures/Toyota-Corolla.jpg",
                            RentalPricePerDay = 5000m,
                            Year = 2022
                        },
                        new
                        {
                            Id = 2,
                            Color = "Black",
                            DateAdded = new DateTime(2025, 2, 19, 7, 24, 47, 431, DateTimeKind.Utc).AddTicks(2384),
                            IsAvailable = true,
                            Make = "Honda",
                            Model = "Civic",
                            Picture = "/pictures/Honda-Civic.jpg",
                            RentalPricePerDay = 5500m,
                            Year = 2023
                        },
                        new
                        {
                            Id = 3,
                            Color = "Red",
                            DateAdded = new DateTime(2025, 2, 19, 7, 24, 47, 431, DateTimeKind.Utc).AddTicks(2387),
                            IsAvailable = true,
                            Make = "Ford",
                            Model = "Mustang",
                            Picture = "/pictures/Ford-Mustang.jpg",
                            RentalPricePerDay = 12000m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 4,
                            Color = "Blue",
                            DateAdded = new DateTime(2025, 2, 19, 7, 24, 47, 431, DateTimeKind.Utc).AddTicks(2388),
                            IsAvailable = false,
                            Make = "Tesla",
                            Model = "Model 3",
                            Picture = "/pictures/Tesla-Model3.jpg",
                            RentalPricePerDay = 7000m,
                            Year = 2024
                        },
                        new
                        {
                            Id = 5,
                            Color = "Grey",
                            DateAdded = new DateTime(2025, 2, 19, 7, 24, 47, 431, DateTimeKind.Utc).AddTicks(2390),
                            IsAvailable = true,
                            Make = "BMW",
                            Model = "X5",
                            Picture = "/pictures/BMW-X5.jpg",
                            RentalPricePerDay = 9000m,
                            Year = 2022
                        });
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Report")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            DateCreated = new DateTime(2025, 2, 19, 7, 24, 47, 430, DateTimeKind.Utc).AddTicks(4023),
                            Email = "arhamkalam@admin.com",
                            PasswordHash = "GD@Arhamkala2025madmin@123#AK",
                            Report = false,
                            Role = "Admin",
                            Username = "ArhamAdmin"
                        },
                        new
                        {
                            Id = 2000,
                            DateCreated = new DateTime(2025, 2, 19, 7, 24, 47, 430, DateTimeKind.Utc).AddTicks(4181),
                            Email = "user@gmail.com",
                            PasswordHash = "GD@User2025@123#AK",
                            Report = false,
                            Role = "User",
                            Username = "User"
                        });
                });

            modelBuilder.Entity("backend.Models.Booking", b =>
                {
                    b.HasOne("backend.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
