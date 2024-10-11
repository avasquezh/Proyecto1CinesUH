using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto1CinesUH.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b01be40-52ed-44e2-a3ad-ae1a1d80a4e7", null, "admin", "admin" },
                    { "927c6697-b86c-4651-a9d4-cc8b04fc2c3c", null, "boletero", "boletero" },
                    { "c6ddbd81-1f95-4fb8-9062-5d97dcc71762", null, "cliente", "cliente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b01be40-52ed-44e2-a3ad-ae1a1d80a4e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "927c6697-b86c-4651-a9d4-cc8b04fc2c3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6ddbd81-1f95-4fb8-9062-5d97dcc71762");
        }
    }
}
