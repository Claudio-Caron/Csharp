using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersistindoDadosComEntityFC.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "FotoPerfil", "Bio"},
                new object []{"Roberto Andrade", "Sem Foto", "1,84 de altura. Jovem Homem."});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
