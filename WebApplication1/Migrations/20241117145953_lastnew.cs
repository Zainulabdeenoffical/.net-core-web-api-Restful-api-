using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class lastnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "catogreys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 19, 59, 53, 275, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "catogreys",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 19, 59, 53, 275, DateTimeKind.Local).AddTicks(5673));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "catogreys",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 19, 15, 33, 23, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "catogreys",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 17, 19, 15, 33, 23, DateTimeKind.Local).AddTicks(3384));
        }
    }
}
