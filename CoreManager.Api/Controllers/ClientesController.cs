using CoreManager.Api.Data;
using CoreManager.Api.Models;
using CoreManager.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly CoreManagerContext _context;

        public ClientesController(CoreManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            return Ok(await _context.Clientes.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> PostCliente([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClientes), new { id = cliente.Id }, cliente);
        }
    }
}
