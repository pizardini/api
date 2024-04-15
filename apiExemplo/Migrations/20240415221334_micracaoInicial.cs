using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiExemplo.Migrations
{
    /// <inheritdoc />
    public partial class micracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Cursos_TipoCursoId",
                table: "Cursos",
                column: "TipoCursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_TipoCursos_TipoCursoId",
                table: "Cursos",
                column: "TipoCursoId",
                principalTable: "TipoCursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_TipoCursos_TipoCursoId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_TipoCursoId",
                table: "Cursos");
        }
    }
}
