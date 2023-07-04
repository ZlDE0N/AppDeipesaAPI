using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AppDeipesaAPI.Models
{
    public partial class DetalleOrdenCompra
    {
        public string IdDetalleOrdenCompra { get; set; } = null!;
        public string? IdOrdenCompra { get; set; }
        public string IdMaterial { get; set; } = null!;
        public DateTime? FechaFabricacion { get; set; }
        public string? Cantidad { get; set; }
        public double? Pvu { get; set; }
        public double? SubTotal { get; set; }
        [JsonIgnore]
        public virtual Materiale? IdMaterialNavigation { get; set; }
        public virtual OrdenCompra? IdOrdenCompraNavigation { get; set; }
    }
}
