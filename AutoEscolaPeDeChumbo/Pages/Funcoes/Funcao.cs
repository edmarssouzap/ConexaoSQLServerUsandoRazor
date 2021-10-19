using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Using Para Display - Name
using System.ComponentModel.DataAnnotations.Schema; // Using para adicionar chave estrangeira
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscolaPeDeChumbo.Pages.Funcoes
{
    public class Funcao
    {
        public int ID { get; set; }
        [Display (Name = "Nome da Função")]
        public string NomeFuncao { get; set; }

        public int IDFuncionario { get; set; }

        [ForeignKey("IDFuncionario")]
        public virtual int Funcionario { get; set; }
    }
}
