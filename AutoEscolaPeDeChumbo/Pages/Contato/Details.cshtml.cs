using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPeDeChumbo.Data;

namespace AutoEscolaPeDeChumbo.Pages.Contato
{
    public class DetailsModel : PageModel
    {
        private readonly AutoEscolaPeDeChumbo.Data.AutoEscolaPeDeChumboContext _context;

        public DetailsModel(AutoEscolaPeDeChumbo.Data.AutoEscolaPeDeChumboContext context)
        {
            _context = context;
        }

        public Contato Contato { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contato = await _context.Contato.FirstOrDefaultAsync(m => m.ID == id);

            if (Contato == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
