using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class Materiale
    {
        public Materiale()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
            DetalleOrdenCompras = new HashSet<DetalleOrdenCompra>();
            Inventarios = new HashSet<Inventario>();
        }

        public string IdMaterial { get; set; } = null!;
        public string? NombreMaterial { get; set; }
        public string? UnidadDeMedida { get; set; }
        public string? Descripcion { get; set; }
        public string? Marca { get; set; }
        public double? Pvu { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
        public virtual ICollection<DetalleOrdenCompra> DetalleOrdenCompras { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
