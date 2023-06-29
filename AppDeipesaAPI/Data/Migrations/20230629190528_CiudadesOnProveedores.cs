using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDeipesaAPI.Data.Migrations
{
    public partial class CiudadesOnProveedores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CiudadId",
                table: "Proveedor",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_CiudadId",
                table: "Proveedor",
                column: "CiudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedor_Ciudades_CiudadId",
                table: "Proveedor",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedor_Ciudades_CiudadId",
                table: "Proveedor");

            migrationBuilder.DropIndex(
                name: "IX_Proveedor_CiudadId",
                table: "Proveedor");

            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "Proveedor");
        }
    }
}
