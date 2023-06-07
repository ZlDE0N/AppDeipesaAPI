using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class DatosCliente
    {
        public string? Cedula { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }
    }
}
