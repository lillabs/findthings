using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class initialcommit4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AMPERE",
                table: "CHARGING_CABLES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VOLTAGE",
                table: "CHARGING_CABLES",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WATT",
                table: "CHARGING_CABLES",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AMPERE",
                table: "CHARGING_CABLES");

            migrationBuilder.DropColumn(
                name: "VOLTAGE",
                table: "CHARGING_CABLES");

            migrationBuilder.DropColumn(
                name: "WATT",
                table: "CHARGING_CABLES");
        }
    }
}
