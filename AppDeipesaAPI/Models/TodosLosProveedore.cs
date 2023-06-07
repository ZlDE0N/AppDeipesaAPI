using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class TodosLosProveedore
    {
        public string Idproveedor { get; set; } = null!;
        public string? NombreProveedor { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
    }
}
