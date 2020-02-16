using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class addanalyzerconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Config_FramesPerSecond",
                table: "MatchStats",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Config_Quality",
                table: "MatchStats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Config_FramesPerSecond",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "Config_Quality",
                table: "MatchStats");
        }
    }
}
