using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            OrdenCompras = new HashSet<OrdenCompra>();
        }

        public string Idproveedor { get; set; } = null!;
        public string? NombreProveedor { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }

        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
    }
}
