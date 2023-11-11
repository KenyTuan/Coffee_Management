using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyQuanCF.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CustomerID", "EmployeeID", "OrderDate", "OrderTime", "Total" },
                values: new object[] { 1L, 1L, 1L, new DateTime(2023, 11, 11, 17, 14, 48, 297, DateTimeKind.Local).AddTicks(8566), new TimeSpan(620882978581), 1000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1L);
        }
    }
}
