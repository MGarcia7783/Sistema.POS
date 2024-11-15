using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DB.Models
{
    public class Producto
    {
        [Key]                                                           // Permite definir primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]           // Crear propiedad identity para campo primary key
        public int ProductoId { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        [ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }

        // Representa la categoría a la que pertenece el producto
        public virtual Categoria ?Categoria { get; set; }
    }
}
