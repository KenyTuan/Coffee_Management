﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyQuanCF;

#nullable disable

namespace QuanLyQuanCF.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20231111081355_migration2")]
    partial class migration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyQuanCF.Models.Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1L,
                            CategoryName = "Coffee",
                            Status = true
                        },
                        new
                        {
                            CategoryID = 2L,
                            CategoryName = "Milk Tea",
                            Status = true
                        },
                        new
                        {
                            CategoryID = 3L,
                            CategoryName = "Tea",
                            Status = true
                        },
                        new
                        {
                            CategoryID = 4L,
                            CategoryName = "Ice Blended",
                            Status = true
                        },
                        new
                        {
                            CategoryID = 5L,
                            CategoryName = "Soda",
                            Status = true
                        },
                        new
                        {
                            CategoryID = 6L,
                            CategoryName = "Hot Drinks",
                            Status = true
                        },
                        new
                        {
                            CategoryID = 7L,
                            CategoryName = "Food",
                            Status = true
                        });
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Customer", b =>
                {
                    b.Property<long>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("Date");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("NameCustomer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1L,
                            Address = "187-27 Đ. Tân Sơn Nhì, Tân Sơn Nhì, Tân Phú, Thành phố Hồ Chí Minh",
                            BirthDay = new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            NameCustomer = "Lê Hoàng Phúc",
                            Phone = "0906994630",
                            Point = 0,
                            Status = true
                        },
                        new
                        {
                            CustomerID = 2L,
                            Address = "A1 khu 82 Tô Ký, Q12, Quận 12, Thành phố Hồ Chí Minh, Việt Nam",
                            BirthDay = new DateTime(2004, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            NameCustomer = "Nguyễn Phương Thủy",
                            Phone = "0971439923",
                            Point = 0,
                            Status = true
                        },
                        new
                        {
                            CustomerID = 3L,
                            Address = "Phường 7, Gò Vấp, Thành phố Hồ Chí Minh, Việt Nam",
                            Gender = false,
                            NameCustomer = "Đặng Chí Ninh",
                            Phone = "0839991612",
                            Point = 0,
                            Status = true
                        },
                        new
                        {
                            CustomerID = 4L,
                            Address = "57A Tháp Mười, Phường 2, Quận 6, Thành phố Hồ Chí Minh 700900, Việt Nam",
                            BirthDay = new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = false,
                            NameCustomer = "Hồng Lê Thắng",
                            Phone = "0862887733",
                            Point = 0,
                            Status = true
                        },
                        new
                        {
                            CustomerID = 5L,
                            Address = "Quang Trung, Phường 11, Gò Vấp, Thành phố Hồ Chí Minh, Việt Nam",
                            BirthDay = new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = true,
                            NameCustomer = "Võ Thị Nguyệt",
                            Phone = "0977357300",
                            Point = 0,
                            Status = true
                        });
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmployeeID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)");

                    b.Property<byte>("RoleID")
                        .HasColumnType("tinyint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1L,
                            Address = "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nguyenvana@gmail.com",
                            EmployeeName = "Nguyễn Văn A",
                            Gender = false,
                            Password = "111",
                            Phone = "0133456789",
                            RoleID = (byte)1,
                            Status = true
                        },
                        new
                        {
                            EmployeeID = 2L,
                            Address = "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nguyenvanb@gmail.com",
                            EmployeeName = "Nguyễn Văn B",
                            Gender = false,
                            Password = "111",
                            Phone = "0133456789",
                            RoleID = (byte)2,
                            Status = true
                        },
                        new
                        {
                            EmployeeID = 3L,
                            Address = "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nguyenvanc@gmail.com",
                            EmployeeName = "Nguyễn Văn C",
                            Gender = true,
                            Password = "111",
                            Phone = "0133456789",
                            RoleID = (byte)3,
                            Status = true
                        });
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("IngredientID");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientID = 1,
                            Amount = 1m,
                            IngredientName = "Hạt Cafe Trung Nguyên",
                            Status = true
                        });
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.IngredientOrder", b =>
                {
                    b.Property<int>("IngredientID")
                        .HasColumnType("int");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Capacity")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<long>("IngredientOrderID")
                        .HasColumnType("bigint");

                    b.HasKey("IngredientID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("IngredientOrders");

                    b.HasData(
                        new
                        {
                            IngredientID = 1,
                            ProductID = 1L,
                            Amount = 1m,
                            Capacity = 1m,
                            IngredientOrderID = 1L
                        },
                        new
                        {
                            IngredientID = 2,
                            ProductID = 1L,
                            Amount = 1m,
                            Capacity = 2m,
                            IngredientOrderID = 2L
                        },
                        new
                        {
                            IngredientID = 1,
                            ProductID = 2L,
                            Amount = 1m,
                            Capacity = 2m,
                            IngredientOrderID = 3L
                        },
                        new
                        {
                            IngredientID = 2,
                            ProductID = 2L,
                            Amount = 1m,
                            Capacity = 2m,
                            IngredientOrderID = 4L
                        });
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("OrderID"));

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint");

                    b.Property<long>("EmployeeID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("OrderTime")
                        .HasColumnType("time");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.OrderDetail", b =>
                {
                    b.Property<long>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<long>("OrderDetailID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductID"));

                    b.Property<long>("CategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("ImageFile")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ProductSize")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductID = 1L,
                            CategoryID = 1L,
                            ImageFile = "",
                            Price = 27.0m,
                            ProductName = "Americano",
                            ProductSize = "S",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 2L,
                            CategoryID = 1L,
                            ImageFile = "",
                            Price = 35.0m,
                            ProductName = "Americano",
                            ProductSize = "M",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 3L,
                            CategoryID = 1L,
                            ImageFile = "",
                            Price = 40.0m,
                            ProductName = "Americano",
                            ProductSize = "L",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 4L,
                            CategoryID = 1L,
                            ImageFile = "",
                            Price = 29.0m,
                            ProductName = "Blended Coffee",
                            ProductSize = "S",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 5L,
                            CategoryID = 1L,
                            ImageFile = "",
                            Price = 37.0m,
                            ProductName = "Blended Coffee",
                            ProductSize = "M",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 6L,
                            CategoryID = 1L,
                            ImageFile = "",
                            Price = 42.0m,
                            ProductName = "Blended Coffee",
                            ProductSize = "L",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 7L,
                            CategoryID = 1L,
                            ImageFile = "",
                            Price = 36.0m,
                            ProductName = "Latte",
                            ProductSize = "M",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 8L,
                            CategoryID = 1L,
                            ImageFile = "",
                            Price = 40.0m,
                            ProductName = "Latte",
                            ProductSize = "L",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 9L,
                            CategoryID = 2L,
                            ImageFile = "",
                            Price = 27.0m,
                            ProductName = "Traditional Milk Tea",
                            ProductSize = "S",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 10L,
                            CategoryID = 2L,
                            ImageFile = "",
                            Price = 35.0m,
                            ProductName = "Traditional Milk Tea",
                            ProductSize = "M",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 11L,
                            CategoryID = 2L,
                            ImageFile = "",
                            Price = 40.0m,
                            ProductName = "Traditional Milk Tea",
                            ProductSize = "L",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 12L,
                            CategoryID = 2L,
                            ImageFile = "",
                            Price = 29.0m,
                            ProductName = "Brown Sugar Pearl Milk Tea",
                            ProductSize = "S",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 13L,
                            CategoryID = 2L,
                            ImageFile = "",
                            Price = 37.0m,
                            ProductName = "Brown Sugar Pearl Milk Tea",
                            ProductSize = "M",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 14L,
                            CategoryID = 2L,
                            ImageFile = "",
                            Price = 42.0m,
                            ProductName = "Brown Sugar Pearl Milk Tea",
                            ProductSize = "L",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 15L,
                            CategoryID = 3L,
                            ImageFile = "",
                            Price = 30.0m,
                            ProductName = "Black Tea",
                            ProductSize = "S",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 16L,
                            CategoryID = 3L,
                            ImageFile = "",
                            Price = 38.0m,
                            ProductName = "Black Tea",
                            ProductSize = "M",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 17L,
                            CategoryID = 3L,
                            ImageFile = "",
                            Price = 43.0m,
                            ProductName = "Black Tea",
                            ProductSize = "L",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 18L,
                            CategoryID = 3L,
                            ImageFile = "",
                            Price = 29.0m,
                            ProductName = "Thai Tea",
                            ProductSize = "S",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 19L,
                            CategoryID = 3L,
                            ImageFile = "",
                            Price = 29.0m,
                            ProductName = "Thai Tea",
                            ProductSize = "M",
                            Quantity = 0,
                            Status = true
                        },
                        new
                        {
                            ProductID = 20L,
                            CategoryID = 3L,
                            ImageFile = "",
                            Price = 29.0m,
                            ProductName = "Thai Tea",
                            ProductSize = "L",
                            Quantity = 0,
                            Status = true
                        });
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.IngredientOrder", b =>
                {
                    b.HasOne("QuanLyQuanCF.Models.Ingredient", "Ingredient")
                        .WithMany("IngredientOrders")
                        .HasForeignKey("IngredientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyQuanCF.Models.Product", "Product")
                        .WithMany("IngredientOrders")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Order", b =>
                {
                    b.HasOne("QuanLyQuanCF.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyQuanCF.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.OrderDetail", b =>
                {
                    b.HasOne("QuanLyQuanCF.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyQuanCF.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Product", b =>
                {
                    b.HasOne("QuanLyQuanCF.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Ingredient", b =>
                {
                    b.Navigation("IngredientOrders");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("QuanLyQuanCF.Models.Product", b =>
                {
                    b.Navigation("IngredientOrders");

                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
