using DB;
using DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductoRepository : IRepository<Producto>
    {
        private readonly PosContext _context;

        public ProductoRepository(PosContext posContext)
        {
            _context = posContext;
        }

        public async Task<Producto> Create(Producto entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Producto?> Delete(int id)
        {
            Producto? producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Remove(id);
                await _context.SaveChangesAsync();
                return producto;
            }
            return null;
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _context.Productos.Include(c=>c.Categoria).ToListAsync();
        }

        public async Task<Producto?> GetById(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<Producto> Update(Producto entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
