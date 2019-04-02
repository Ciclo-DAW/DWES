using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consolas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(maxLength: 50, nullable: true),
                    Modelo = table.Column<string>(maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<float>(nullable: false),
                    FechaSalida = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consolas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<float>(nullable: false),
                    FechaSalida = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    Genero = table.Column<int>(nullable: false),
                    ConsolaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Juegos_Consolas_ConsolaId",
                        column: x => x.ConsolaId,
                        principalTable: "Consolas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Perifericos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(maxLength: 50, nullable: true),
                    Modelo = table.Column<string>(maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<float>(nullable: false),
                    FechaSalida = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    ConsolaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perifericos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Perifericos_Consolas_ConsolaId",
                        column: x => x.ConsolaId,
                        principalTable: "Consolas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_ConsolaId",
                table: "Juegos",
                column: "ConsolaId");

            migrationBuilder.CreateIndex(
                name: "IX_Perifericos_ConsolaId",
                table: "Perifericos",
                column: "ConsolaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Juegos");

            migrationBuilder.DropTable(
                name: "Perifericos");

            migrationBuilder.DropTable(
                name: "Consolas");
        }
    }
}
