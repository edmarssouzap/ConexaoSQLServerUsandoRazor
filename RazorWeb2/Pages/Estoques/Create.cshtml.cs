using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorWeb2.Data;

namespace RazorWeb2.Pages.Estoques
{
    public class CreateModel : PageModel
    {
        private readonly RazorWeb2.Data.RazorWeb2Context _context;

        public CreateModel(RazorWeb2.Data.RazorWeb2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Estoque Estoque { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Estoque.Add(Estoque);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
