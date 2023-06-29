using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class Almacen
    {
        public Almacen()
        {
            Inventarios = new HashSet<Inventario>();
        }

        public string IdAlmacen { get; set; } = null!;
        public long CiudadId { get; set; }
        public string? NombreAlmacen { get; set; }
        public string? Ubicacion { get; set; }
        public string? Telefono { get; set; }
        public string? Capacidad { get; set; }

        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual Ciudad? Ciudad { get; set; }
    }
}
