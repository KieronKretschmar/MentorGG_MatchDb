using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class TeamMatchStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MatchStats_DemoId",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "DemoId",
                table: "MatchStats");

            migrationBuilder.AlterColumn<byte>(
                name: "WinType",
                table: "RoundStats",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "WinType",
                table: "RoundStats",
                type: "tinyint unsigned",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<long>(
                name: "DemoId",
                table: "MatchStats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_MatchStats_DemoId",
                table: "MatchStats",
                column: "DemoId");
        }
    }
}
