using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorWeb2.Pages.Funcionarios;
using RazorWeb2.Pages.Alunos;
using RazorWeb2.Pages.Estoques;

namespace RazorWeb2.Data
{
    public class RazorWeb2Context : DbContext
    {
        public RazorWeb2Context (DbContextOptions<RazorWeb2Context> options)
            : base(options)
        {
        }

        public DbSet<RazorWeb2.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

        public DbSet<RazorWeb2.Pages.Alunos.Aluno> Aluno { get; set; }

        public DbSet<RazorWeb2.Pages.Estoques.Estoque> Estoque { get; set; }
    }
}
