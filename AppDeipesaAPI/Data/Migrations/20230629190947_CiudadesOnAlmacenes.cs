using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDeipesaAPI.Data.Migrations
{
    public partial class CiudadesOnAlmacenes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CiudadId",
                table: "Almacen",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Almacen_CiudadId",
                table: "Almacen",
                column: "CiudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Almacen_Ciudades_CiudadId",
                table: "Almacen",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Almacen_Ciudades_CiudadId",
                table: "Almacen");

            migrationBuilder.DropIndex(
                name: "IX_Almacen_CiudadId",
                table: "Almacen");

            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "Almacen");
        }
    }
}
