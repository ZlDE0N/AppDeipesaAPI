﻿// <auto-generated />
using System;
using AppDeipesaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppDeipesaAPI.Data.Migrations
{
    [DbContext(typeof(InventarioDeipesaContext))]
    partial class InventarioDeipesaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppDeipesaAPI.Models.Almacen", b =>
                {
                    b.Property<string>("IdAlmacen")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Capacidad")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<long>("CiudadId")
                        .HasColumnType("bigint");

                    b.Property<string>("NombreAlmacen")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("IdAlmacen")
                        .HasName("PKIdAlmacen");

                    b.HasIndex("CiudadId");

                    b.ToTable("Almacen", (string)null);
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Ciudad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Cliente", b =>
                {
                    b.Property<string>("IdCliente")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Apellidos")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cedula")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<long>("CiudadId")
                        .HasColumnType("bigint");

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nombres")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdCliente")
                        .HasName("PKIdCliente");

                    b.HasIndex("CiudadId");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Contrato", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ClienteId")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("DATE");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreAcordado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.DatosCliente", b =>
                {
                    b.Property<string>("Cedula")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("NombreCompleto")
                        .HasMaxLength(101)
                        .IsUnicode(false)
                        .HasColumnType("varchar(101)")
                        .HasColumnName("Nombre Completo");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.ToView("DatosClientes");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.DatosMateriale", b =>
                {
                    b.Property<string>("Descripcion")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("IdMaterial")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Marca")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NombreMaterial")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<double?>("Pvu")
                        .HasColumnType("float")
                        .HasColumnName("PVU");

                    b.Property<string>("UnidadDeMedida")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.ToView("DatosMateriales");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.DetalleFactura", b =>
                {
                    b.Property<string>("IdDetalleFactura")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cantidad")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("IdFactura")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdMaterial")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<double?>("SubTotal")
                        .HasColumnType("float");

                    b.HasKey("IdDetalleFactura")
                        .HasName("PKIdDetalleFactura");

                    b.HasIndex("IdFactura");

                    b.HasIndex("IdMaterial");

                    b.ToTable("DetalleFactura", (string)null);
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.DetalleOrdenCompra", b =>
                {
                    b.Property<string>("IdDetalleOrdenCompra")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cantidad")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("FechaFabricacion")
                        .HasColumnType("datetime");

                    b.Property<string>("IdMaterial")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdOrdenCompra")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<double?>("Pvu")
                        .HasColumnType("float")
                        .HasColumnName("PVU");

                    b.Property<double?>("SubTotal")
                        .HasColumnType("float");

                    b.HasKey("IdDetalleOrdenCompra")
                        .HasName("PKIdDetalleOrdenCompra");

                    b.HasIndex("IdMaterial");

                    b.HasIndex("IdOrdenCompra");

                    b.ToTable("DetalleOrdenCompra", (string)null);
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Factura", b =>
                {
                    b.Property<string>("IdFactura")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<double?>("Descuento")
                        .HasColumnType("float");

                    b.Property<DateTime?>("FechaFactura")
                        .HasColumnType("datetime");

                    b.Property<string>("IdCliente")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<double?>("Impuesto")
                        .HasColumnType("float");

                    b.Property<double?>("Total")
                        .HasColumnType("float");

                    b.HasKey("IdFactura")
                        .HasName("PKIdFactura");

                    b.HasIndex("IdCliente");

                    b.ToTable("Factura", (string)null);
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.InfoAlmacen", b =>
                {
                    b.Property<string>("Capacidad")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdAlmacen")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NombreAlmacen")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.ToView("infoAlmacen");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.InfoFactura", b =>
                {
                    b.Property<string>("Cantidad")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<double?>("Impuesto")
                        .HasColumnType("float");

                    b.Property<string>("Material")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nombres")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<double?>("Pvu")
                        .HasColumnType("float")
                        .HasColumnName("PVU");

                    b.Property<double?>("SubTotal")
                        .HasColumnType("float");

                    b.Property<double?>("Total")
                        .HasColumnType("float");

                    b.ToView("infoFacturas");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.InfOrdenCompra", b =>
                {
                    b.Property<string>("Cantidad")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<double?>("Descuento")
                        .HasColumnType("float");

                    b.Property<double?>("Impuesto")
                        .HasColumnType("float");

                    b.Property<string>("Proveedor")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<double?>("Pvu")
                        .HasColumnType("float")
                        .HasColumnName("PVU");

                    b.Property<double?>("Total")
                        .HasColumnType("float");

                    b.ToView("infOrdenCompra");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Inventario", b =>
                {
                    b.Property<string>("IdInventario")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cantidad")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("IdAlmacen")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdMaterial")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("StockMinimo")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("TipoInventario")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.HasKey("IdInventario")
                        .HasName("PKIdInventario");

                    b.HasIndex("IdAlmacen");

                    b.HasIndex("IdMaterial");

                    b.ToTable("Inventario", (string)null);
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Materiale", b =>
                {
                    b.Property<string>("IdMaterial")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Marca")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NombreMaterial")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<double?>("Pvu")
                        .HasColumnType("float")
                        .HasColumnName("PVU");

                    b.Property<string>("UnidadDeMedida")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("IdMaterial")
                        .HasName("PKIdMaterial");

                    b.ToTable("Materiales");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.MaterialesCemex", b =>
                {
                    b.Property<string>("Descripcion")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("IdMaterial")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Marca")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NombreMaterial")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<double?>("Pvu")
                        .HasColumnType("float")
                        .HasColumnName("PVU");

                    b.Property<string>("UnidadDeMedida")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.ToView("MaterialesCemex");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.MaterialesInventario", b =>
                {
                    b.Property<string>("Cantidad")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Material")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("StockMinimo")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("TipoInventario")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.ToView("MaterialesInventario");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.OrdenCompra", b =>
                {
                    b.Property<string>("IdOrdenCompra")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<double?>("Descuento")
                        .HasColumnType("float");

                    b.Property<DateTime?>("FechaOrdenCompra")
                        .HasColumnType("datetime");

                    b.Property<string>("Idproveedor")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<double?>("Impuesto")
                        .HasColumnType("float");

                    b.Property<double?>("Total")
                        .HasColumnType("float");

                    b.HasKey("IdOrdenCompra")
                        .HasName("PKIdOrdenCompra");

                    b.HasIndex("Idproveedor");

                    b.ToTable("OrdenCompra", (string)null);
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Pago", b =>
                {
                    b.Property<string>("IdPago")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("FechaPago")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("IdCliente")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdTipoPagos")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<double?>("Monto")
                        .HasColumnType("float");

                    b.HasKey("IdPago")
                        .HasName("PKIdPago");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdTipoPagos");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Proforma", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CiudadId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Proformas");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Proveedor", b =>
                {
                    b.Property<string>("Idproveedor")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<long>("CiudadId")
                        .HasColumnType("bigint");

                    b.Property<string>("Correo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(180)
                        .IsUnicode(false)
                        .HasColumnType("varchar(180)");

                    b.Property<string>("NombreProveedor")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Idproveedor")
                        .HasName("PKIdproveedor");

                    b.HasIndex("CiudadId");

                    b.ToTable("Proveedor", (string)null);
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.TipoPago", b =>
                {
                    b.Property<string>("IdTipoPagos")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("TipoPago1")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("TipoPago");

                    b.HasKey("IdTipoPagos")
                        .HasName("PKIdTipoPagos");

                    b.ToTable("TipoPagos");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.TipoPagoss", b =>
                {
                    b.Property<string>("Descripcion")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("IdTipoPagos")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TipoPago")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.ToView("TipoPagoss");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.TodosLosProveedore", b =>
                {
                    b.Property<string>("Correo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(180)
                        .IsUnicode(false)
                        .HasColumnType("varchar(180)");

                    b.Property<string>("Idproveedor")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NombreProveedor")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.ToView("TodosLosProveedores");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.UbicacionMaterial", b =>
                {
                    b.Property<string>("Cantidad")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NombreMaterial")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Tipo")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.ToView("UbicacionMaterial");
                });

            modelBuilder.Entity("AppDeipesaAPI.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Almacen", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Ciudad", "Ciudad")
                        .WithMany("Almacenes")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Cliente", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Ciudad", "Ciudad")
                        .WithMany("Clientes")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Contrato", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Cliente", "Cliente")
                        .WithMany("Contratos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.DetalleFactura", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Factura", "IdFacturaNavigation")
                        .WithMany("DetalleFacturas")
                        .HasForeignKey("IdFactura")
                        .HasConstraintName("FK_IdFactura");

                    b.HasOne("AppDeipesaAPI.Models.Materiale", "IdMaterialNavigation")
                        .WithMany("DetalleFacturas")
                        .HasForeignKey("IdMaterial")
                        .HasConstraintName("FK_IdMaterial");

                    b.Navigation("IdFacturaNavigation");

                    b.Navigation("IdMaterialNavigation");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.DetalleOrdenCompra", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Materiale", "IdMaterialNavigation")
                        .WithMany("DetalleOrdenCompras")
                        .HasForeignKey("IdMaterial")
                        .HasConstraintName("FK_IdMaterial2");

                    b.HasOne("AppDeipesaAPI.Models.OrdenCompra", "IdOrdenCompraNavigation")
                        .WithMany("DetalleOrdenCompras")
                        .HasForeignKey("IdOrdenCompra")
                        .HasConstraintName("FK_IdOrdenCompra");

                    b.Navigation("IdMaterialNavigation");

                    b.Navigation("IdOrdenCompraNavigation");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Factura", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Facturas")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK_IdCliente");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Inventario", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Almacen", "IdAlmacenNavigation")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdAlmacen")
                        .HasConstraintName("FK_IdAlmacen");

                    b.HasOne("AppDeipesaAPI.Models.Materiale", "IdMaterialNavigation")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdMaterial")
                        .HasConstraintName("FK_IdMaterial1");

                    b.Navigation("IdAlmacenNavigation");

                    b.Navigation("IdMaterialNavigation");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.OrdenCompra", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Proveedor", "IdproveedorNavigation")
                        .WithMany("OrdenCompras")
                        .HasForeignKey("Idproveedor")
                        .HasConstraintName("FK_Idproveedor");

                    b.Navigation("IdproveedorNavigation");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Pago", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FKIdCliente");

                    b.HasOne("AppDeipesaAPI.Models.TipoPago", "IdTipoPagosNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("IdTipoPagos")
                        .HasConstraintName("FKIdTipoPagos");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdTipoPagosNavigation");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Proforma", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Ciudad", "Ciudad")
                        .WithMany("Proformas")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Proveedor", b =>
                {
                    b.HasOne("AppDeipesaAPI.Models.Ciudad", "Ciudad")
                        .WithMany("Proveedores")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Almacen", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Ciudad", b =>
                {
                    b.Navigation("Almacenes");

                    b.Navigation("Clientes");

                    b.Navigation("Proformas");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Cliente", b =>
                {
                    b.Navigation("Contratos");

                    b.Navigation("Facturas");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Factura", b =>
                {
                    b.Navigation("DetalleFacturas");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Materiale", b =>
                {
                    b.Navigation("DetalleFacturas");

                    b.Navigation("DetalleOrdenCompras");

                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.OrdenCompra", b =>
                {
                    b.Navigation("DetalleOrdenCompras");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.Proveedor", b =>
                {
                    b.Navigation("OrdenCompras");
                });

            modelBuilder.Entity("AppDeipesaAPI.Models.TipoPago", b =>
                {
                    b.Navigation("Pagos");
                });
#pragma warning restore 612, 618
        }
    }
}
