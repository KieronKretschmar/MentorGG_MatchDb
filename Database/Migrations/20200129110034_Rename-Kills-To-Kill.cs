using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class RenameKillsToKill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kills_MatchStats_MatchId",
                table: "Kills");

            migrationBuilder.DropForeignKey(
                name: "FK_Kills_Damage_MatchId_DamageId",
                table: "Kills");

            migrationBuilder.DropForeignKey(
                name: "FK_Kills_PlayerMatchStats_MatchId_PlayerId",
                table: "Kills");

            migrationBuilder.DropForeignKey(
                name: "FK_Kills_RoundStats_MatchId_Round",
                table: "Kills");

            migrationBuilder.DropForeignKey(
                name: "FK_Kills_PlayerMatchStats_MatchId_VictimId",
                table: "Kills");

            migrationBuilder.DropForeignKey(
                name: "FK_Kills_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Kills");

            migrationBuilder.DropForeignKey(
                name: "FK_Kills_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Kills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kills",
                table: "Kills");

            migrationBuilder.RenameTable(
                name: "Kills",
                newName: "Kill");

            migrationBuilder.RenameIndex(
                name: "IX_Kills_MatchId_Round_VictimId",
                table: "Kill",
                newName: "IX_Kill_MatchId_Round_VictimId");

            migrationBuilder.RenameIndex(
                name: "IX_Kills_MatchId_Round_PlayerId",
                table: "Kill",
                newName: "IX_Kill_MatchId_Round_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Kills_MatchId_VictimId",
                table: "Kill",
                newName: "IX_Kill_MatchId_VictimId");

            migrationBuilder.RenameIndex(
                name: "IX_Kills_MatchId_Round",
                table: "Kill",
                newName: "IX_Kill_MatchId_Round");

            migrationBuilder.RenameIndex(
                name: "IX_Kills_MatchId_PlayerId",
                table: "Kill",
                newName: "IX_Kill_MatchId_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Kills_MatchId_DamageId",
                table: "Kill",
                newName: "IX_Kill_MatchId_DamageId");

            migrationBuilder.RenameIndex(
                name: "IX_Kills_MatchId",
                table: "Kill",
                newName: "IX_Kill_MatchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kill",
                table: "Kill",
                columns: new[] { "MatchId", "KillId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Kill_MatchStats_MatchId",
                table: "Kill",
                column: "MatchId",
                principalTable: "MatchStats",
                principalColumn: "MatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kill_Damage_MatchId_DamageId",
                table: "Kill",
                columns: new[] { "MatchId", "DamageId" },
                principalTable: "Damage",
                principalColumns: new[] { "MatchId", "DamageId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kill_PlayerMatchStats_MatchId_PlayerId",
                table: "Kill",
                columns: new[] { "MatchId", "PlayerId" },
                principalTable: "PlayerMatchStats",
                principalColumns: new[] { "MatchId", "SteamId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kill_RoundStats_MatchId_Round",
                table: "Kill",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kill_PlayerMatchStats_MatchId_VictimId",
                table: "Kill",
                columns: new[] { "MatchId", "VictimId" },
                principalTable: "PlayerMatchStats",
                principalColumns: new[] { "MatchId", "SteamId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kill_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Kill",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kill_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Kill",
                columns: new[] { "MatchId", "Round", "VictimId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kill_MatchStats_MatchId",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_Damage_MatchId_DamageId",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_PlayerMatchStats_MatchId_PlayerId",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_RoundStats_MatchId_Round",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_PlayerMatchStats_MatchId_VictimId",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Kill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kill",
                table: "Kill");

            migrationBuilder.RenameTable(
                name: "Kill",
                newName: "Kills");

            migrationBuilder.RenameIndex(
                name: "IX_Kill_MatchId_Round_VictimId",
                table: "Kills",
                newName: "IX_Kills_MatchId_Round_VictimId");

            migrationBuilder.RenameIndex(
                name: "IX_Kill_MatchId_Round_PlayerId",
                table: "Kills",
                newName: "IX_Kills_MatchId_Round_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Kill_MatchId_VictimId",
                table: "Kills",
                newName: "IX_Kills_MatchId_VictimId");

            migrationBuilder.RenameIndex(
                name: "IX_Kill_MatchId_Round",
                table: "Kills",
                newName: "IX_Kills_MatchId_Round");

            migrationBuilder.RenameIndex(
                name: "IX_Kill_MatchId_PlayerId",
                table: "Kills",
                newName: "IX_Kills_MatchId_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Kill_MatchId_DamageId",
                table: "Kills",
                newName: "IX_Kills_MatchId_DamageId");

            migrationBuilder.RenameIndex(
                name: "IX_Kill_MatchId",
                table: "Kills",
                newName: "IX_Kills_MatchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kills",
                table: "Kills",
                columns: new[] { "MatchId", "KillId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Kills_MatchStats_MatchId",
                table: "Kills",
                column: "MatchId",
                principalTable: "MatchStats",
                principalColumn: "MatchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kills_Damage_MatchId_DamageId",
                table: "Kills",
                columns: new[] { "MatchId", "DamageId" },
                principalTable: "Damage",
                principalColumns: new[] { "MatchId", "DamageId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kills_PlayerMatchStats_MatchId_PlayerId",
                table: "Kills",
                columns: new[] { "MatchId", "PlayerId" },
                principalTable: "PlayerMatchStats",
                principalColumns: new[] { "MatchId", "SteamId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kills_RoundStats_MatchId_Round",
                table: "Kills",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kills_PlayerMatchStats_MatchId_VictimId",
                table: "Kills",
                columns: new[] { "MatchId", "VictimId" },
                principalTable: "PlayerMatchStats",
                principalColumns: new[] { "MatchId", "SteamId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kills_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Kills",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kills_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Kills",
                columns: new[] { "MatchId", "Round", "VictimId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
