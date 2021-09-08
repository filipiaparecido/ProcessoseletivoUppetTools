using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessoseletivoUppetTools.Migrations
{
    public partial class dbinicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Segmento",
                table: "Empresas",
                newName: "Situacao");

            migrationBuilder.AddColumn<string>(
                name: "AtvPrincCod",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AtvPrincDesc",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtvPrincCod",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "AtvPrincDesc",
                table: "Empresas");

            migrationBuilder.RenameColumn(
                name: "Situacao",
                table: "Empresas",
                newName: "Segmento");
        }
    }
}
