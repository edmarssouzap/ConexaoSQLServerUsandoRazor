using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWeb2.Data;

namespace RazorWeb2.Pages.Alunos
{
    public class DetailsModel : PageModel
    {
        private readonly RazorWeb2.Data.RazorWeb2Context _context;

        public DetailsModel(RazorWeb2.Data.RazorWeb2Context context)
        {
            _context = context;
        }

        public Aluno Aluno { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aluno = await _context.Aluno.FirstOrDefaultAsync(m => m.ID == id);

            if (Aluno == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
