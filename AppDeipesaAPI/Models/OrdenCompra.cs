using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class OrdenCompra
    {
        public OrdenCompra()
        {
            DetalleOrdenCompras = new HashSet<DetalleOrdenCompra>();
        }

        public string IdOrdenCompra { get; set; } = null!;
        public string? Idproveedor { get; set; }
        public DateTime? FechaOrdenCompra { get; set; }
        public double? Impuesto { get; set; }
        public double? Descuento { get; set; }
        public double? Total { get; set; }

        public virtual Proveedor? IdproveedorNavigation { get; set; }
        public virtual ICollection<DetalleOrdenCompra> DetalleOrdenCompras { get; set; }
    }
}
