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
    public class VentaRepository : IRepository<Venta>
    {
        private readonly PosContext _context;
        public VentaRepository(PosContext posContext)
        {
            _context = posContext;
        }

        public async Task<Venta> Create(Venta entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Venta> Delete(int id)
        {
            Venta venta = await _context.Ventas.FindAsync(id);
            if (venta != null)
            {
                _context.Remove(id);
                await _context.SaveChangesAsync();
                return venta;
            }
            return null;
        }

        public async Task<List<Venta>> GetAll()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task<Venta> GetById(int id)
        {
            return await _context.Ventas.FindAsync(id);
        }

        public async Task<Venta> Update(Venta entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
