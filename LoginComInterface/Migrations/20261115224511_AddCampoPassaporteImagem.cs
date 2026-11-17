using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LoginComInterface.Migrations
{
    /// <inheritdoc />
    public partial class AddCampoPassaporteImagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    senha = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    cpf = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    passaporte = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    cartao = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    caminho_documento = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logins_cpf",
                table: "Logins",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_passaporte",
                table: "Logins",
                column: "passaporte",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_usuario",
                table: "Logins",
                column: "usuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");
        }
    }
}
