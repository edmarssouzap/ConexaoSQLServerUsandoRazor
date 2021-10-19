using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Using para adicionar chave primaria
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaPeDeChumbo.Pages.Alunos
{
    public class Aluno
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Nome do Aluno")]
        public string NomeAluno { get; set; }
        [Required]
        [Display(Name = "CPF do Aluno")]
        [StringLength(11, MinimumLength = 11)]
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        [Display(Name = "Valor do Curso")] // DataAnnotations
        public float ValorTreinamento { get; set; }
        [Display(Name = "Forma de Pagamento")]
        public string FormaPagamento { get; set; }
        [Display(Name = "Carteira de Habilitação")]
        public int Cnh { get; set; }
    }
}
