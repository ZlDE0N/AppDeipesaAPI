using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDeipesaAPI.Data.Migrations
{
    public partial class BaseSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Almacen",
                columns: table => new
                {
                    IdAlmacen = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NombreAlmacen = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Ubicacion = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Capacidad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdAlmacen", x => x.IdAlmacen);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Cedula = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nombres = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Apellidos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdCliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Materiales",
                columns: table => new
                {
                    IdMaterial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NombreMaterial = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UnidadDeMedida = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Marca = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PVU = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdMaterial", x => x.IdMaterial);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Idproveedor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NombreProveedor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(180)", unicode: false, maxLength: 180, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Correo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdproveedor", x => x.Idproveedor);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagos",
                columns: table => new
                {
                    IdTipoPagos = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TipoPago = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdTipoPagos", x => x.IdTipoPagos);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    IdFactura = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IdCliente = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FechaFactura = table.Column<DateTime>(type: "datetime", nullable: true),
                    Impuesto = table.Column<double>(type: "float", nullable: true),
                    Descuento = table.Column<double>(type: "float", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdFactura", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente");
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    IdInventario = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IdAlmacen = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdMaterial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Cantidad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TipoInventario = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    StockMinimo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdInventario", x => x.IdInventario);
                    table.ForeignKey(
                        name: "FK_IdAlmacen",
                        column: x => x.IdAlmacen,
                        principalTable: "Almacen",
                        principalColumn: "IdAlmacen");
                    table.ForeignKey(
                        name: "FK_IdMaterial1",
                        column: x => x.IdMaterial,
                        principalTable: "Materiales",
                        principalColumn: "IdMaterial");
                });

            migrationBuilder.CreateTable(
                name: "OrdenCompra",
                columns: table => new
                {
                    IdOrdenCompra = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Idproveedor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FechaOrdenCompra = table.Column<DateTime>(type: "datetime", nullable: true),
                    Impuesto = table.Column<double>(type: "float", nullable: true),
                    Descuento = table.Column<double>(type: "float", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdOrdenCompra", x => x.IdOrdenCompra);
                    table.ForeignKey(
                        name: "FK_Idproveedor",
                        column: x => x.Idproveedor,
                        principalTable: "Proveedor",
                        principalColumn: "Idproveedor");
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdPago = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IdCliente = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTipoPagos = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FechaPago = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    Monto = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdPago", x => x.IdPago);
                    table.ForeignKey(
                        name: "FKIdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FKIdTipoPagos",
                        column: x => x.IdTipoPagos,
                        principalTable: "TipoPagos",
                        principalColumn: "IdTipoPagos");
                });

            migrationBuilder.CreateTable(
                name: "DetalleFactura",
                columns: table => new
                {
                    IdDetalleFactura = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IdFactura = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdMaterial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Cantidad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SubTotal = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdDetalleFactura", x => x.IdDetalleFactura);
                    table.ForeignKey(
                        name: "FK_IdFactura",
                        column: x => x.IdFactura,
                        principalTable: "Factura",
                        principalColumn: "IdFactura");
                    table.ForeignKey(
                        name: "FK_IdMaterial",
                        column: x => x.IdMaterial,
                        principalTable: "Materiales",
                        principalColumn: "IdMaterial");
                });

            migrationBuilder.CreateTable(
                name: "DetalleOrdenCompra",
                columns: table => new
                {
                    IdDetalleOrdenCompra = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    IdOrdenCompra = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdMaterial = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FechaFabricacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    Cantidad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PVU = table.Column<double>(type: "float", nullable: true),
                    SubTotal = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKIdDetalleOrdenCompra", x => x.IdDetalleOrdenCompra);
                    table.ForeignKey(
                        name: "FK_IdMaterial2",
                        column: x => x.IdMaterial,
                        principalTable: "Materiales",
                        principalColumn: "IdMaterial");
                    table.ForeignKey(
                        name: "FK_IdOrdenCompra",
                        column: x => x.IdOrdenCompra,
                        principalTable: "OrdenCompra",
                        principalColumn: "IdOrdenCompra");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFactura_IdFactura",
                table: "DetalleFactura",
                column: "IdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFactura_IdMaterial",
                table: "DetalleFactura",
                column: "IdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrdenCompra_IdMaterial",
                table: "DetalleOrdenCompra",
                column: "IdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrdenCompra_IdOrdenCompra",
                table: "DetalleOrdenCompra",
                column: "IdOrdenCompra");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdCliente",
                table: "Factura",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_IdAlmacen",
                table: "Inventario",
                column: "IdAlmacen");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_IdMaterial",
                table: "Inventario",
                column: "IdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenCompra_Idproveedor",
                table: "OrdenCompra",
                column: "Idproveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdCliente",
                table: "Pagos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdTipoPagos",
                table: "Pagos",
                column: "IdTipoPagos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleFactura");

            migrationBuilder.DropTable(
                name: "DetalleOrdenCompra");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "OrdenCompra");

            migrationBuilder.DropTable(
                name: "Almacen");

            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "TipoPagos");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Proveedor");
        }
    }
}
