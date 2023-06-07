using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class InfoAlmacen
    {
        public string IdAlmacen { get; set; } = null!;
        public string? NombreAlmacen { get; set; }
        public string? Ubicacion { get; set; }
        public string? Telefono { get; set; }
        public string? Capacidad { get; set; }
    }
}
