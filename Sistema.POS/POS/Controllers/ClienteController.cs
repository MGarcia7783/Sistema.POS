using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _clienteService;
        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetAll()
        {
            return Ok(await _clienteService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetById(int id)
        {
            return Ok(await _clienteService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            return Ok(await _clienteService.Create(cliente));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Cliente cliente)
        {
            return Ok(await _clienteService.Update(cliente));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _clienteService.Delete(id);
            return Ok();
        }
    }
}
