using System.ComponentModel.DataAnnotations.Schema;

namespace AppDeipesaAPI.Models
{
    [Table("Proformas")]
    public class Proforma
    {
        public long Id { get; set; }
        public long CiudadId { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public Ciudad? Ciudad { get; set; }
    }
}
