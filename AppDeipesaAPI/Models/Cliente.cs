using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
            Pagos = new HashSet<Pago>();
        }

        public string IdCliente { get; set; } = null!;
        public string? Cedula { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
