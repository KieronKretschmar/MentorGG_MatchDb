using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class PositionsToVector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "GrenadePosX",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "GrenadePosY",
                table: "Smoke");

            migrationBuilder.DropColumn(
                name: "GrenadePosZ",
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
                name: "GrenadePosX",
                table: "He");

            migrationBuilder.DropColumn(
                name: "GrenadePosY",
                table: "He");

            migrationBuilder.DropColumn(
                name: "GrenadePosZ",
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
                name: "GrenadePosX",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "GrenadePosY",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "GrenadePosZ",
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
                name: "GrenadePosX",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "GrenadePosY",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "GrenadePosZ",
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
                name: "GrenadePosX",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "GrenadePosY",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "GrenadePosZ",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "WeaponReload",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "WeaponReload",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "WeaponReload",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "WeaponFired",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "WeaponFired",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "WeaponFired",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloX",
                table: "WeaponFired",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloY",
                table: "WeaponFired",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloZ",
                table: "WeaponFired",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosX",
                table: "Smoke",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosY",
                table: "Smoke",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosZ",
                table: "Smoke",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Smoke",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Smoke",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Smoke",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "PlayerPosition",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "PlayerPosition",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "PlayerPosition",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloX",
                table: "PlayerPosition",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloY",
                table: "PlayerPosition",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerVeloZ",
                table: "PlayerPosition",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AssisterPosX",
                table: "Kills",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "AssisterPosY",
                table: "Kills",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "AssisterPosZ",
                table: "Kills",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Kills",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Kills",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Kills",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosX",
                table: "Kills",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosY",
                table: "Kills",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosZ",
                table: "Kills",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosX",
                table: "HostageRescue",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosY",
                table: "HostageRescue",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosZ",
                table: "HostageRescue",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosX",
                table: "HostagePickUp",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosY",
                table: "HostagePickUp",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosZ",
                table: "HostagePickUp",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosX",
                table: "HostageDrop",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosY",
                table: "HostageDrop",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosZ",
                table: "HostageDrop",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosX",
                table: "He",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosY",
                table: "He",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosZ",
                table: "He",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "He",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "He",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "He",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosX",
                table: "Flashed",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosY",
                table: "Flashed",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosZ",
                table: "Flashed",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosX",
                table: "Flash",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosY",
                table: "Flash",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosZ",
                table: "Flash",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Flash",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Flash",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Flash",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosX",
                table: "FireNade",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosY",
                table: "FireNade",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosZ",
                table: "FireNade",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "FireNade",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "FireNade",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "FireNade",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosX",
                table: "Decoy",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosY",
                table: "Decoy",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GrenadePosZ",
                table: "Decoy",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Decoy",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Decoy",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Decoy",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosX",
                table: "Damage",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosY",
                table: "Damage",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PlayerPosZ",
                table: "Damage",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosX",
                table: "Damage",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosY",
                table: "Damage",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VictimPosZ",
                table: "Damage",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosX",
                table: "BombPlant",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosY",
                table: "BombPlant",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosZ",
                table: "BombPlant",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
