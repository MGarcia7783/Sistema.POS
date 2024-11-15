using DB.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VentaService : IService<Venta>
    {
        private readonly VentaRepository _ventaRepository;

        public VentaService(VentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }

        public async Task<Venta> Create(Venta entity)
        {
            return await _ventaRepository.Create(entity);
        }

        public async Task<Venta?> Delete(int id)
        {
            return await _ventaRepository.Delete(id);
        }

        public async Task<List<Venta>> GetAll()
        {
            return await _ventaRepository.GetAll();
        }

        public async Task<Venta?> GetById(int id)
        {
            return await _ventaRepository.GetById(id);
        }

        public async Task<Venta> Update(Venta entity)
        {
            return await _ventaRepository.Update(entity);
        }
    }
}
