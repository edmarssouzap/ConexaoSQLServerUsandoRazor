using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorWeb2.Migrations
{
    public partial class CamposExtras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Funcionario");
        }
    }
}
