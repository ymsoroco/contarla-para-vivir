using Microsoft.AspNetCore.Mvc;
using Contarla_Para_Vivir_PNT.Models;
using Microsoft.EntityFrameworkCore;
using ContarlaParaVivir.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Contarla_Para_Vivir_PNT.Controllers
{
    public class InscripcionesController : Controller
    {
        private readonly ContarlaContext _context;

        public InscripcionesController(ContarlaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            ViewData["Cursos"] = new SelectList(_context.Cursos.ToList(), "Id", "Titulo");
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Inscripcion inscripcion)
        {
            if (!_context.Usuarios.Any(u => u.Email == inscripcion.Email))
            {
                ModelState.AddModelError("Email", "Este email no está registrado. Por favor registrate primero.");
            }
            if (ModelState.IsValid)
            {
                _context.Inscripciones.Add(inscripcion);
                _context.SaveChanges();
                return RedirectToAction("Gracias");
            }

            ViewData["Cursos"] = new SelectList(_context.Cursos.ToList(), "Id", "Titulo");
            return View(inscripcion);
        }

        public IActionResult Gracias()
        {
            return View();
        }

        public IActionResult Lista()
        {
            var inscriptos = _context.Inscripciones.Include(i => i.Curso).ToList();
            return View(inscriptos);
        }
    }
}
