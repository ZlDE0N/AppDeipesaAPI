using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class MaterialesInventario
    {
        public string? Material { get; set; }
        public string? Cantidad { get; set; }
        public string? TipoInventario { get; set; }
        public string? StockMinimo { get; set; }
    }
}
