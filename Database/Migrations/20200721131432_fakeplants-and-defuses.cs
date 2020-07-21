using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class fakeplantsanddefuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BombPlant",
                table: "BombPlant");

            migrationBuilder.DropIndex(
                name: "IX_BombPlant_MatchId_Round",
                table: "BombPlant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BombDefused",
                table: "BombDefused");

            migrationBuilder.DropIndex(
                name: "IX_BombDefused_MatchId_Round",
                table: "BombDefused");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BombPlant",
                table: "BombPlant",
                columns: new[] { "MatchId", "Round", "Time" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BombDefused",
                table: "BombDefused",
                columns: new[] { "MatchId", "Round", "Time" });

            migrationBuilder.CreateIndex(
                name: "IX_BombPlant_MatchId_Round",
                table: "BombPlant",
                columns: new[] { "MatchId", "Round" });

            migrationBuilder.CreateIndex(
                name: "IX_BombDefused_MatchId_Round",
                table: "BombDefused",
                columns: new[] { "MatchId", "Round" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BombPlant",
                table: "BombPlant");

            migrationBuilder.DropIndex(
                name: "IX_BombPlant_MatchId_Round",
                table: "BombPlant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BombDefused",
                table: "BombDefused");

            migrationBuilder.DropIndex(
                name: "IX_BombDefused_MatchId_Round",
                table: "BombDefused");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BombPlant",
                table: "BombPlant",
                columns: new[] { "MatchId", "Round" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BombDefused",
                table: "BombDefused",
                columns: new[] { "MatchId", "Round" });

            migrationBuilder.CreateIndex(
                name: "IX_BombPlant_MatchId_Round",
                table: "BombPlant",
                columns: new[] { "MatchId", "Round" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BombDefused_MatchId_Round",
                table: "BombDefused",
                columns: new[] { "MatchId", "Round" },
                unique: true);
        }
    }
}
