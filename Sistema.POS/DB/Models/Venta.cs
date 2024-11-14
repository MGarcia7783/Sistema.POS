using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentaId { get; set; }
        public int Factura { get; set; }
        public DateOnly Fecha { get; set; }
        public decimal Total { get; set; }
        public int ClienteId { get; set; }

        // Representa la colección de detalles de ventas que pertenecen a una venta
        public virtual ICollection<DetalleVenta> ?DetalleVentas { get; set; }

    }
}
