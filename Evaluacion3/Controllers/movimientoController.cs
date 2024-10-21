using Evaluacion3.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Evaluacion3.Controllers
{
    public class movimientoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public movimientoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movements = _context.Movements.Include(m => m.herramientaId).Include(m => m.UserId).ToList();
            return View(movements);
        }
    }
}
