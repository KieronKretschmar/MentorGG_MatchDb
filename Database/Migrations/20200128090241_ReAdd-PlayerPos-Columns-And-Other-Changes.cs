using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class ReAddPlayerPosColumnsAndOtherChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Refrag");

            migrationBuilder.DropColumn(
                name: "PlayerState",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "PathId",
                table: "PlayerRoundStats");

            migrationBuilder.DropColumn(
                name: "NadeType",
                table: "FireNade");

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "WeaponReload",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "WeaponReload",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "WeaponReload",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "IsDucking",
                table: "WeaponFired",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "WeaponFired",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "WeaponFired",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "WeaponFired",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloX",
                table: "WeaponFired",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloY",
                table: "WeaponFired",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloZ",
                table: "WeaponFired",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosX",
                table: "Smoke",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosY",
                table: "Smoke",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosZ",
                table: "Smoke",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "DetonationZoneByTeam",
                table: "Smoke",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LineUp",
                table: "Smoke",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Smoke",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Smoke",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Smoke",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<byte>(
                name: "ArmorType",
                table: "PlayerRoundStats",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<bool>(
                name: "IsCt",
                table: "PlayerPosition",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "PlayerPosition",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "PlayerPosition",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "PlayerPosition",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloX",
                table: "PlayerPosition",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloY",
                table: "PlayerPosition",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloZ",
                table: "PlayerPosition",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<byte>(
                name: "Source",
                table: "MatchStats",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "AssisterPosX",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AssisterPosY",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AssisterPosZ",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosX",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosY",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosZ",
                table: "Kills",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosX",
                table: "HostageRescue",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosY",
                table: "HostageRescue",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosZ",
                table: "HostageRescue",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosX",
                table: "HostagePickUp",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosY",
                table: "HostagePickUp",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosZ",
                table: "HostagePickUp",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosX",
                table: "HostageDrop",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosY",
                table: "HostageDrop",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosZ",
                table: "HostageDrop",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosX",
                table: "He",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosY",
                table: "He",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosZ",
                table: "He",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "He",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "He",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "He",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosX",
                table: "Flashed",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosY",
                table: "Flashed",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosZ",
                table: "Flashed",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosX",
                table: "Flash",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosY",
                table: "Flash",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosZ",
                table: "Flash",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Flash",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Flash",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Flash",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosX",
                table: "FireNade",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosY",
                table: "FireNade",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosZ",
                table: "FireNade",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "FireNade",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "FireNade",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "FireNade",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosX",
                table: "Decoy",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosY",
                table: "Decoy",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DetonationPosZ",
                table: "Decoy",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "DetonationZoneByTeam",
                table: "Decoy",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Decoy",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Decoy",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Decoy",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Damage",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Damage",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Damage",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosX",
                table: "Damage",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosY",
                table: "Damage",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosZ",
                table: "Damage",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosX",
                table: "BombPlant",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosY",
                table: "BombPlant",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosZ",
                table: "BombPlant",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "WeaponReload");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "WeaponReload");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "WeaponReload");

            migrationBuilder.DropColumn(
                name: "IsDucking",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "PlayerVeloX",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "PlayerVeloY",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "PlayerVeloZ",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "DetonationPosX",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "DetonationPosY",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "DetonationPosZ",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "DetonationZoneByTeam",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "LineUp",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "IsCt",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PlayerVeloX",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PlayerVeloY",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "PlayerVeloZ",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "AssisterPosX",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "AssisterPosY",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "AssisterPosZ",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "VictimPosX",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "VictimPosY",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "VictimPosZ",
                table: "Kills");

            migrationBuilder.DropColumn(
                name: "PosX",
                table: "HostageRescue");

            migrationBuilder.DropColumn(
                name: "PosY",
                table: "HostageRescue");

            migrationBuilder.DropColumn(
                name: "PosZ",
                table: "HostageRescue");

            migrationBuilder.DropColumn(
                name: "PosX",
                table: "HostagePickUp");

            migrationBuilder.DropColumn(
                name: "PosY",
                table: "HostagePickUp");

            migrationBuilder.DropColumn(
                name: "PosZ",
                table: "HostagePickUp");

            migrationBuilder.DropColumn(
                name: "PosX",
                table: "HostageDrop");

            migrationBuilder.DropColumn(
                name: "PosY",
                table: "HostageDrop");

            migrationBuilder.DropColumn(
                name: "PosZ",
                table: "HostageDrop");

            migrationBuilder.DropColumn(
                name: "DetonationPosX",
                table: "He");

            migrationBuilder.DropColumn(
                name: "DetonationPosY",
                table: "He");

            migrationBuilder.DropColumn(
                name: "DetonationPosZ",
                table: "He");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "He");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "He");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "He");

            migrationBuilder.DropColumn(
                name: "VictimPosX",
                table: "Flashed");

            migrationBuilder.DropColumn(
                name: "VictimPosY",
                table: "Flashed");

            migrationBuilder.DropColumn(
                name: "VictimPosZ",
                table: "Flashed");

            migrationBuilder.DropColumn(
                name: "DetonationPosX",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "DetonationPosY",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "DetonationPosZ",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "DetonationPosX",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "DetonationPosY",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "DetonationPosZ",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "DetonationPosX",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "DetonationPosY",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "DetonationPosZ",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "DetonationZoneByTeam",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "PlayerPosX",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "PlayerPosY",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "PlayerPosZ",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "VictimPosX",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "VictimPosY",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "VictimPosZ",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "PosX",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "PosY",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "PosZ",
                table: "BombPlant");

            migrationBuilder.AddColumn<short>(
                name: "PlayerState",
                table: "WeaponFired",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Smoke",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "ArmorType",
                table: "PlayerRoundStats",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "PathId",
                table: "PlayerRoundStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Source",
                table: "MatchStats",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<byte>(
                name: "NadeType",
                table: "FireNade",
                type: "tinyint unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "Refrag",
                columns: table => new
                {
                    MatchId = table.Column<long>(type: "bigint", nullable: false),
                    KillId = table.Column<long>(type: "bigint", nullable: false),
                    RefraggedKillId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refrag", x => new { x.MatchId, x.KillId });
                    table.ForeignKey(
                        name: "FK_Refrag_MatchStats_MatchId",
                        column: x => x.MatchId,
                        principalTable: "MatchStats",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refrag_Kills_MatchId_KillId",
                        columns: x => new { x.MatchId, x.KillId },
                        principalTable: "Kills",
                        principalColumns: new[] { "MatchId", "KillId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refrag_Kills_MatchId_RefraggedKillId",
                        columns: x => new { x.MatchId, x.RefraggedKillId },
                        principalTable: "Kills",
                        principalColumns: new[] { "MatchId", "KillId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Refrag_MatchId",
                table: "Refrag",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Refrag_MatchId_KillId",
                table: "Refrag",
                columns: new[] { "MatchId", "KillId" });

            migrationBuilder.CreateIndex(
                name: "IX_Refrag_MatchId_RefraggedKillId",
                table: "Refrag",
                columns: new[] { "MatchId", "RefraggedKillId" });
        }
    }
}
