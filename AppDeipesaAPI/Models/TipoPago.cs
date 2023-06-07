using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Pagos = new HashSet<Pago>();
        }

        public string IdTipoPagos { get; set; } = null!;
        public string? TipoPago1 { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
