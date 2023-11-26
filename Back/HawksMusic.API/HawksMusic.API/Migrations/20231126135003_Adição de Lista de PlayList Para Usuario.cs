using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HawksMusic.API.Migrations
{
    /// <inheritdoc />
    public partial class AdiçãodeListadePlayListParaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_PlayLists_PlayListModelId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_PlayListModelId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PlayListModelId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "PlayLists",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_UsuarioId",
                table: "PlayLists",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayLists_Usuarios_UsuarioId",
                table: "PlayLists",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayLists_Usuarios_UsuarioId",
                table: "PlayLists");

            migrationBuilder.DropIndex(
                name: "IX_PlayLists_UsuarioId",
                table: "PlayLists");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PlayLists");

            migrationBuilder.AddColumn<int>(
                name: "PlayListModelId",
                table: "Usuarios",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PlayListModelId",
                table: "Usuarios",
                column: "PlayListModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_PlayLists_PlayListModelId",
                table: "Usuarios",
                column: "PlayListModelId",
                principalTable: "PlayLists",
                principalColumn: "Id");
        }
    }
}
