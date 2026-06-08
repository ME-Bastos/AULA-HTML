using Microsoft.AspNetCore.Mvc;
using AULA_HTML.Models; // Mantém o modelo Aluno, só muda o controlador

namespace AULA_HTML.Controllers
{
    public class CadastroController : Controller
    {
        // Abre o formulário vazio
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // Recebe os dados e valida
        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                // Abre a tela de confirmação se tudo estiver correto
                return View("Confirmacao", aluno);
            }

            return View(aluno);
        }
    }
}