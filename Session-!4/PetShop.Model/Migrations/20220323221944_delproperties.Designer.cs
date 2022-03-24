﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.EF.Context;

#nullable disable

namespace PetShop.EF.Migrations
{
    [DbContext(typeof(PetShopAppContext))]
    [Migration("20220323221944_delproperties")]
    partial class delproperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ObjectStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("PetShopClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Tin")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("PetShopClassId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EmpType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ObjectStatus")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<Guid?>("PetShopClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("PetShopClassId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnimalType")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("FoodTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HealthStatus")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("ObjectStatus")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<Guid?>("PetShopClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("FoodTypeID");

                    b.HasIndex("PetShopClassId");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("PetFood", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ObjectStatus")
                        .HasColumnType("int");

                    b.Property<Guid?>("PetShopClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PetShopClassId");

                    b.ToTable("PetFood", (string)null);
                });

            modelBuilder.Entity("PetShopLibrary.DataObjects.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid>("PetShopClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    b.HasIndex("PetShopClassId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("PetShopLibrary.PetShopClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("PetShopClass");
                });

            modelBuilder.Entity("PetShopLibrary.Transaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PetFoodID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PetFoodPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PetFoodQty")
                        .HasColumnType("int");

                    b.Property<Guid>("PetID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PetPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("PetShopClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("PetShopClassId");

                    b.ToTable("Transaction", (string)null);
                });

            modelBuilder.Entity("Customer", b =>
                {
                    b.HasOne("PetShopLibrary.PetShopClass", "PetShopClass")
                        .WithMany("Customers")
                        .HasForeignKey("PetShopClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PetShopClass");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.HasOne("PetShopLibrary.PetShopClass", null)
                        .WithMany("Employees")
                        .HasForeignKey("PetShopClassId");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.HasOne("PetFood", "FoodType")
                        .WithMany()
                        .HasForeignKey("FoodTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShopLibrary.PetShopClass", null)
                        .WithMany("Pets")
                        .HasForeignKey("PetShopClassId");

                    b.Navigation("FoodType");
                });

            modelBuilder.Entity("PetFood", b =>
                {
                    b.HasOne("PetShopLibrary.PetShopClass", null)
                        .WithMany("PetFoods")
                        .HasForeignKey("PetShopClassId");
                });

            modelBuilder.Entity("PetShopLibrary.DataObjects.User", b =>
                {
                    b.HasOne("PetShopLibrary.PetShopClass", "PetShopClass")
                        .WithMany("Users")
                        .HasForeignKey("PetShopClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PetShopClass");
                });

            modelBuilder.Entity("PetShopLibrary.Transaction", b =>
                {
                    b.HasOne("PetShopLibrary.PetShopClass", "PetShopClass")
                        .WithMany("Transactions")
                        .HasForeignKey("PetShopClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PetShopClass");
                });

            modelBuilder.Entity("PetShopLibrary.PetShopClass", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Employees");

                    b.Navigation("PetFoods");

                    b.Navigation("Pets");

                    b.Navigation("Transactions");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}