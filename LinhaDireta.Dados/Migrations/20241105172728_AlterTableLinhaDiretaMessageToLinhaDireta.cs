using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhaDireta.Dados.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableLinhaDiretaMessageToLinhaDireta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinhaDiretaHistorico_LinhaDiretaMessages_LinhaDiretaId",
                table: "LinhaDiretaHistorico");

            migrationBuilder.DropForeignKey(
                name: "FK_LinhaDiretaMessages_StatusLinhaDireta_StatusId",
                table: "LinhaDiretaMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LinhaDiretaMessages",
                table: "LinhaDiretaMessages");

            migrationBuilder.RenameTable(
                name: "LinhaDiretaMessages",
                newName: "LinhaDireta");

            migrationBuilder.RenameIndex(
                name: "IX_LinhaDiretaMessages_StatusId",
                table: "LinhaDireta",
                newName: "IX_LinhaDireta_StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LinhaDireta",
                table: "LinhaDireta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LinhaDireta_StatusLinhaDireta_StatusId",
                table: "LinhaDireta",
                column: "StatusId",
                principalTable: "StatusLinhaDireta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LinhaDiretaHistorico_LinhaDireta_LinhaDiretaId",
                table: "LinhaDiretaHistorico",
                column: "LinhaDiretaId",
                principalTable: "LinhaDireta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LinhaDireta_StatusLinhaDireta_StatusId",
                table: "LinhaDireta");

            migrationBuilder.DropForeignKey(
                name: "FK_LinhaDiretaHistorico_LinhaDireta_LinhaDiretaId",
                table: "LinhaDiretaHistorico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LinhaDireta",
                table: "LinhaDireta");

            migrationBuilder.RenameTable(
                name: "LinhaDireta",
                newName: "LinhaDiretaMessages");

            migrationBuilder.RenameIndex(
                name: "IX_LinhaDireta_StatusId",
                table: "LinhaDiretaMessages",
                newName: "IX_LinhaDiretaMessages_StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LinhaDiretaMessages",
                table: "LinhaDiretaMessages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LinhaDiretaHistorico_LinhaDiretaMessages_LinhaDiretaId",
                table: "LinhaDiretaHistorico",
                column: "LinhaDiretaId",
                principalTable: "LinhaDiretaMessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LinhaDiretaMessages_StatusLinhaDireta_StatusId",
                table: "LinhaDiretaMessages",
                column: "StatusId",
                principalTable: "StatusLinhaDireta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
