using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class bombdroppedpositionjump : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCt",
                table: "BombPlant",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "BombPlant",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "BombPlant",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "BombPlant",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "StartTime",
                table: "BombPlant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Success",
                table: "BombPlant",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCt",
                table: "BombDefused",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "BombDefused",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "BombDefused",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "BombDefused",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "StartTime",
                table: "BombDefused",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Success",
                table: "BombDefused",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "DroppedBombPosition",
                columns: table => new
                {
                    MatchId = table.Column<long>(nullable: false),
                    Time = table.Column<int>(nullable: false),
                    Round = table.Column<byte>(nullable: false),
                    PosX = table.Column<float>(nullable: false),
                    PosY = table.Column<float>(nullable: false),
                    PosZ = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DroppedBombPosition", x => new { x.MatchId, x.Time });
                    table.ForeignKey(
                        name: "FK_DroppedBombPosition_MatchStats_MatchId",
                        column: x => x.MatchId,
                        principalTable: "MatchStats",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DroppedBombPosition_RoundStats_MatchId_Round",
                        columns: x => new { x.MatchId, x.Round },
                        principalTable: "RoundStats",
                        principalColumns: new[] { "MatchId", "Round" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerJump",
                columns: table => new
                {
                    MatchId = table.Column<long>(nullable: false),
                    Time = table.Column<int>(nullable: false),
                    PlayerId = table.Column<long>(nullable: false),
                    Round = table.Column<byte>(nullable: false),
                    IsCt = table.Column<bool>(nullable: false),
                    PlayerPosX = table.Column<float>(nullable: false),
                    PlayerPosY = table.Column<float>(nullable: false),
                    PlayerPosZ = table.Column<float>(nullable: false),
                    PlayerViewX = table.Column<float>(nullable: false),
                    PlayerViewY = table.Column<float>(nullable: false),
                    PlayerVeloX = table.Column<float>(nullable: false),
                    PlayerVeloY = table.Column<float>(nullable: false),
                    PlayerVeloZ = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerJump", x => new { x.MatchId, x.PlayerId, x.Time });
                    table.ForeignKey(
                        name: "FK_PlayerJump_MatchStats_MatchId",
                        column: x => x.MatchId,
                        principalTable: "MatchStats",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerJump_PlayerMatchStats_MatchId_PlayerId",
                        columns: x => new { x.MatchId, x.PlayerId },
                        principalTable: "PlayerMatchStats",
                        principalColumns: new[] { "MatchId", "SteamId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerJump_RoundStats_MatchId_Round",
                        columns: x => new { x.MatchId, x.Round },
                        principalTable: "RoundStats",
                        principalColumns: new[] { "MatchId", "Round" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerJump_PlayerRoundStats_MatchId_Round_PlayerId",
                        columns: x => new { x.MatchId, x.Round, x.PlayerId },
                        principalTable: "PlayerRoundStats",
                        principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DroppedBombPosition_MatchId",
                table: "DroppedBombPosition",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_DroppedBombPosition_MatchId_Round",
                table: "DroppedBombPosition",
                columns: new[] { "MatchId", "Round" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerJump_MatchId",
                table: "PlayerJump",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerJump_PlayerId",
                table: "PlayerJump",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerJump_MatchId_Round_PlayerId",
                table: "PlayerJump",
                columns: new[] { "MatchId", "Round", "PlayerId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DroppedBombPosition");

            migrationBuilder.DropTable(
                name: "PlayerJump");

            migrationBuilder.DropColumn(
                name: "IsCt",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "Success",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "IsCt",
                table: "BombDefused");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "BombDefused");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "BombDefused");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "BombDefused");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "BombDefused");

            migrationBuilder.DropColumn(
                name: "Success",
                table: "BombDefused");
        }
    }
}
