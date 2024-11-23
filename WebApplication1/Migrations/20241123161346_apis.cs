using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class apis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCOvers_BookWriters_bookWritersId",
                table: "BookCOvers");

            migrationBuilder.AlterColumn<int>(
                name: "bookWritersId",
                table: "BookCOvers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bookWriterID",
                table: "BookCOvers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCOvers_BookWriters_bookWritersId",
                table: "BookCOvers",
                column: "bookWritersId",
                principalTable: "BookWriters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCOvers_BookWriters_bookWritersId",
                table: "BookCOvers");

            migrationBuilder.DropColumn(
                name: "bookWriterID",
                table: "BookCOvers");

            migrationBuilder.AlterColumn<int>(
                name: "bookWritersId",
                table: "BookCOvers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCOvers_BookWriters_bookWritersId",
                table: "BookCOvers",
                column: "bookWritersId",
                principalTable: "BookWriters",
                principalColumn: "Id");
        }
    }
}
