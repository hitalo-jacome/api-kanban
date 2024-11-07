using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhaDireta.Dados.Migrations
{
    /// <inheritdoc />
    public partial class AlterLinhaDiretaAddTipoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoUsuario",
                table: "LinhaDiretaMessages",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoUsuario",
                table: "LinhaDiretaMessages");
        }
    }
}
