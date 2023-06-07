using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class InfoFactura
    {
        public string? Nombres { get; set; }
        public string? Material { get; set; }
        public string? Cantidad { get; set; }
        public double? Pvu { get; set; }
        public double? Impuesto { get; set; }
        public double? SubTotal { get; set; }
        public double? Total { get; set; }
    }
}
