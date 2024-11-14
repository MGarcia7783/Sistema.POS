using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly VentaService _ventaService;
        public VentaController(VentaService ventaService)
        {
            _ventaService = ventaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetAll()
        {
            return Ok(await _ventaService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> GetById(int id)
        {
            return Ok(await _ventaService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Venta venta)
        {
            return Ok(await _ventaService.Create(venta));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Venta venta)
        {
            return Ok(await _ventaService.Update(venta));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _ventaService.Delete(id);
            return Ok();
        }
    }
}
