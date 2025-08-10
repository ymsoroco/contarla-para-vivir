using Microsoft.AspNetCore.Mvc;
using Contarla_Para_Vivir_PNT.Models;
using ContarlaParaVivir.Models;

namespace Contarla_Para_Vivir_PNT.Controllers
{
    public class ContactosController : Controller
    {
        private readonly ContarlaContext _context;

        public ContactosController(ContarlaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Contactos.Add(contacto);
                _context.SaveChanges();
                return RedirectToAction("Gracias");
            }

            return View(contacto);
        }

        public IActionResult Gracias()
        {
            return View();
        }
    }
}
