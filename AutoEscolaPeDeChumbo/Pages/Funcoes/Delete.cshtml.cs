using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPeDeChumbo.Data;

namespace AutoEscolaPeDeChumbo.Pages.Funcoes
{
    public class DeleteModel : PageModel
    {
        private readonly AutoEscolaPeDeChumbo.Data.AutoEscolaPeDeChumboContext _context;

        public DeleteModel(AutoEscolaPeDeChumbo.Data.AutoEscolaPeDeChumboContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Funcao Funcao { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcao = await _context.Funcao.FirstOrDefaultAsync(m => m.ID == id);

            if (Funcao == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcao = await _context.Funcao.FindAsync(id);

            if (Funcao != null)
            {
                _context.Funcao.Remove(Funcao);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
