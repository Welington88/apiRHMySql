using Microsoft.EntityFrameworkCore.Migrations;

namespace apiRhMySql.Migrations
{
    public partial class nomeColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "Usuario",
                newName: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuario",
                newName: "Usuario");
        }
    }
}
