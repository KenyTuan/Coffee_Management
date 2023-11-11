using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuanLyQuanCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyQuanCF
{
    internal class EFDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientOrder> IngredientOrders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }



        public void ConfigureServices(IServiceCollection services) => services.AddDbContext<EFDbContext>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=MSI\\MSSQLSERVER02;Database=DBCF1;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderID = 1,
                    CustomerID = 1,
                    EmployeeID = 0,
                    OrderDate = DateTime.Now,
                    OrderTime = DateTime.Now.TimeOfDay,
                    Total = 1000,
                });

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    IngredientID = 1,
                    IngredientName = "Hạt Cafe Trung Nguyên",
                    Amount = 1,
                    Status = true
                }
                );
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerID = 1,
                    NameCustomer = "Lê Hoàng Phúc",
                    Gender = false,
                    BirthDay = DateTime.Parse("2005-01-20"),
                    Address = "187-27 Đ. Tân Sơn Nhì, Tân Sơn Nhì, Tân Phú, Thành phố Hồ Chí Minh",
                    Phone = "0906994630",
                    Point = 0,
                    Status = true
                },
                new Customer
                {
                    CustomerID = 2,
                    NameCustomer = "Nguyễn Phương Thủy",
                    Gender = true,
                    BirthDay = DateTime.Parse("2004-06-15"),
                    Address = "A1 khu 82 Tô Ký, Q12, Quận 12, Thành phố Hồ Chí Minh, Việt Nam",
                    Phone = "0971439923",
                    Point = 0,
                    Status = true
                }, new Customer
                {
                    CustomerID = 3,
                    NameCustomer = "Đặng Chí Ninh",
                    Gender = false,
                    BirthDay = null,
                    Address = "Phường 7, Gò Vấp, Thành phố Hồ Chí Minh, Việt Nam",
                    Phone = "0839991612",
                    Point = 0,
                    Status = true
                }, new Customer
                {
                    CustomerID = 4,
                    NameCustomer = "Hồng Lê Thắng",
                    Gender = false,
                    BirthDay = DateTime.Parse("1999-11-01"),
                    Address = "57A Tháp Mười, Phường 2, Quận 6, Thành phố Hồ Chí Minh 700900, Việt Nam",
                    Phone = "0862887733",
                    Point = 0,
                    Status = true
                }, new Customer
                {
                    CustomerID = 5,
                    NameCustomer = "Võ Thị Nguyệt",
                    Gender = true,
                    BirthDay = DateTime.Parse("2000-06-01"),
                    Address = "Quang Trung, Phường 11, Gò Vấp, Thành phố Hồ Chí Minh, Việt Nam",
                    Phone = "0977357300",
                    Point = 0,
                    Status = true
                }
                );

           

            

            // Category
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1,CategoryName = "Coffee",Status = true},
                new Category { CategoryID = 2,CategoryName = "Milk Tea", Status = true }, 
                new Category { CategoryID = 3 , CategoryName = "Tea",Status = true}, 
                new Category { CategoryID = 4,CategoryName = "Ice Blended", Status = true },
                new Category { CategoryID = 5, CategoryName = "Soda", Status = true },
                new Category { CategoryID= 6,CategoryName = "Hot Drinks", Status = true },
                new Category { CategoryID = 7, CategoryName = "Food", Status = true }
                );

            // Product
            modelBuilder.Entity<Product>().HasData(
                new Product { 
                    ProductID = 1, 
                    ProductName = "Americano",
                    ProductSize = "S" ,
                    Quantity = 0, 
                    Price = 27.0M , 
                    ImageFile = "" ,
                    Status = true,
                    CategoryID = 1
                },
                new Product { ProductID = 2,
                    ProductName = "Americano",
                    ProductSize = "M",
                    Quantity = 0,
                    Price = 35.0M,
                    ImageFile = "",
                    Status = true,
                    CategoryID = 1 
                },
                new Product { ProductID = 3, ProductName = "Americano", ProductSize = "L", Quantity = 0, Price = 40.0M, ImageFile = "", Status = true, CategoryID = 1 },
                new Product {ProductID = 4, ProductName = "Blended Coffee", ProductSize = "S", Quantity = 0, Price = 29.0M, ImageFile = "", Status = true, CategoryID = 1 },
                new Product {ProductID = 5, ProductName = "Blended Coffee", ProductSize = "M", Quantity = 0, Price = 37.0M, ImageFile = "", Status = true, CategoryID = 1 },
                new Product {ProductID = 6, ProductName = "Blended Coffee", ProductSize = "L", Quantity = 0, Price = 42.0M, ImageFile = "", Status = true, CategoryID = 1 },
                new Product {ProductID = 7, ProductName = "Latte", ProductSize = "M", Quantity = 0, Price = 36.0M, ImageFile = "", Status = true, CategoryID = 1 },
                new Product {ProductID = 8, ProductName = "Latte", ProductSize = "L", Quantity = 0, Price = 40.0M, ImageFile = "", Status = true, CategoryID = 1 },
                new Product {ProductID = 9, ProductName = "Traditional Milk Tea", ProductSize = "S", Quantity = 0, Price = 27.0M, ImageFile = "", Status = true, CategoryID = 2 },
                new Product {ProductID = 10, ProductName = "Traditional Milk Tea", ProductSize = "M", Quantity = 0, Price = 35.0M, ImageFile = "", Status = true, CategoryID = 2 },
                new Product {ProductID = 11, ProductName = "Traditional Milk Tea", ProductSize = "L", Quantity = 0, Price = 40.0M, ImageFile = "", Status = true, CategoryID = 2 },
                new Product {ProductID = 12, ProductName = "Brown Sugar Pearl Milk Tea", ProductSize = "S", Quantity = 0, Price = 29.0M, ImageFile = "", Status = true, CategoryID = 2 },
                new Product {ProductID = 13, ProductName = "Brown Sugar Pearl Milk Tea", ProductSize = "M", Quantity = 0, Price = 37.0M, ImageFile = "", Status = true, CategoryID = 2 },
                new Product {ProductID = 14, ProductName = "Brown Sugar Pearl Milk Tea", ProductSize = "L", Quantity = 0, Price = 42.0M, ImageFile = "", Status = true, CategoryID = 2 },
                new Product {ProductID = 15, ProductName = "Black Tea", ProductSize = "S", Quantity = 0, Price = 30.0M, ImageFile = "", Status = true, CategoryID = 3 },
                new Product {ProductID = 16, ProductName = "Black Tea", ProductSize = "M", Quantity = 0, Price = 38.0M, ImageFile = "", Status = true, CategoryID = 3 },
                new Product {ProductID = 17, ProductName = "Black Tea", ProductSize = "L", Quantity = 0, Price = 43.0M, ImageFile = "", Status = true, CategoryID = 3 },
                new Product {ProductID = 18, ProductName = "Thai Tea", ProductSize = "S", Quantity = 0, Price = 29.0M, ImageFile = "", Status = true, CategoryID = 3 },  
                new Product {ProductID = 19, ProductName = "Thai Tea", ProductSize = "M", Quantity = 0, Price = 29.0M, ImageFile = "", Status = true, CategoryID = 3 },
                new Product {ProductID = 20, ProductName = "Thai Tea", ProductSize = "L", Quantity = 0, Price = 29.0M, ImageFile = "", Status = true, CategoryID = 3 }
                
                );

            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                EmployeeID = 1,
                EmployeeName = "Nguyễn Văn A",
                BirthDay = DateTime.Parse("1990-01-25"),
                Gender = false,
                Address = "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh",
                Phone = "0133456789",
                Email = "nguyenvana@gmail.com",
                Password = "111",
                RoleID = 1,
                Status = true

            },
            new Employee
            {
                EmployeeID = 2,
                EmployeeName = "Nguyễn Văn B",
                BirthDay = DateTime.Parse("1990-01-25"),
                Gender = false,
                Address = "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh",
                Phone = "0133456789",
                Email = "nguyenvanb@gmail.com",
                Password = "111",
                RoleID = 2,
                Status = true

            },
            new Employee
            {
                EmployeeID = 3,
                EmployeeName = "Nguyễn Văn C",
                BirthDay = DateTime.Parse("1990-01-25"),
                Gender = true,
                Address = "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh",
                Phone = "0133456789",
                Email = "nguyenvanc@gmail.com",
                Password = "111",
                RoleID = 3,
                Status = true
            });

            modelBuilder.Entity<OrderDetail>().HasKey("OrderDetailID");
            modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.OrderID, o.ProductID });

            modelBuilder.Entity<IngredientOrder>().HasKey("IngredientOrderID");
            modelBuilder.Entity<IngredientOrder>().HasKey(o => new { o.IngredientID, o.ProductID });
            modelBuilder.Entity<IngredientOrder>().HasData(
                new IngredientOrder
                {
                    IngredientOrderID = 1,
                    ProductID = 1,
                    IngredientID = 1,
                    Amount = 1,
                    Capacity = 1,
                },
                new IngredientOrder
                {
                    IngredientOrderID = 2,
                    ProductID = 1,
                    IngredientID = 2,
                    Amount = 1,
                    Capacity = 2,
                },
                new IngredientOrder
                {
                    IngredientOrderID = 3,
                    ProductID = 2,
                    IngredientID = 1,
                    Amount = 1,
                    Capacity = 2,
                },
                new IngredientOrder
                {
                    IngredientOrderID = 4,
                    ProductID = 2,
                    IngredientID = 2,
                    Amount = 1,
                    Capacity = 2,
                }
            );
        }
    }
}
