using System.ComponentModel.DataAnnotations;

namespace CoreManager.Api.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public int TipoEmpleadoId { get; set; }

        public TipoEmpleado? TipoEmpleado { get; set; }
    }
}
