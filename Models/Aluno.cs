using System;
using System.ComponentModel.DataAnnotations;

namespace AULA_HTML.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "O nome do aluno é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório.")]
        [StringLength(15, ErrorMessage = "O RA deve ter no máximo 15 caracteres.")]
        public string RA { get; set; }

        [Required(ErrorMessage = "Selecione ou digite o curso.")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}