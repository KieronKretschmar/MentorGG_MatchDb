using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BombDefused_RoundStats_MatchId_Round",
                table: "BombDefused");

            migrationBuilder.DropForeignKey(
                name: "FK_BombDefused_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "BombDefused");

            migrationBuilder.DropForeignKey(
                name: "FK_BombExplosion_RoundStats_MatchId_Round",
                table: "BombExplosion");

            migrationBuilder.DropForeignKey(
                name: "FK_BombPlant_RoundStats_MatchId_Round",
                table: "BombPlant");

            migrationBuilder.DropForeignKey(
                name: "FK_BombPlant_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "BombPlant");

            migrationBuilder.DropForeignKey(
                name: "FK_BotTakeOver_RoundStats_MatchId_Round",
                table: "BotTakeOver");

            migrationBuilder.DropForeignKey(
                name: "FK_BotTakeOver_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "BotTakeOver");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectDisconnect_RoundStats_MatchId_Round",
                table: "ConnectDisconnect");

            migrationBuilder.DropForeignKey(
                name: "FK_Damage_RoundStats_MatchId_Round",
                table: "Damage");

            migrationBuilder.DropForeignKey(
                name: "FK_Damage_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Damage");

            migrationBuilder.DropForeignKey(
                name: "FK_Damage_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Damage");

            migrationBuilder.DropForeignKey(
                name: "FK_Decoy_RoundStats_MatchId_Round",
                table: "Decoy");

            migrationBuilder.DropForeignKey(
                name: "FK_Decoy_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Decoy");

            migrationBuilder.DropForeignKey(
                name: "FK_FireNade_RoundStats_MatchId_Round",
                table: "FireNade");

            migrationBuilder.DropForeignKey(
                name: "FK_FireNade_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "FireNade");

            migrationBuilder.DropForeignKey(
                name: "FK_Flash_RoundStats_MatchId_Round",
                table: "Flash");

            migrationBuilder.DropForeignKey(
                name: "FK_Flash_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Flash");

            migrationBuilder.DropForeignKey(
                name: "FK_Flashed_RoundStats_MatchId_Round",
                table: "Flashed");

            migrationBuilder.DropForeignKey(
                name: "FK_Flashed_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Flashed");

            migrationBuilder.DropForeignKey(
                name: "FK_He_RoundStats_MatchId_Round",
                table: "He");

            migrationBuilder.DropForeignKey(
                name: "FK_He_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "He");

            migrationBuilder.DropForeignKey(
                name: "FK_HostageDrop_RoundStats_MatchId_Round",
                table: "HostageDrop");

            migrationBuilder.DropForeignKey(
                name: "FK_HostageDrop_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "HostageDrop");

            migrationBuilder.DropForeignKey(
                name: "FK_HostagePickUp_RoundStats",
                table: "HostagePickUp");

            migrationBuilder.DropForeignKey(
                name: "FK_HostagePickUp_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "HostagePickUp");

            migrationBuilder.DropForeignKey(
                name: "FK_HostageRescue_RoundStats_MatchId_Round",
                table: "HostageRescue");

            migrationBuilder.DropForeignKey(
                name: "FK_HostageRescue_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "HostageRescue");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemDropped_RoundStats_MatchId_Round",
                table: "ItemDropped");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemDropped_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "ItemDropped");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPickedUp_RoundStats_MatchId_Round",
                table: "ItemPickedUp");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPickedUp_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "ItemPickedUp");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSaved_RoundStats_MatchId_Round",
                table: "ItemSaved");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSaved_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "ItemSaved");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_RoundStats_MatchId_Round",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_Kill_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Kill");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_RoundStats_MatchId_Round",
                table: "PlayerPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "PlayerPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerRoundStats_RoundStats_MatchId_Round",
                table: "PlayerRoundStats");

            migrationBuilder.DropForeignKey(
                name: "FK_RoundItem_RoundStats_MatchId_Round",
                table: "RoundItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RoundItem_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "RoundItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Smoke_RoundStats_MatchId_Round",
                table: "Smoke");

            migrationBuilder.DropForeignKey(
                name: "FK_Smoke_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Smoke");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponFired_RoundStats_MatchId_Round",
                table: "WeaponFired");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponFired_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "WeaponFired");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponReload_RoundStats_MatchId_Round",
                table: "WeaponReload");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponReload_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "WeaponReload");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_BombDefused_RoundStats_MatchId_Round",
                table: "BombDefused",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BombDefused_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "BombDefused",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BombExplosion_RoundStats_MatchId_Round",
                table: "BombExplosion",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BombPlant_RoundStats_MatchId_Round",
                table: "BombPlant",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BombPlant_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "BombPlant",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BotTakeOver_RoundStats_MatchId_Round",
                table: "BotTakeOver",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BotTakeOver_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "BotTakeOver",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectDisconnect_RoundStats_MatchId_Round",
                table: "ConnectDisconnect",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Damage_RoundStats_MatchId_Round",
                table: "Damage",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Damage_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Damage",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Damage_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Damage",
                columns: new[] { "MatchId", "Round", "VictimId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Decoy_RoundStats_MatchId_Round",
                table: "Decoy",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Decoy_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Decoy",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FireNade_RoundStats_MatchId_Round",
                table: "FireNade",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FireNade_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "FireNade",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flash_RoundStats_MatchId_Round",
                table: "Flash",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flash_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Flash",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flashed_RoundStats_MatchId_Round",
                table: "Flashed",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flashed_PlayerRoundStats_MatchId_Round_VictimId",
                table: "Flashed",
                columns: new[] { "MatchId", "Round", "VictimId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_He_RoundStats_MatchId_Round",
                table: "He",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_He_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "He",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostageDrop_RoundStats_MatchId_Round",
                table: "HostageDrop",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostageDrop_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "HostageDrop",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostagePickUp_RoundStats",
                table: "HostagePickUp",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HostagePickUp_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "HostagePickUp",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostageRescue_RoundStats_MatchId_Round",
                table: "HostageRescue",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostageRescue_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "HostageRescue",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDropped_RoundStats_MatchId_Round",
                table: "ItemDropped",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemDropped_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "ItemDropped",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPickedUp_RoundStats_MatchId_Round",
                table: "ItemPickedUp",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPickedUp_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "ItemPickedUp",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSaved_RoundStats_MatchId_Round",
                table: "ItemSaved",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSaved_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "ItemSaved",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kill_RoundStats_MatchId_Round",
                table: "Kill",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
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

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_RoundStats_MatchId_Round",
                table: "PlayerPosition",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "PlayerPosition",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerRoundStats_RoundStats_MatchId_Round",
                table: "PlayerRoundStats",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundItem_RoundStats_MatchId_Round",
                table: "RoundItem",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoundItem_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "RoundItem",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Smoke_RoundStats_MatchId_Round",
                table: "Smoke",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Smoke_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "Smoke",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponFired_RoundStats_MatchId_Round",
                table: "WeaponFired",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponFired_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "WeaponFired",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponReload_RoundStats_MatchId_Round",
                table: "WeaponReload",
                columns: new[] { "MatchId", "Round" },
                principalTable: "RoundStats",
                principalColumns: new[] { "MatchId", "Round" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponReload_PlayerRoundStats_MatchId_Round_PlayerId",
                table: "WeaponReload",
                columns: new[] { "MatchId", "Round", "PlayerId" },
                principalTable: "PlayerRoundStats",
                principalColumns: new[] { "MatchId", "Round", "PlayerId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
