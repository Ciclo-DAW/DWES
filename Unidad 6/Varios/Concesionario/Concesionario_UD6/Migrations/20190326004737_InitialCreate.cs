using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Concesionario_UD6.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concesionarios",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concesionarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(maxLength: 60, nullable: true),
                    Modelo = table.Column<string>(maxLength: 60, nullable: true),
                    TipoVehiculo = table.Column<int>(nullable: false),
                    Combustible = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    NumBastidor = table.Column<string>(nullable: true),
                    DataRecepcion = table.Column<DateTime>(nullable: true),
                    DataVenta = table.Column<DateTime>(nullable: true),
                    ConcesionarioId = table.Column<int>(nullable: false),
                    UbicacionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Concesionarios_ConcesionarioId",
                        column: x => x.ConcesionarioId,
                        principalTable: "Concesionarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Ubicaciones_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicaciones",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ConcesionarioId",
                table: "Vehiculos",
                column: "ConcesionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_UbicacionId",
                table: "Vehiculos",
                column: "UbicacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Concesionarios");

            migrationBuilder.DropTable(
                name: "Ubicaciones");
        }
    }
}
