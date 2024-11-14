using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoService _productoService;
        public ProductoController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetAll()
        {
            return Ok(await _productoService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetById(int id)
        {
            return Ok(await _productoService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Producto producto)
        {
            return Ok(await _productoService.Create(producto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Producto producto)
        {
            return Ok(await _productoService.Update(producto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productoService.Delete(id);
            return Ok();
        }
    }
}
