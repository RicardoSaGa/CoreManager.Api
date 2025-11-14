using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreManager.Api.Data;
using CoreManager.Api.Models;

namespace CoreManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposEmpleadoController : ControllerBase
    {
        private readonly CoreManagerContext _context;

        public TiposEmpleadoController(CoreManagerContext context)
        {
            _context = context;
        }

        // GET: api/TiposEmpleado
        [HttpGet]
        public async Task<IActionResult> GetTipos()
        {
            return Ok(await _context.TiposEmpleado.ToListAsync());
        }

        // GET: api/TiposEmpleado/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipo(int id)
        {
            var tipo = await _context.TiposEmpleado.FindAsync(id);
            if (tipo == null) return NotFound();
            return Ok(tipo);
        }

        // POST: api/TiposEmpleado
        [HttpPost]
        public async Task<IActionResult> PostTipo([FromBody] TipoEmpleado tipo)
        {
            _context.TiposEmpleado.Add(tipo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTipo), new { id = tipo.Id }, tipo);
        }

        // PUT: api/TiposEmpleado/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipo(int id, [FromBody] TipoEmpleado tipo)
        {
            if (id != tipo.Id) return BadRequest();

            if (!await _context.TiposEmpleado.AnyAsync(t => t.Id == id))
                return NotFound();

            _context.Entry(tipo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/TiposEmpleado/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipo(int id)
        {
            var tipo = await _context.TiposEmpleado.FindAsync(id);
            if (tipo == null) return NotFound();

            _context.TiposEmpleado.Remove(tipo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
