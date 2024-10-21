using Evaluacion3.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluacion3.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<herramienta> herramientas { get; set; }
        public DbSet<usuario> usuarios  { get; set; }
        public DbSet<movimiento> movimientos { get; set; }
        public DbSet<asignacion> asignacion { get; set; }
    }
}
