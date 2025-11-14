using CoreManager.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreManager.Api.Data
{
    public class CoreManagerContext : DbContext
    {
        public CoreManagerContext(DbContextOptions<CoreManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoEmpleado> TiposEmpleado { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<TipoPersiana> TiposPersiana { get; set; }
    }
}
