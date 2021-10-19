using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPeDeChumbo.Pages.Alunos;
using AutoEscolaPeDeChumbo.Pages.Funcionarios;
using AutoEscolaPeDeChumbo.Pages.Funcoes;
using AutoEscolaPeDeChumbo.Pages.Treinamentos;
using AutoEscolaPeDeChumbo.Pages.Contato;

namespace AutoEscolaPeDeChumbo.Data
{
    public class AutoEscolaPeDeChumboContext : DbContext
    {
        public AutoEscolaPeDeChumboContext(DbContextOptions<AutoEscolaPeDeChumboContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9A7336F; Database=db_AutoEscola; User ID=sa; Password=sql123;");
        }

        public DbSet<AutoEscolaPeDeChumbo.Pages.Alunos.Aluno> Aluno { get; set; }

        public DbSet<AutoEscolaPeDeChumbo.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

        public DbSet<AutoEscolaPeDeChumbo.Pages.Funcoes.Funcao> Funcao { get; set; }

        public DbSet<AutoEscolaPeDeChumbo.Pages.Treinamentos.Treinamento> Treinamento { get; set; }

        public DbSet<AutoEscolaPeDeChumbo.Pages.Contato.Contato> Contato { get; set; }
    }
}
