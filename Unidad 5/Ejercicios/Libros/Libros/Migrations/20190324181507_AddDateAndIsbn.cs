using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libros.Migrations
{
    public partial class AddDateAndIsbn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicacion",
                table: "Libros",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Libros",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaPublicacion",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Libros");
        }
    }
}
