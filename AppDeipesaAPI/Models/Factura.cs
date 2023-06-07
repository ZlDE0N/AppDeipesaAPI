using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class Factura
    {
        public Factura()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public string IdFactura { get; set; } = null!;
        public string? IdCliente { get; set; }
        public DateTime? FechaFactura { get; set; }
        public double? Impuesto { get; set; }
        public double? Descuento { get; set; }
        public double? Total { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
