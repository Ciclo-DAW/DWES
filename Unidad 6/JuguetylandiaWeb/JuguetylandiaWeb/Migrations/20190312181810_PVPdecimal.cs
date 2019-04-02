using Microsoft.EntityFrameworkCore.Migrations;

namespace JuguetylandiaWeb.Migrations
{
    public partial class PVPdecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PVP",
                table: "Juguetes",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PVP",
                table: "Juguetes",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
