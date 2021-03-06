// <auto-generated />
using AutoEscolaPeDeChumbo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoEscolaPeDeChumbo.Migrations
{
    [DbContext(typeof(AutoEscolaPeDeChumboContext))]
    [Migration("20211019165426_AdicionadoAnnottations")]
    partial class AdicionadoAnnottations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoEscolaPeDeChumbo.Pages.Alunos.Aluno", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormaPagamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("NomeAluno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ValorTreinamento")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("AutoEscolaPeDeChumbo.Pages.Funcionarios.Funcionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aluno")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Funcao")
                        .HasColumnType("int");

                    b.Property<int>("IDAluno")
                        .HasColumnType("int");

                    b.Property<int>("IDfuncao")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("AutoEscolaPeDeChumbo.Pages.Funcoes.Funcao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Funcionario")
                        .HasColumnType("int");

                    b.Property<int>("IDFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("NomeFuncao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Funcao");
                });

            modelBuilder.Entity("AutoEscolaPeDeChumbo.Pages.Treinamentos.Treinamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aluno")
                        .HasColumnType("int");

                    b.Property<string>("IDAluno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeTreinamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Treinamento");
                });
#pragma warning restore 612, 618
        }
    }
}
