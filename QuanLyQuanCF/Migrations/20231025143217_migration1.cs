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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
