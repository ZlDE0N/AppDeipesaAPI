using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDeipesaAPI.Models
{
    [Table("Ciudades")]
    public partial class Ciudad
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
    }
}