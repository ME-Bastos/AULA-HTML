using Microsoft.AspNetCore.Mvc;
using AULA_HTML.Models;
using System;
using System.Globalization;

namespace AULA_HTML.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ImcModel());
        }

        [HttpPost]
        public IActionResult Index(ImcModel model)
        {
            // Força o ASP.NET a esquecer validações automáticas antigas de tipo numérico
            ModelState.Clear();

            // Validação manual simples: garante que não enviou em branco
            if (string.IsNullOrEmpty(model.Peso) || string.IsNullOrEmpty(model.Altura))
            {
                model.ErrorMessage = "Por favor, preencha todos os campos.";
                return View(model);
            }

            try
            {
                // Limpa espaços e padroniza pontos/vírgulas
                string pesoTexto = model.Peso.Trim().Replace(",", ".");
                string alturaTexto = model.Altura.Trim().Replace(",", ".");

                // Converte usando o formato universal
                double peso = double.Parse(pesoTexto, CultureInfo.InvariantCulture);
                double altura = double.Parse(alturaTexto, CultureInfo.InvariantCulture);

                if (altura <= 0 || peso <= 0)
                {
                    model.ErrorMessage = "Os valores devem ser maiores que zero.";
                    return View(model);
                }

                // Realiza o cálculo matemático
                model.ValorImc = peso / (altura * altura);

                // Define as faixas de classificação do IMC
                if (model.ValorImc < 18.5) model.Classificacao = "Abaixo do peso";
                else if (model.ValorImc < 25) model.Classificacao = "Peso normal";
                else if (model.ValorImc < 30) model.Classificacao = "Sobrepeso";
                else model.Classificacao = "Obesidade";
            }
            catch (Exception)
            {
                model.ErrorMessage = "Use apenas números válidos. Exemplo: Peso: 80 | Altura: 1.75";
            }

            // Devolve o modelo limpo com o resultado calculado
            return View(model);
        }
    }
}