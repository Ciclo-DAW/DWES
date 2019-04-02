using Microsoft.EntityFrameworkCore.Migrations;

namespace JuguetylandiaWeb.Migrations
{
    public partial class PVPfloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PVP",
                table: "Juguetes",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PVP",
                table: "Juguetes",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
