using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyQuanCF.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCustomer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "Date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductSize = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientOrders",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    IngredientID = table.Column<int>(type: "int", nullable: false),
                    IngredientOrderID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Capacity = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientOrders", x => new { x.IngredientID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_IngredientOrders_Ingredients_IngredientID",
                        column: x => x.IngredientID,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientOrders_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName", "Status" },
                values: new object[,]
                {
                    { 1L, "Coffee", true },
                    { 2L, "Milk Tea", true },
                    { 3L, "Tea", true },
                    { 4L, "Ice Blended", true },
                    { 5L, "Soda", true },
                    { 6L, "Hot Drinks", true },
                    { 7L, "Food", true }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "BirthDay", "Gender", "NameCustomer", "Phone", "Point", "Status" },
                values: new object[,]
                {
                    { 1L, "187-27 Đ. Tân Sơn Nhì, Tân Sơn Nhì, Tân Phú, Thành phố Hồ Chí Minh", new DateTime(2005, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lê Hoàng Phúc", "0906994630", 0, true },
                    { 2L, "A1 khu 82 Tô Ký, Q12, Quận 12, Thành phố Hồ Chí Minh, Việt Nam", new DateTime(2004, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Nguyễn Phương Thủy", "0971439923", 0, true },
                    { 3L, "Phường 7, Gò Vấp, Thành phố Hồ Chí Minh, Việt Nam", null, false, "Đặng Chí Ninh", "0839991612", 0, true },
                    { 4L, "57A Tháp Mười, Phường 2, Quận 6, Thành phố Hồ Chí Minh 700900, Việt Nam", new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hồng Lê Thắng", "0862887733", 0, true },
                    { 5L, "Quang Trung, Phường 11, Gò Vấp, Thành phố Hồ Chí Minh, Việt Nam", new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Võ Thị Nguyệt", "0977357300", 0, true }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientID", "Amount", "IngredientName", "Status" },
                values: new object[] { 1, 1m, "Hạt Cafe Trung Nguyên", true });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "ImageFile", "Price", "ProductName", "ProductSize", "Quantity", "Status" },
                values: new object[,]
                {
                    { 1L, 1L, "", 27.0m, "Americano", "S", 0, true },
                    { 2L, 1L, "", 35.0m, "Americano", "M", 0, true },
                    { 3L, 1L, "", 40.0m, "Americano", "L", 0, true },
                    { 4L, 1L, "", 29.0m, "Blended Coffee", "S", 0, true },
                    { 5L, 1L, "", 37.0m, "Blended Coffee", "M", 0, true },
                    { 6L, 1L, "", 42.0m, "Blended Coffee", "L", 0, true },
                    { 7L, 1L, "", 36.0m, "Latte", "M", 0, true },
                    { 8L, 1L, "", 40.0m, "Latte", "L", 0, true },
                    { 9L, 2L, "", 27.0m, "Traditional Milk Tea", "S", 0, true },
                    { 10L, 2L, "", 35.0m, "Traditional Milk Tea", "M", 0, true },
                    { 11L, 2L, "", 40.0m, "Traditional Milk Tea", "L", 0, true },
                    { 12L, 2L, "", 29.0m, "Brown Sugar Pearl Milk Tea", "S", 0, true },
                    { 13L, 2L, "", 37.0m, "Brown Sugar Pearl Milk Tea", "M", 0, true },
                    { 14L, 2L, "", 42.0m, "Brown Sugar Pearl Milk Tea", "L", 0, true },
                    { 15L, 3L, "", 30.0m, "Black Tea", "S", 0, true },
                    { 16L, 3L, "", 38.0m, "Black Tea", "M", 0, true },
                    { 17L, 3L, "", 43.0m, "Black Tea", "L", 0, true },
                    { 18L, 3L, "", 29.0m, "Thai Tea", "S", 0, true },
                    { 19L, 3L, "", 29.0m, "Thai Tea", "M", 0, true },
                    { 20L, 3L, "", 29.0m, "Thai Tea", "L", 0, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientOrders_ProductID",
                table: "IngredientOrders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "IngredientOrders");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
