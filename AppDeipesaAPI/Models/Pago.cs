using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class Pago
    {
        public string IdPago { get; set; } = null!;
        public string? IdCliente { get; set; }
        public string? IdTipoPagos { get; set; }
        public string? FechaPago { get; set; }
        public double? Monto { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual TipoPago? IdTipoPagosNavigation { get; set; }
    }
}
