using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class Modificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Consolas_ConsolaId",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Perifericos_Consolas_ConsolaId",
                table: "Perifericos");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Perifericos");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Consolas");

            migrationBuilder.RenameColumn(
                name: "ConsolaId",
                table: "Perifericos",
                newName: "TiendaId");

            migrationBuilder.RenameIndex(
                name: "IX_Perifericos_ConsolaId",
                table: "Perifericos",
                newName: "IX_Perifericos_TiendaId");

            migrationBuilder.RenameColumn(
                name: "ConsolaId",
                table: "Juegos",
                newName: "TiendaId");

            migrationBuilder.RenameIndex(
                name: "IX_Juegos_ConsolaId",
                table: "Juegos",
                newName: "IX_Juegos_TiendaId");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Perifericos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Modelo",
                table: "Juegos",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Consolas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TiendaId",
                table: "Consolas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tienda",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Direccion = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tienda", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perifericos_MarcaId",
                table: "Perifericos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Consolas_MarcaId",
                table: "Consolas",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Consolas_TiendaId",
                table: "Consolas",
                column: "TiendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consolas_Marca_MarcaId",
                table: "Consolas",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consolas_Tienda_TiendaId",
                table: "Consolas",
                column: "TiendaId",
                principalTable: "Tienda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Tienda_TiendaId",
                table: "Juegos",
                column: "TiendaId",
                principalTable: "Tienda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perifericos_Marca_MarcaId",
                table: "Perifericos",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perifericos_Tienda_TiendaId",
                table: "Perifericos",
                column: "TiendaId",
                principalTable: "Tienda",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consolas_Marca_MarcaId",
                table: "Consolas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consolas_Tienda_TiendaId",
                table: "Consolas");

            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Tienda_TiendaId",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Perifericos_Marca_MarcaId",
                table: "Perifericos");

            migrationBuilder.DropForeignKey(
                name: "FK_Perifericos_Tienda_TiendaId",
                table: "Perifericos");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Tienda");

            migrationBuilder.DropIndex(
                name: "IX_Perifericos_MarcaId",
                table: "Perifericos");

            migrationBuilder.DropIndex(
                name: "IX_Consolas_MarcaId",
                table: "Consolas");

            migrationBuilder.DropIndex(
                name: "IX_Consolas_TiendaId",
                table: "Consolas");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Perifericos");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Consolas");

            migrationBuilder.DropColumn(
                name: "TiendaId",
                table: "Consolas");

            migrationBuilder.RenameColumn(
                name: "TiendaId",
                table: "Perifericos",
                newName: "ConsolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Perifericos_TiendaId",
                table: "Perifericos",
                newName: "IX_Perifericos_ConsolaId");

            migrationBuilder.RenameColumn(
                name: "TiendaId",
                table: "Juegos",
                newName: "ConsolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Juegos_TiendaId",
                table: "Juegos",
                newName: "IX_Juegos_ConsolaId");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Perifericos",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Consolas",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Consolas_ConsolaId",
                table: "Juegos",
                column: "ConsolaId",
                principalTable: "Consolas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perifericos_Consolas_ConsolaId",
                table: "Perifericos",
                column: "ConsolaId",
                principalTable: "Consolas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
