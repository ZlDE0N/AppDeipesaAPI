using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDeipesaAPI.Data.Migrations
{
    public partial class IdClienteNullability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdCliente",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FKIdCliente",
                table: "Pagos");

            migrationBuilder.AlterColumn<string>(
                name: "IdCliente",
                table: "Pagos",
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
                name: "IdCliente",
                table: "Factura",
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
                name: "FK_IdCliente",
                table: "Factura",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKIdCliente",
                table: "Pagos",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdCliente",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FKIdCliente",
                table: "Pagos");

            migrationBuilder.AlterColumn<string>(
                name: "IdCliente",
                table: "Pagos",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "IdCliente",
                table: "Factura",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AddForeignKey(
                name: "FK_IdCliente",
                table: "Factura",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FKIdCliente",
                table: "Pagos",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente");
        }
    }
}
