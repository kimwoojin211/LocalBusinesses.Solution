﻿// <auto-generated />
using LocalBusinesses.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBusinesses.Migrations
{
    [DbContext(typeof(LocalBusinessesContext))]
    partial class LocalBusinessesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LocalBusinesses.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Category")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HoursClose")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HoursOpen")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("OwnedBy")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Address = "1 Mom St.",
                            Category = "Restaurant",
                            HoursClose = "23:59",
                            HoursOpen = "11:00",
                            Name = "Mom's Spaghetti",
                            OwnedBy = "Mom Mom",
                            PhoneNumber = "180000081"
                        },
                        new
                        {
                            BusinessId = 2,
                            Address = "2 Mom St.",
                            Category = "Shop",
                            HoursClose = "22:00",
                            HoursOpen = "08:00",
                            Name = "Momma's",
                            OwnedBy = "Moms",
                            PhoneNumber = "180000082"
                        },
                        new
                        {
                            BusinessId = 3,
                            Address = "3 Mom St.",
                            Category = "Restaurant",
                            HoursClose = "17:00",
                            HoursOpen = "08:00",
                            Name = "Mom's",
                            OwnedBy = "Mommy",
                            PhoneNumber = "180000083"
                        },
                        new
                        {
                            BusinessId = 4,
                            Address = "4 Mom St.",
                            Category = "Shop",
                            HoursClose = "20:00",
                            HoursOpen = "06:00",
                            Name = "Mother",
                            OwnedBy = "Mother Dearest",
                            PhoneNumber = "180000084"
                        },
                        new
                        {
                            BusinessId = 5,
                            Address = "5 Mom St.",
                            Category = "Restaurant",
                            HoursClose = "23:00",
                            HoursOpen = "05:00",
                            Name = "Mama's",
                            OwnedBy = "Cooking Mama",
                            PhoneNumber = "180000085"
                        },
                        new
                        {
                            BusinessId = 6,
                            Address = "6 Mom St.",
                            Category = "Restaurant",
                            HoursClose = "23:59",
                            HoursOpen = "11:00",
                            Name = "Madre",
                            OwnedBy = "Mother Español",
                            PhoneNumber = "180000081"
                        },
                        new
                        {
                            BusinessId = 7,
                            Address = "7 Mom St.",
                            Category = "Restaurant",
                            HoursClose = "23:59",
                            HoursOpen = "17:00",
                            Name = "Mère",
                            OwnedBy = "Les Français",
                            PhoneNumber = "180000087"
                        },
                        new
                        {
                            BusinessId = 8,
                            Address = "8 Mom St.",
                            Category = "Shop",
                            HoursClose = "20:00",
                            HoursOpen = "08:00",
                            Name = "For Moms",
                            OwnedBy = "Everyone's Mom",
                            PhoneNumber = "18888888888"
                        },
                        new
                        {
                            BusinessId = 9,
                            Address = "9 Mom St.",
                            Category = "Shop",
                            HoursClose = "18:00",
                            HoursOpen = "08:00",
                            Name = "Four Moms",
                            OwnedBy = "Mom Mom",
                            PhoneNumber = "180000089"
                        },
                        new
                        {
                            BusinessId = 10,
                            Address = "10 Mom St.",
                            Category = "Shop",
                            HoursClose = "23:59",
                            HoursOpen = "00:00",
                            Name = "FortMoms",
                            OwnedBy = "Flossem McDawsom",
                            PhoneNumber = "180000810"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
