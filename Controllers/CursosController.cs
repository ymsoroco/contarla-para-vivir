using Microsoft.AspNetCore.Mvc;
using Contarla_Para_Vivir_PNT.Models;
using ContarlaParaVivir.Models;

namespace Contarla_Para_Vivir_PNT.Controllers
{
    public class CursosController : Controller
    {
        private readonly ContarlaContext _context;

        public CursosController(ContarlaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cursos = _context.Cursos.ToList(); // Ahora carga los cursos reales de la base
            return View(cursos);
        }
    }
}
