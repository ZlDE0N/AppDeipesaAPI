using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class Inventario
    {
        public string IdInventario { get; set; } = null!;
        public string? IdAlmacen { get; set; }
        public string IdMaterial { get; set; } = null!;
        public string? Cantidad { get; set; }
        public string? TipoInventario { get; set; }
        public string? StockMinimo { get; set; }

        public virtual Almacen? IdAlmacenNavigation { get; set; }
        public virtual Materiale? IdMaterialNavigation { get; set; }
    }
}
