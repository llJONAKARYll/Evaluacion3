﻿using Evaluacion3.Database;
using Evaluacion3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Evaluacion3.Controllers
{
    public class herramientaController : Controller
    {

        private readonly ApplicationDbContext _context;

        public herramientaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var herramientas = _context.Tools.ToList();
            return (IActionResult)View(herramientas);
        }


        public IActionResult Create()
        {
            return (IActionResult)View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(herramienta tool)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tool);
                _context.SaveChanges();
                return RedirectToActionResult(nameof(Index));
            }
            return (IActionResult)View(tool);
        }

        private IActionResult RedirectToActionResult(string v)
        {
            throw new NotImplementedException();
        }
    }

}

