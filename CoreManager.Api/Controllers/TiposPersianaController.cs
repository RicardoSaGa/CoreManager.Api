using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreManager.Api.Data;
using CoreManager.Api.Models;

namespace CoreManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposPersianaController : ControllerBase
    {
        private readonly CoreManagerContext _context;

        public TiposPersianaController(CoreManagerContext context)
        {
            _context = context;
        }

        // GET: api/TiposPersiana
        [HttpGet]
        public async Task<IActionResult> GetTipos()
        {
            return Ok(await _context.TiposPersiana.ToListAsync());
        }

        // GET: api/TiposPersiana/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipo(int id)
        {
            var tipo = await _context.TiposPersiana.FindAsync(id);
            if (tipo == null) return NotFound();
            return Ok(tipo);
        }

        // POST: api/TiposPersiana
        [HttpPost]
        public async Task<IActionResult> PostTipo([FromBody] TipoPersiana tipo)
        {
            _context.TiposPersiana.Add(tipo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTipo), new { id = tipo.Id }, tipo);
        }

        // PUT: api/TiposPersiana/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipo(int id, [FromBody] TipoPersiana tipo)
        {
            if (id != tipo.Id) return BadRequest();

            if (!await _context.TiposPersiana.AnyAsync(t => t.Id == id))
                return NotFound();

            _context.Entry(tipo).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/TiposPersiana/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipo(int id)
        {
            var tipo = await _context.TiposPersiana.FindAsync(id);
            if (tipo == null) return NotFound();

            _context.TiposPersiana.Remove(tipo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
