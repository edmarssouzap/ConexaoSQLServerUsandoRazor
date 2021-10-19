using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageWeb.Data;

namespace RazorPageWeb.Pages.Models
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageWeb.Data.RazorPageWebContext _context;

        public IndexModel(RazorPageWeb.Data.RazorPageWebContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
