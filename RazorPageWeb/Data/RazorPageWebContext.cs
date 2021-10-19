using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageWeb.Pages.Models;

namespace RazorPageWeb.Data
{
    public class RazorPageWebContext : DbContext
    {
        public RazorPageWebContext (DbContextOptions<RazorPageWebContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageWeb.Pages.Models.Movie> Movie { get; set; }
    }
}
