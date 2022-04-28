﻿// <auto-generated />
using System;
using EFDataAccessLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDataAccessLibrary.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20220427011726_dateMigration")]
    partial class dateMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFDataAccessLibrary.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 4, 27, 3, 17, 26, 521, DateTimeKind.Local).AddTicks(5927),
                            Name = "Product1",
                            Price = 1m,
                            ShortDescription = "Very cool product1"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 4, 27, 3, 17, 26, 521, DateTimeKind.Local).AddTicks(5954),
                            Name = "Product2",
                            Price = 2m,
                            ShortDescription = "Very cool product2"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2022, 4, 27, 3, 17, 26, 521, DateTimeKind.Local).AddTicks(5957),
                            Name = "Product3",
                            Price = 3m,
                            ShortDescription = "Very cool product3"
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2022, 4, 27, 3, 17, 26, 521, DateTimeKind.Local).AddTicks(5959),
                            Name = "Product4",
                            Price = 4m,
                            ShortDescription = "Very cool product4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}