using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Utilizado para o [Display] abaixo
using System.Linq;
using System.Threading.Tasks;

namespace RazorWeb2.Pages.Funcionarios
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        // Troca o nome da coluna dtAdmissao para Data Admisao ao executar a aplicacao
        [Display(Name = "Data Admissão")]
        public DateTime dtAdmissao { get; set; }
        public double SalBruto { get; set; }
        // Forca o requerimento do campo ao rodar a aplicacao, ou seja, nao pode ser vazio
        // isso se chama Data Annottation
        // Pode usar em linha separada tambem da seguinte forma:
        // [Required]
        // [StringLength(30)]
        // [MinimumLength = 3]
        // Requerimento de maximo 30 e minimo 3 de caracteres no campo Cidade
        [Required, StringLength(30, MinimumLength = 3)]
        public string Cidade { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }



    }
}
