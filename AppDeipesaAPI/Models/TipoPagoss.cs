using System;
using System.Collections.Generic;

namespace AppDeipesaAPI.Models
{
    public partial class TipoPagoss
    {
        public string IdTipoPagos { get; set; } = null!;
        public string? TipoPago { get; set; }
        public string? Descripcion { get; set; }
    }
}
