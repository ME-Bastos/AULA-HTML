using Microsoft.AspNetCore.Mvc;

namespace UninoveMvc.Controllers // 💡 Se o seu projeto usar outro nome, ajuste aqui
{
    //Herdando de Controller
    public class AlunoController : Controller
    {
        //Método Index() com dados na ViewBag
        public IActionResult Index()
        {
            ViewBag.Nome = "Seu Nome Completo";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";
            
            return View();
        }

        //int id que recebe o ID do aluno
        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;
            
            if (id == 1)
                ViewBag.Nome = "Nome";
            else
                ViewBag.Nome = $"Aluno Código {id}";

            return View();
        }
    }
}
