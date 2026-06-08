using System.ComponentModel.DataAnnotations;

namespace AULA_HTML.Models
{
    public class ImcModel
    {
        [Required(ErrorMessage = "O peso é obrigatório.")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "A altura é obrigatória.")]
        public string Altura { get; set; }

        public double? ValorImc { get; set; }
        public string Classificacao { get; set; }
        public string ErrorMessage { get; set; } 
    }
}