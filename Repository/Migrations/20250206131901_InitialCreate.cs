using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimeDatas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanonicalTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbbreviatedTitles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCount = table.Column<int>(type: "int", nullable: false),
                    FavoritesCount = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PopularityRank = table.Column<int>(type: "int", nullable: false),
                    RatingRank = table.Column<int>(type: "int", nullable: false),
                    AgeRatingGuide = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EpisodeCount = table.Column<int>(type: "int", nullable: false),
                    EpisodeLength = table.Column<int>(type: "int", nullable: true),
                    YoutubeVideoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nsfw = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimePosterImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tiny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Small = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medium = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Large = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Original = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimePosterImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimePosterImages_AnimeDatas_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "AnimeDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimeTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    En = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    En_jp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ja_jp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimeTitles_AnimeDatas_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "AnimeDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimePosterImages_AnimeId",
                table: "AnimePosterImages",
                column: "AnimeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnimeTitles_AnimeId",
                table: "AnimeTitles",
                column: "AnimeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimePosterImages");

            migrationBuilder.DropTable(
                name: "AnimeTitles");

            migrationBuilder.DropTable(
                name: "AnimeDatas");
        }
    }
}
