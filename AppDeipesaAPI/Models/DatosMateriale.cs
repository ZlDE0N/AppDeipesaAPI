using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class DatosMateriale
    {
        public string IdMaterial { get; set; } = null!;
        public string? NombreMaterial { get; set; }
        public string? UnidadDeMedida { get; set; }
        public string? Descripcion { get; set; }
        public string? Marca { get; set; }
        public double? Pvu { get; set; }
    }
}
