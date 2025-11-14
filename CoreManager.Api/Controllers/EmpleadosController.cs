using CoreManager.Api.Data;
using CoreManager.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly CoreManagerContext _context;

        public EmpleadosController(CoreManagerContext context)
        {
            _context = context;
        }

        // GET: api/Empleados
        [HttpGet]
        public async Task<IActionResult> GetEmpleados()
        {
            var empleados = await _context.Empleados
                .Include(e => e.TipoEmpleado)
                .ToListAsync();

            return Ok(empleados);
        }

        // GET: api/Empleados/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmpleado(int id)
        {
            var empleado = await _context.Empleados
                .Include(e => e.TipoEmpleado)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (empleado == null)
                return NotFound();

            return Ok(empleado);
        }

        // POST: api/Empleados
        [HttpPost]
        public async Task<IActionResult> PostEmpleado([FromBody] Empleado empleado)
        {
            // Validar que el tipo de empleado exista
            var tipoExiste = await _context.TiposEmpleado.AnyAsync(t => t.Id == empleado.TipoEmpleadoId);
            if (!tipoExiste)
                return BadRequest("El tipo de empleado no existe.");

            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmpleado), new { id = empleado.Id }, empleado);
        }

        // PUT: api/Empleados/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleado(int id, [FromBody] Empleado empleado)
        {
            if (id != empleado.Id)
                return BadRequest();

            var existe = await _context.Empleados.AnyAsync(e => e.Id == id);
            if (!existe)
                return NotFound();

            _context.Entry(empleado).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Empleados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleado(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null)
                return NotFound();

            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
