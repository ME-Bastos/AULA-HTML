using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AULA_HTML.Models;

namespace AULA_HTML.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Sobre()
    {
        return View();
    }
    public IActionResult Contato()
{
    return View();
}
public IActionResult Boletim()
{
    //listas de disciplinas e notas
    ViewBag.Disciplinas = new List<string> { "Matemática", "Desenvolvimento Web", "Banco de Dados", "Inglês", "Algoritmos" };
    
    ViewBag.Notas = new List<double> { 9.5, 6.0, 4.2, 7.5, 8.0 };

    return View();
}
}
