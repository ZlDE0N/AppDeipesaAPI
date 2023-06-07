using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class UbicacionMaterial
    {
        public string Id { get; set; } = null!;
        public string? NombreMaterial { get; set; }
        public string? Cantidad { get; set; }
        public string? Tipo { get; set; }
        public string? Ubicacion { get; set; }
    }
}
