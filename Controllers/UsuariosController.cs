using Microsoft.AspNetCore.Mvc;
using Contarla_Para_Vivir_PNT.Models;
using ContarlaParaVivir.Models;

namespace Contarla_Para_Vivir_PNT.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ContarlaContext _context;

        public UsuariosController(ContarlaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Usuario usuario)
        {
            if (_context.Usuarios.Any(u => u.Email == usuario.Email))
            {
                ModelState.AddModelError("Email", "El email ya está registrado.");
            }

            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Gracias");
            }

            return View(usuario);
        }

        public IActionResult Gracias()
        {
            return View();
        }
    }
}
