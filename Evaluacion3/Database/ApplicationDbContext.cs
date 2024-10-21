using Evaluacion3.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluacion3.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<herramienta> Tools { get; set; }
        public DbSet<usuario> Users { get; set; }
        public DbSet<movimiento> Movements { get; set; }
        public DbSet<asignacion> Assignments { get; set; }
    }
}
