using DB;
using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ClienteRepository : IRepository<Cliente>
    {
        private readonly PosContext _context;
        public ClienteRepository(PosContext posContext)
        {
            _context = posContext;
        }

        public async Task<Cliente> Create(Cliente entity)
        {
            _context.Clientes.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Cliente> Delete(int id)
        {
            Cliente cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
                return cliente;
            }
            return null;
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetById(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<Cliente> Update(Cliente entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
