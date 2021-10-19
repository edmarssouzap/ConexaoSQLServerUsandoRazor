using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWeb2.Data;

namespace RazorWeb2.Pages.Funcionarios
{
    public class DeleteModel : PageModel
    {
        private readonly RazorWeb2.Data.RazorWeb2Context _context;

        public DeleteModel(RazorWeb2.Data.RazorWeb2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Funcionario Funcionario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario = await _context.Funcionario.FirstOrDefaultAsync(m => m.ID == id);

            if (Funcionario == null)
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

            Funcionario = await _context.Funcionario.FindAsync(id);

            if (Funcionario != null)
            {
                _context.Funcionario.Remove(Funcionario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
