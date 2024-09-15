using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherApplication.DataAccess.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "XmlData",
                table: "WeatherReportXmls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "XmlData",
                table: "WeatherReportXmls");
        }
    }
}
