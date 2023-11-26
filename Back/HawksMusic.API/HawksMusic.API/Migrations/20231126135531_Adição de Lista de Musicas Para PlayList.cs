using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HawksMusic.API.Migrations
{
    /// <inheritdoc />
    public partial class AdiçãodeListadeMusicasParaPlayList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PlayListId",
                table: "Musicas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_PlayListId",
                table: "Musicas",
                column: "PlayListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_PlayLists_PlayListId",
                table: "Musicas",
                column: "PlayListId",
                principalTable: "PlayLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_PlayLists_PlayListId",
                table: "Musicas");

            migrationBuilder.DropIndex(
                name: "IX_Musicas_PlayListId",
                table: "Musicas");

            migrationBuilder.DropColumn(
                name: "PlayListId",
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
    }
}
