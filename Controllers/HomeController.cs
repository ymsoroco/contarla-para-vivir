using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; //trae todo lo necesario para usar MVC.
using Contarla_Para_Vivir_PNT.Models; // carpeta de modelos 

//using trae referencias a otros archivos o librerías. 
namespace Contarla_Para_Vivir_PNT.Controllers;

public class HomeController : Controller
//clase pública Hereda de la clase Controller, lo que le da la capacidad de manejar rutas y devolver vistas.
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        //ILogger es para registrar mensajes de depuración o errores 
    }

    // public → se puede acceder desde el navegador.
    //IActionResult → el tipo de respuesta (en este caso, una vista).
    //Index() → nombre del método.
    //return View(); → le dice a ASP.NET que muestre una página HTML que esté en:/Views/Home/Index.cshtml

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Cursos()
    {
        return View();
    }

    public IActionResult Contacto()
    {
        return View();
    }

    public IActionResult QuienesSomos()
    {
        return View();
    }

    public IActionResult MaterialGratuito()
    {
        return View();
    }

    public IActionResult Reviews()
    {
        return View();
    }

    public IActionResult Foro()
    {
        return View();
    }

    public IActionResult Calendario()
    {
        return View();
    }

    public IActionResult Admin()
    {
        return View();
    }

    // Por ahora no lo usamos pero lo dejo por las dudas
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    // lo usa el sistema automáticamente si algo falla
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult DosisLiterarias()
    {
        return View();
    }


}
