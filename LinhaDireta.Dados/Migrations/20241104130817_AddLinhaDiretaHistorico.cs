using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhaDireta.Dados.Migrations
{
    /// <inheritdoc />
    public partial class AddLinhaDiretaHistorico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataUltimaAtualizacao",
                table: "LinhaDiretaMessages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelUltimaAtualizacaoId",
                table: "LinhaDiretaMessages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LinhaDiretaHistorico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinhaDiretaMessageId = table.Column<int>(type: "int", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusAnterior = table.Column<int>(type: "int", nullable: false),
                    StatusAtual = table.Column<int>(type: "int", nullable: false),
                    ResponsavelAlteracaoId = table.Column<int>(type: "int", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TempoNoStatus = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhaDiretaHistorico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinhaDiretaHistorico_LinhaDiretaMessages_LinhaDiretaMessageId",
                        column: x => x.LinhaDiretaMessageId,
                        principalTable: "LinhaDiretaMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinhaDiretaHistorico_LinhaDiretaMessageId",
                table: "LinhaDiretaHistorico",
                column: "LinhaDiretaMessageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinhaDiretaHistorico");

            migrationBuilder.DropColumn(
                name: "DataUltimaAtualizacao",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropColumn(
                name: "ResponsavelUltimaAtualizacaoId",
                table: "LinhaDiretaMessages");
        }
    }
}
