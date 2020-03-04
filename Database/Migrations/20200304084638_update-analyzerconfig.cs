using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class updateanalyzerconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Config_FramesPerSecond",
                table: "MatchStats",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Config_FramesPerSecond",
                table: "MatchStats",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);
        }
    }
}
