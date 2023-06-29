using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDeipesaAPI.Models
{
    [Table("Contratos")]
    public partial class Contrato
    {
        public long Id { get; set; }
        public string ClienteId { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string NombreAcordado { get; set; } = null!;

        [Column(TypeName = "DATE")]
        public DateTime Fecha { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
