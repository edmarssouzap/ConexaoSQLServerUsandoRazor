using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;// Using para adicionar chave primaria
using System.ComponentModel.DataAnnotations.Schema; // Using para adicionar chave estrangeira
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaPeDeChumbo.Pages.Funcionarios
{
    public class Funcionario
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Nome do(a) Funcionário(a)")]
        public string Nome { get; set; }
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public int IDfuncao { get; set; }

        [Display(Name = "Função do Funcionário")]
        [ForeignKey("IDfuncao")]
        public virtual int Funcao { get; set; }

        public int IDAluno { get; set; }

        [ForeignKey("IDAluno")]
        public virtual int Aluno { get; set; }
    }
}
