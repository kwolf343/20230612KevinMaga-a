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
    public class EmpleadosController : Controller
    {
        private readonly PruebaLaboralContext _context;

        public EmpleadosController(PruebaLaboralContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var pruebaLaboralContext = _context.Empleados.Include(e => e.IdDepartamentoNavigation);
            List<Empleado> lista = await pruebaLaboralContext.ToListAsync();
            if (id == null || _context.Departamentos == null) { 
                return View(lista);
            }
            List<Empleado> lista2 = new List<Empleado>();
            foreach (var empleado in lista)
            {
                if (empleado.IdDepartamento.Equals(id))
                {
                    lista2.Add(empleado);
                }
            }
            return View(lista2);
        }
    }
}
