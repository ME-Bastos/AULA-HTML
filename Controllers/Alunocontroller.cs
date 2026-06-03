using Microsoft.AspNetCore.Mvc;

namespace AULA_HTML.Controllers
{
    //Herdando de Controller
    public class AlunoController : Controller
    {
        //Método Index() com dados na ViewBag
        public IActionResult Index()
        {
            ViewBag.Nome = "Joãozinho";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";
            
            return View();
        }

        //Método Detalhes(int id) que recebe o ID do aluno
        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;
            
            if (id == 1)
                ViewBag.Nome = "Joaozinho";
            else
                ViewBag.Nome = $"Aluno Código {id}";

            return View();
        }
    }
}