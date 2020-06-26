using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class saveresources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tick",
                table: "WeaponReload");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "WeaponFired");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "Smoke");

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
                name: "Tick",
                table: "PlayerPosition");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "Kill");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "ItemPickedUp");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "ItemDropped");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "HostageRescue");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "HostagePickUp");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "HostageDrop");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "He");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "Flash");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "FireNade");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "Decoy");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "BombPlant");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "BombExplosion");

            migrationBuilder.DropColumn(
                name: "Tick",
                table: "BombDefused");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "WeaponReload",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "WeaponFired",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "Smoke",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "WinType",
                table: "RoundStats",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "RoundStats",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "RoundItem",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "PlayerRoundStats",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "PlayerPosition",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "Kill",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "ItemSaved",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "ItemPickedUp",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "ItemDropped",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "HostageRescue",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "HostagePickUp",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "HostageDrop",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "He",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "Flashed",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "Flash",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "FireNade",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "Decoy",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "Damage",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "ConnectDisconnect",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "BotTakeOver",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "BombPlant",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "BombExplosion",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "Round",
                table: "BombDefused",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "WeaponReload",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "WeaponReload",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "WeaponFired",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "WeaponFired",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "Smoke",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "Smoke",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<byte>(
                name: "WinType",
                table: "RoundStats",
                type: "tinyint unsigned",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "RoundStats",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "RoundItem",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "PlayerRoundStats",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "PlayerPosition",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

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

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "PlayerPosition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "Kill",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "Kill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "ItemSaved",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "ItemPickedUp",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "ItemPickedUp",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "ItemDropped",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "ItemDropped",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "HostageRescue",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "HostageRescue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "HostagePickUp",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "HostagePickUp",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "HostageDrop",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "HostageDrop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "He",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "He",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "Flashed",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "Flash",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "Flash",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "FireNade",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "FireNade",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "Decoy",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "Decoy",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "Damage",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "Damage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "ConnectDisconnect",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "BotTakeOver",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "BombPlant",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "BombPlant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "BombExplosion",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "BombExplosion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<short>(
                name: "Round",
                table: "BombDefused",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "Tick",
                table: "BombDefused",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
