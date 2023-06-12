using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeguridadInformaticaProyecto.Migrations
{
    public partial class CmabiosBDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "Activo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "clas_conf",
                table: "Activo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "clas_disp",
                table: "Activo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "clas_int",
                table: "Activo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "departamento",
                table: "Activo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "evaluacion",
                table: "Activo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "Activo");

            migrationBuilder.DropColumn(
                name: "clas_conf",
                table: "Activo");

            migrationBuilder.DropColumn(
                name: "clas_disp",
                table: "Activo");

            migrationBuilder.DropColumn(
                name: "clas_int",
                table: "Activo");

            migrationBuilder.DropColumn(
                name: "departamento",
                table: "Activo");

            migrationBuilder.DropColumn(
                name: "evaluacion",
                table: "Activo");
        }
    }
}
