using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DB.Models
{
    public class Cliente
    {
        // Los atributos su primera letra debe ser mayúscula

        [Key]                                                           // Permite definir primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]           // Crear propiedad identity para campo primary key
        public int ClienteID { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual ICollection<Venta> ?Ventas { get; set; } = new List<Venta>();
    }
}
