using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaService _categoriaService;
        public CategoriaController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetAll()
        {
            return Ok(await _categoriaService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> GetById(int id)
        {
            return Ok(await _categoriaService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Categoria categoria)
        {
            return Ok(await _categoriaService.Create(categoria));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Categoria categoria)
        {
            return Ok(await _categoriaService.Update(categoria));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoriaService.Delete(id);
            return Ok();
        }
    }
}
