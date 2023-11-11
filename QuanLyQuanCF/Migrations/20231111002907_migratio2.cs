using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyQuanCF.Migrations
{
    /// <inheritdoc />
    public partial class migratio2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IngredientOrders",
                columns: new[] { "IngredientID", "ProductID", "Amount", "Capacity", "IngredientOrderID" },
                values: new object[,]
                {
                    { 1, 1L, 1m, 1m, 1L },
                    { 1, 2L, 1m, 2m, 3L },
                    { 2, 1L, 1m, 2m, 2L },
                    { 2, 2L, 1m, 2m, 4L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientOrders",
                keyColumns: new[] { "IngredientID", "ProductID" },
                keyValues: new object[] { 1, 1L });

            migrationBuilder.DeleteData(
                table: "IngredientOrders",
                keyColumns: new[] { "IngredientID", "ProductID" },
                keyValues: new object[] { 1, 2L });

            migrationBuilder.DeleteData(
                table: "IngredientOrders",
                keyColumns: new[] { "IngredientID", "ProductID" },
                keyValues: new object[] { 2, 1L });

            migrationBuilder.DeleteData(
                table: "IngredientOrders",
                keyColumns: new[] { "IngredientID", "ProductID" },
                keyValues: new object[] { 2, 2L });
        }
    }
}
