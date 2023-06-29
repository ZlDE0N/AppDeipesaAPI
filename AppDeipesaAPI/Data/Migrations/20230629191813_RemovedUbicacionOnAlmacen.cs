using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDeipesaAPI.Data.Migrations
{
    public partial class RemovedUbicacionOnAlmacen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Almacen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Almacen",
                type: "varchar(120)",
                unicode: false,
                maxLength: 120,
                nullable: true);
        }
    }
}
