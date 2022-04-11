using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TvCinema.RatingApi.Service.Infrastructure.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ImdbRating = table.Column<string>(type: "text", nullable: true),
                    TheMovieDb = table.Column<string>(type: "text", nullable: true),
                    RottenTomatoes = table.Column<string>(type: "text", nullable: true),
                    TV_com = table.Column<string>(type: "text", nullable: true),
                    FilmAffinity = table.Column<string>(type: "text", nullable: true),
                    Metascore = table.Column<string>(type: "text", nullable: true),
                    ImdbId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");
        }
    }
}
