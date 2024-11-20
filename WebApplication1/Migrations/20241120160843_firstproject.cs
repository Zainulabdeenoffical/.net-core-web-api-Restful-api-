using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class firstproject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "catogreys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "catogreys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "BookWriters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookWriters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookCOvers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bookWritersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCOvers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCOvers_BookWriters_bookWritersId",
                        column: x => x.bookWritersId,
                        principalTable: "BookWriters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISBNNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookCoverID = table.Column<int>(type: "int", nullable: false),
                    bookWriterID = table.Column<int>(type: "int", nullable: false),
                    BookWritersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookCOvers_BookCoverID",
                        column: x => x.BookCoverID,
                        principalTable: "BookCOvers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_BookWriters_BookWritersId",
                        column: x => x.BookWritersId,
                        principalTable: "BookWriters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCOvers_bookWritersId",
                table: "BookCOvers",
                column: "bookWritersId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCoverID",
                table: "Books",
                column: "BookCoverID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookWritersId",
                table: "Books",
                column: "BookWritersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BookCOvers");

            migrationBuilder.DropTable(
                name: "BookWriters");

            migrationBuilder.InsertData(
                table: "catogreys",
                columns: new[] { "Id", "CreatedDate", "Name", "displayorder" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 11, 17, 19, 59, 53, 275, DateTimeKind.Local).AddTicks(5660), "Hp", 2 },
                    { 3, new DateTime(2024, 11, 17, 19, 59, 53, 275, DateTimeKind.Local).AddTicks(5673), "Apple", 3 }
                });
        }
    }
}
