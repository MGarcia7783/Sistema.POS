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
    public class DetalleVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetalleVentaId { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }

        //relaciones
        public int ProductoId { get; set; }
        public int VentaId { get; set; }
        public virtual Producto ?Producto { get; set; }

        [JsonIgnore]
        public virtual Venta ?Venta { get; set; }
    }
}
