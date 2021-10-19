using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Using para adicionar chave primaria
using System.ComponentModel.DataAnnotations.Schema; // Using para adicionar chave estrangeira
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaPeDeChumbo.Pages.Treinamentos
{
    public class Treinamento
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Nome do Treinamento")]
        public string NomeTreinamento { get; set; }
        public string IDAluno { get; set; }

        [ForeignKey("IDAluno")]
        public virtual int Aluno { get; set; }
    }
}
