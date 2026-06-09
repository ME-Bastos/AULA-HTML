using System.ComponentModel.DataAnnotations;

namespace AULA_HTML.Models
{
    public class EnderecoModel
    {
        [Required(ErrorMessage = "O CEP é obrigatório.")]
        public string Cep { get; set; }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        [Required(ErrorMessage = "O número é obrigatório.")]
        public string Numero { get; set; }
        
        public string Complemento { get; set; }
    }
}