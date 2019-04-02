using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JuguetylandiaWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tiendas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiendas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Juguetes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 60, nullable: true),
                    Ean = table.Column<string>(nullable: true),
                    Referencia = table.Column<string>(nullable: true),
                    MarcaId = table.Column<int>(nullable: false),
                    PVP = table.Column<int>(nullable: false),
                    Oferta = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    FechaRecepcion = table.Column<DateTime>(nullable: true),
                    TiendaId = table.Column<int>(nullable: false),
                    FechaGarantia = table.Column<DateTime>(nullable: true),
                    InfoGarantia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juguetes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Juguetes_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Juguetes_Tiendas_TiendaId",
                        column: x => x.TiendaId,
                        principalTable: "Tiendas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Juguetes_MarcaId",
                table: "Juguetes",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Juguetes_TiendaId",
                table: "Juguetes",
                column: "TiendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Juguetes");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Tiendas");
        }
    }
}
