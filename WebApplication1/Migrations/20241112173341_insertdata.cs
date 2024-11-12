using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class insertdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "catogreys",
                columns: new[] { "Id", "CreatedDate", "Name", "displayorder" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 11, 12, 22, 33, 41, 299, DateTimeKind.Local).AddTicks(2493), "Hp", 2 },
                    { 3, new DateTime(2024, 11, 12, 22, 33, 41, 299, DateTimeKind.Local).AddTicks(2517), "Apple", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catogreys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "catogreys",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
