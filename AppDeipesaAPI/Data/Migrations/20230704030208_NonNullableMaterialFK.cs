using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDeipesaAPI.Data.Migrations
{
    public partial class NonNullableMaterialFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdMaterial",
                table: "DetalleFactura");

            migrationBuilder.DropForeignKey(
                name: "FK_IdMaterial2",
                table: "DetalleOrdenCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_IdMaterial1",
                table: "Inventario");

            migrationBuilder.AlterColumn<string>(
                name: "IdMaterial",
                table: "Inventario",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdMaterial",
                table: "DetalleOrdenCompra",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdMaterial",
                table: "DetalleFactura",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IdMaterial",
                table: "DetalleFactura",
                column: "IdMaterial",
                principalTable: "Materiales",
                principalColumn: "IdMaterial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdMaterial2",
                table: "DetalleOrdenCompra",
                column: "IdMaterial",
                principalTable: "Materiales",
                principalColumn: "IdMaterial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdMaterial1",
                table: "Inventario",
                column: "IdMaterial",
                principalTable: "Materiales",
                principalColumn: "IdMaterial",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdMaterial",
                table: "DetalleFactura");

            migrationBuilder.DropForeignKey(
                name: "FK_IdMaterial2",
                table: "DetalleOrdenCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_IdMaterial1",
                table: "Inventario");

            migrationBuilder.AlterColumn<string>(
                name: "IdMaterial",
                table: "Inventario",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "IdMaterial",
                table: "DetalleOrdenCompra",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "IdMaterial",
                table: "DetalleFactura",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AddForeignKey(
                name: "FK_IdMaterial",
                table: "DetalleFactura",
                column: "IdMaterial",
                principalTable: "Materiales",
                principalColumn: "IdMaterial");

            migrationBuilder.AddForeignKey(
                name: "FK_IdMaterial2",
                table: "DetalleOrdenCompra",
                column: "IdMaterial",
                principalTable: "Materiales",
                principalColumn: "IdMaterial");

            migrationBuilder.AddForeignKey(
                name: "FK_IdMaterial1",
                table: "Inventario",
                column: "IdMaterial",
                principalTable: "Materiales",
                principalColumn: "IdMaterial");
        }
    }
}
