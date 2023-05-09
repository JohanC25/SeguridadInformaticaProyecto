using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeguridadInformaticaProyecto.Migrations
{
    public partial class CambiosBdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subcat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    confidencialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    integridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activo");
        }
    }
}
