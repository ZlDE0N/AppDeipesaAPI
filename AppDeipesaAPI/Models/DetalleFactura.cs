using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class DetalleFactura
    {
        public string IdDetalleFactura { get; set; } = null!;
        public string? IdFactura { get; set; }
        public string? IdMaterial { get; set; }
        public string? Cantidad { get; set; }
        public double? SubTotal { get; set; }

        public virtual Factura? IdFacturaNavigation { get; set; }
        public virtual Materiale? IdMaterialNavigation { get; set; }
    }
}
