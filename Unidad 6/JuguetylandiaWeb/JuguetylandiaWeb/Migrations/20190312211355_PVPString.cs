using Microsoft.EntityFrameworkCore.Migrations;

namespace JuguetylandiaWeb.Migrations
{
    public partial class PVPString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PVP",
                table: "Juguetes",
                nullable: true,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PVP",
                table: "Juguetes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
