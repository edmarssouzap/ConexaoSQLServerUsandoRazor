using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWeb2.Data;

namespace RazorWeb2.Pages.Estoques
{
    public class DeleteModel : PageModel
    {
        private readonly RazorWeb2.Data.RazorWeb2Context _context;

        public DeleteModel(RazorWeb2.Data.RazorWeb2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Estoque Estoque { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Estoque = await _context.Estoque.FirstOrDefaultAsync(m => m.ID == id);

            if (Estoque == null)
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

            Estoque = await _context.Estoque.FindAsync(id);

            if (Estoque != null)
            {
                _context.Estoque.Remove(Estoque);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
