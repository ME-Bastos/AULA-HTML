using Microsoft.AspNetCore.Mvc;

namespace UninoveMvc.Controllers
{
    public class ContatoController : Controller
    {
        // GET: 
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Contato/Enviar (Recebe os dados quando clica em Enviar)
        [HttpPost]
        public IActionResult Enviar(string nome, string email, string assunto, string mensagem)
        {
            // Guarda o nome na ViewBag para dar as boas-vindas na tela de sucesso
            ViewBag.NomeUsuario = nome;
            ViewBag.AssuntoEnvio = assunto;

            return View("Sucesso");
        }
    }
}
