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
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; } = string.Empty;

        // Representa la colección de productos que pertenecen a una categoría
        [JsonIgnore]
        public virtual ICollection<Producto> ?Productos { get; set; }
    }
}
