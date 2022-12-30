using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class initialcommit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AUDIO_CABLES",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUDIO_CABLES", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_AUDIO_CABLES_CABLES_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "CABLES",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SPECIAL_CABLES",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPECIAL_CABLES", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_SPECIAL_CABLES_CABLES_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "CABLES",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TRUNK_CABLES",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRUNK_CABLES", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_TRUNK_CABLES_CABLES_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "CABLES",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VIDEO_CABLES",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIDEO_CABLES", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_VIDEO_CABLES_CABLES_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "CABLES",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AUDIO_CABLES");

            migrationBuilder.DropTable(
                name: "SPECIAL_CABLES");

            migrationBuilder.DropTable(
                name: "TRUNK_CABLES");

            migrationBuilder.DropTable(
                name: "VIDEO_CABLES");
        }
    }
}
