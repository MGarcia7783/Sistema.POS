using DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class PosContext : DbContext
    {
        // Este constructor recibe las opciones de configuración para el contexto de la base de datos.
        public PosContext(DbContextOptions<PosContext> options)
    : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }            // Representa una tabla en la base de datos llamada "Clientes"

        public DbSet<Categoria> Categorias { get; set; }        // Representa una tabla en la base de datos llamada "Categorias"

        public DbSet<Producto> Productos { get; set; }          // Representa una tabla en la base de datos llamada "Productos"

        public DbSet<Venta> Ventas { get; set; }                // Representa una tabla en el sistema de ventas llamada "Ventas"

        public DbSet<DetalleVenta> DetalleVentas { get; set; }  // Representa una tabla que detalla los items de cada venta.

    }
}
