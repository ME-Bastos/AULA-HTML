using Microsoft.AspNetCore.Mvc;
using AULA_HTML.Models;

namespace AULA_HTML.Controllers
{
    public class EnderecoController : Controller
    {
        // 1. Exibe a tela com o formulário de busca
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // 2. Recebe os dados via Model Binding e redireciona
        [HttpPost]
        public IActionResult Salvar(EnderecoModel model)
        {
            if (!ModelState.IsValid)
            {
                // Se o número ou CEP não forem preenchidos, volta para a tela inicial
                return View("Index", model);
            }

            // Redireciona enviando o modelo preenchido para a tela de visualização (somente leitura)
            return View("Confirmacao", model);
        }
    }
}