using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaTrabajo.Models;

namespace PruebaTrabajo.Controllers
{
    public class DepartamentosController : Controller
    {
        private readonly PruebaLaboralContext _context;

        public DepartamentosController(PruebaLaboralContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return _context.Departamentos != null ? View(await _context.Departamentos.ToListAsync()) : Problem("Entity set 'PruebaLaboralContext.Departamentos'  is null.");
        }

        public async Task<IActionResult> Seleccion(int? id)
        {
            return RedirectToAction("Index", "Empleados", new { id = id });

        }
    }
}
