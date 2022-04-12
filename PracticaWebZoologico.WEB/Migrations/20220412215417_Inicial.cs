using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaWebZoologico.WEB.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColoresAnimales",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreColor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoresAnimales", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "EspeciesAnimales",
                columns: table => new
                {
                    EspecieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEspecie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspeciesAnimales", x => x.EspecieId);
                });

            migrationBuilder.CreateTable(
                name: "Animales",
                columns: table => new
                {
                    NombreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ColorAnimalColorId = table.Column<int>(type: "int", nullable: true),
                    EspecieId = table.Column<int>(type: "int", nullable: false),
                    EspecieAnimalEspecieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animales", x => x.NombreId);
                    table.ForeignKey(
                        name: "FK_Animales_ColoresAnimales_ColorAnimalColorId",
                        column: x => x.ColorAnimalColorId,
                        principalTable: "ColoresAnimales",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animales_EspeciesAnimales_EspecieAnimalEspecieId",
                        column: x => x.EspecieAnimalEspecieId,
                        principalTable: "EspeciesAnimales",
                        principalColumn: "EspecieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animales_ColorAnimalColorId",
                table: "Animales",
                column: "ColorAnimalColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Animales_EspecieAnimalEspecieId",
                table: "Animales",
                column: "EspecieAnimalEspecieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animales");

            migrationBuilder.DropTable(
                name: "ColoresAnimales");

            migrationBuilder.DropTable(
                name: "EspeciesAnimales");
        }
    }
}
