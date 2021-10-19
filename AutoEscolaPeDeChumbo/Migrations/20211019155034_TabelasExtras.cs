using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoEscolaPeDeChumbo.Migrations
{
    public partial class TabelasExtras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcao",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDFuncionario = table.Column<int>(type: "int", nullable: false),
                    Funcionario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcao", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Treinamento",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTreinamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDAluno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aluno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinamento", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcao");

            migrationBuilder.DropTable(
                name: "Treinamento");
        }
    }
}
