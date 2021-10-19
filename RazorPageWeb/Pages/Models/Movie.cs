using System;
using System.Collections.Generic;
// Este using tem que ser adicionado para os dataType
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageWeb.Pages.Models
{
    public class Movie
    {
        // Essas são os modelos dos atributos das tabelas
        public int ID { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
}
