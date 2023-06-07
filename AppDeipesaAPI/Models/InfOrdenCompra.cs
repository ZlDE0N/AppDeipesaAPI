using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class InfOrdenCompra
    {
        public string? Proveedor { get; set; }
        public string? Cantidad { get; set; }
        public double? Pvu { get; set; }
        public double? Impuesto { get; set; }
        public double? Descuento { get; set; }
        public double? Total { get; set; }
    }
}
