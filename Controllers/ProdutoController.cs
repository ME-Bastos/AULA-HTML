using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AULA_HTML.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            // Lista com 5 nomes de produtos
            List<string> produtos = new List<string> { "Teclado Mecânico", "Mouse Sem Fio", "Monitor 24", "Cabo HDMI", "Mousepad" };

            // Lista com os preços
            List<double> precos = new List<double> { 250.00, 45.50, 800.00, 25.00, 85.90 };

            // Passando as listas via ViewBag
            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}
