using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HawksMusic.API.Migrations
{
    /// <inheritdoc />
    public partial class PrimeriaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Artista = table.Column<string>(type: "TEXT", nullable: false),
                    AnoLancamento = table.Column<string>(type: "TEXT", nullable: true),
                    Gravadora = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Arquivo = table.Column<string>(type: "TEXT", nullable: false),
                    AlbumModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    PlayListModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musicas_Albums_AlbumModelId",
                        column: x => x.AlbumModelId,
                        principalTable: "Albums",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Musicas_PlayLists_PlayListModelId",
                        column: x => x.PlayListModelId,
                        principalTable: "PlayLists",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ususarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", nullable: false),
                    PlayListModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ususarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ususarios_PlayLists_PlayListModelId",
                        column: x => x.PlayListModelId,
                        principalTable: "PlayLists",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_AlbumModelId",
                table: "Musicas",
                column: "AlbumModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_PlayListModelId",
                table: "Musicas",
                column: "PlayListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ususarios_PlayListModelId",
                table: "Ususarios",
                column: "PlayListModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musicas");

            migrationBuilder.DropTable(
                name: "Ususarios");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "PlayLists");
        }
    }
}
