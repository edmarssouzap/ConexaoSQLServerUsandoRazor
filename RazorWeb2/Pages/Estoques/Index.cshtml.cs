﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWeb2.Data;

namespace RazorWeb2.Pages.Estoques
{
    public class IndexModel : PageModel
    {
        private readonly RazorWeb2.Data.RazorWeb2Context _context;

        public IndexModel(RazorWeb2.Data.RazorWeb2Context context)
        {
            _context = context;
        }

        public IList<Estoque> Estoque { get;set; }

        public async Task OnGetAsync()
        {
            Estoque = await _context.Estoque.ToListAsync();
        }
    }
}
