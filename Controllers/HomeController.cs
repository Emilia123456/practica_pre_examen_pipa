using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica_pre_examen_pipa_2.Models;

namespace practica_pre_examen_pipa_2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult TraerListadoAlumnos(string nombre, string apellido)
    {
        ViewBag.ListaNomApellAlumnos=BD.ObtenerNombreYApellidoAlumnos(nombre, apellido);         
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
