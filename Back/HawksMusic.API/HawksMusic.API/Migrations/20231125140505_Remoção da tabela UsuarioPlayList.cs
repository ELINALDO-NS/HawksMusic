using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HawksMusic.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoçãodatabelaUsuarioPlayList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_PlayLists_PlayListModelId",
                table: "Musicas");

            migrationBuilder.DropIndex(
                name: "IX_Musicas_PlayListModelId",
                table: "Musicas");

            migrationBuilder.DropColumn(
                name: "PlayListModelId",
                table: "Musicas");

            migrationBuilder.AddColumn<int>(
                name: "MusicaId",
                table: "PlayLists",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_MusicaId",
                table: "PlayLists",
                column: "MusicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayLists_Musicas_MusicaId",
                table: "PlayLists",
                column: "MusicaId",
                principalTable: "Musicas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayLists_Musicas_MusicaId",
                table: "PlayLists");

            migrationBuilder.DropIndex(
                name: "IX_PlayLists_MusicaId",
                table: "PlayLists");

            migrationBuilder.DropColumn(
                name: "MusicaId",
                table: "PlayLists");

            migrationBuilder.AddColumn<int>(
                name: "PlayListModelId",
                table: "Musicas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_PlayListModelId",
                table: "Musicas",
                column: "PlayListModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_PlayLists_PlayListModelId",
                table: "Musicas",
                column: "PlayListModelId",
                principalTable: "PlayLists",
                principalColumn: "Id");
        }
    }
}
