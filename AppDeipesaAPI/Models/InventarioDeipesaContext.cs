using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppDeipesaAPI.Models
{
    public partial class InventarioDeipesaContext : DbContext
    {
        public InventarioDeipesaContext()
        {
        }

        public InventarioDeipesaContext(DbContextOptions<InventarioDeipesaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ciudad> Ciudades => Set<Ciudad>();
        public virtual DbSet<Almacen> Almacens { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<DatosCliente> DatosClientes { get; set; } = null!;
        public virtual DbSet<DatosMateriale> DatosMateriales { get; set; } = null!;
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; } = null!;
        public virtual DbSet<DetalleOrdenCompra> DetalleOrdenCompras { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<InfOrdenCompra> InfOrdenCompras { get; set; } = null!;
        public virtual DbSet<InfoAlmacen> InfoAlmacens { get; set; } = null!;
        public virtual DbSet<InfoFactura> InfoFacturas { get; set; } = null!;
        public virtual DbSet<Inventario> Inventarios { get; set; } = null!;
        public virtual DbSet<Materiale> Materiales { get; set; } = null!;
        public virtual DbSet<MaterialesCemex> MaterialesCemices { get; set; } = null!;
        public virtual DbSet<MaterialesInventario> MaterialesInventarios { get; set; } = null!;
        public virtual DbSet<OrdenCompra> OrdenCompras { get; set; } = null!;
        public virtual DbSet<Pago> Pagos { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<TipoPago> TipoPagos { get; set; } = null!;
        public virtual DbSet<TipoPagoss> TipoPagosses { get; set; } = null!;
        public virtual DbSet<TodosLosProveedore> TodosLosProveedores { get; set; } = null!;
        public virtual DbSet<UbicacionMaterial> UbicacionMaterials { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-C6TJQC7;Database=Inventario Deipesa;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasKey(e => e.IdAlmacen)
                    .HasName("PKIdAlmacen");

                entity.ToTable("Almacen");

                entity.Property(e => e.IdAlmacen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Capacidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAlmacen)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PKIdCliente");

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DatosClientes");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(101)
                    .IsUnicode(false)
                    .HasColumnName("Nombre Completo");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosMateriale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DatosMateriales");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdMaterial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMaterial)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pvu).HasColumnName("PVU");

                entity.Property(e => e.UnidadDeMedida)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.HasKey(e => e.IdDetalleFactura)
                    .HasName("PKIdDetalleFactura");

                entity.ToTable("DetalleFactura");

                entity.Property(e => e.IdDetalleFactura)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdFactura)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdMaterial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_IdFactura");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdMaterial)
                    .HasConstraintName("FK_IdMaterial");
            });

            modelBuilder.Entity<DetalleOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalleOrdenCompra)
                    .HasName("PKIdDetalleOrdenCompra");

                entity.ToTable("DetalleOrdenCompra");

                entity.Property(e => e.IdDetalleOrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFabricacion).HasColumnType("datetime");

                entity.Property(e => e.IdMaterial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdOrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pvu).HasColumnName("PVU");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.DetalleOrdenCompras)
                    .HasForeignKey(d => d.IdMaterial)
                    .HasConstraintName("FK_IdMaterial2");

                entity.HasOne(d => d.IdOrdenCompraNavigation)
                    .WithMany(p => p.DetalleOrdenCompras)
                    .HasForeignKey(d => d.IdOrdenCompra)
                    .HasConstraintName("FK_IdOrdenCompra");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura)
                    .HasName("PKIdFactura");

                entity.ToTable("Factura");

                entity.Property(e => e.IdFactura)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_IdCliente");
            });

            modelBuilder.Entity<InfOrdenCompra>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("infOrdenCompra");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pvu).HasColumnName("PVU");
            });

            modelBuilder.Entity<InfoAlmacen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("infoAlmacen");

                entity.Property(e => e.Capacidad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdAlmacen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAlmacen)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfoFactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("infoFacturas");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pvu).HasColumnName("PVU");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario)
                    .HasName("PKIdInventario");

                entity.ToTable("Inventario");

                entity.Property(e => e.IdInventario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdAlmacen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdMaterial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockMinimo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInventario)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAlmacenNavigation)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.IdAlmacen)
                    .HasConstraintName("FK_IdAlmacen");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.IdMaterial)
                    .HasConstraintName("FK_IdMaterial1");
            });

            modelBuilder.Entity<Materiale>(entity =>
            {
                entity.HasKey(e => e.IdMaterial)
                    .HasName("PKIdMaterial");

                entity.Property(e => e.IdMaterial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMaterial)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pvu).HasColumnName("PVU");

                entity.Property(e => e.UnidadDeMedida)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialesCemex>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaterialesCemex");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdMaterial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMaterial)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pvu).HasColumnName("PVU");

                entity.Property(e => e.UnidadDeMedida)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialesInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaterialesInventario");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StockMinimo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInventario)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompra)
                    .HasName("PKIdOrdenCompra");

                entity.ToTable("OrdenCompra");

                entity.Property(e => e.IdOrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaOrdenCompra).HasColumnType("datetime");

                entity.Property(e => e.Idproveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdproveedorNavigation)
                    .WithMany(p => p.OrdenCompras)
                    .HasForeignKey(d => d.Idproveedor)
                    .HasConstraintName("FK_Idproveedor");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("PKIdPago");

                entity.Property(e => e.IdPago)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPago)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoPagos)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FKIdCliente");

                entity.HasOne(d => d.IdTipoPagosNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdTipoPagos)
                    .HasConstraintName("FKIdTipoPagos");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.Idproveedor)
                    .HasName("PKIdproveedor");

                entity.ToTable("Proveedor");

                entity.Property(e => e.Idproveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.IdTipoPagos)
                    .HasName("PKIdTipoPagos");

                entity.Property(e => e.IdTipoPagos)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPago1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TipoPago");
            });

            modelBuilder.Entity<TipoPagoss>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TipoPagoss");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoPagos)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TodosLosProveedore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TodosLosProveedores");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.Idproveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UbicacionMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UbicacionMaterial");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMaterial)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
