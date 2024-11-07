using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhaDireta.Dados.Migrations
{
    /// <inheritdoc />
    public partial class MigrationStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatusLinhaDireta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLinhaDireta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinhaDiretaMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Protocolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsavelId = table.Column<int>(type: "int", nullable: false),
                    DataRecebimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prazo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinhaDiretaMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinhaDiretaMessages_StatusLinhaDireta_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusLinhaDireta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinhaDiretaMessages_StatusId",
                table: "LinhaDiretaMessages",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinhaDiretaMessages");

            migrationBuilder.DropTable(
                name: "StatusLinhaDireta");
        }
    }
}
