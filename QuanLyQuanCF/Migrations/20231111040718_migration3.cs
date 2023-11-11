using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyQuanCF.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "Date", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Phone = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    RoleID = table.Column<byte>(type: "tinyint", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Address", "BirthDay", "Email", "EmployeeName", "Gender", "Password", "Phone", "RoleID", "Status" },
                values: new object[,]
                {
                    { 1L, "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh", new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenvana@gmail.com", "Nguyễn Văn A", false, "111", "0133456789", (byte)1, true },
                    { 2L, "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh", new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenvanb@gmail.com", "Nguyễn Văn B", false, "111", "0133456789", (byte)2, true },
                    { 3L, "11A Lý Bí, P5, Q1, TP. Hồ Chí Minh", new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenvanc@gmail.com", "Nguyễn Văn C", true, "111", "0133456789", (byte)3, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
