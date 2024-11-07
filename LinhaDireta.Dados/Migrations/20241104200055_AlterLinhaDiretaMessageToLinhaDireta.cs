using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhaDireta.Dados.Migrations
{
    /// <inheritdoc />
    public partial class AlterLinhaDiretaMessageToLinhaDireta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinhaDiretaHistorico_LinhaDiretaMessages_LinhaDiretaMessageId",
                table: "LinhaDiretaHistorico");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "LinhaDiretaMessages");

            migrationBuilder.RenameColumn(
                name: "LinhaDiretaMessageId",
                table: "LinhaDiretaHistorico",
                newName: "LinhaDiretaId");

            migrationBuilder.RenameIndex(
                name: "IX_LinhaDiretaHistorico_LinhaDiretaMessageId",
                table: "LinhaDiretaHistorico",
                newName: "IX_LinhaDiretaHistorico_LinhaDiretaId");

            migrationBuilder.AddColumn<string>(
                name: "Cota",
                table: "LinhaDiretaMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Departamento",
                table: "LinhaDiretaMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "LinhaDiretaMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grupo",
                table: "LinhaDiretaMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mensagem",
                table: "LinhaDiretaMessages",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeCompleto",
                table: "LinhaDiretaMessages",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroDocumento",
                table: "LinhaDiretaMessages",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "LinhaDiretaMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoDocumento",
                table: "LinhaDiretaMessages",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LinhaDiretaHistorico_LinhaDiretaMessages_LinhaDiretaId",
                table: "LinhaDiretaHistorico",
                column: "LinhaDiretaId",
                principalTable: "LinhaDiretaMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinhaDiretaHistorico_LinhaDiretaMessages_LinhaDiretaId",
                table: "LinhaDiretaHistorico");

            migrationBuilder.DropColumn(
                name: "Cota",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "Departamento",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "Grupo",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "Mensagem",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "NomeCompleto",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "NumeroDocumento",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "TipoDocumento",
                table: "LinhaDiretaMessages");

            migrationBuilder.RenameColumn(
                name: "LinhaDiretaId",
                table: "LinhaDiretaHistorico",
                newName: "LinhaDiretaMessageId");

            migrationBuilder.RenameIndex(
                name: "IX_LinhaDiretaHistorico_LinhaDiretaId",
                table: "LinhaDiretaHistorico",
                newName: "IX_LinhaDiretaHistorico_LinhaDiretaMessageId");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "LinhaDiretaMessages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_LinhaDiretaHistorico_LinhaDiretaMessages_LinhaDiretaMessageId",
                table: "LinhaDiretaHistorico",
                column: "LinhaDiretaMessageId",
                principalTable: "LinhaDiretaMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
