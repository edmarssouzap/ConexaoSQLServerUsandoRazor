using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // using para o [Required]
using System.Linq;
using System.Threading.Tasks;

namespace RazorWeb2.Pages.Estoques
{
    public class Estoque
    {
        [Required]
        public int ID { get; set; }
        public string Produto { get; set; }
        public string Qtde { get; set; }
        public float ValorUnit { get; set; }

    }
}
