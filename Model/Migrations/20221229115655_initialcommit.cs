using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class initialcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "E_CONNECTION_TYPE",
                columns: table => new
                {
                    VALUE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E_CONNECTION_TYPE", x => x.VALUE);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PLACES",
                columns: table => new
                {
                    PLACEID = table.Column<int>(name: "PLACE_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ROOM = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PLACECOLUMN = table.Column<string>(name: "PLACE_COLUMN", type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PLACEROW = table.Column<string>(name: "PLACE_ROW", type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLACES", x => x.PLACEID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ROLES",
                columns: table => new
                {
                    ROLEID = table.Column<int>(name: "ROLE_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDENTIFIER = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLES", x => x.ROLEID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    USERNAME = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PASSWORDHASH = table.Column<string>(name: "PASSWORD_HASH", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.USERID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CABLE_ENDS",
                columns: table => new
                {
                    CABLEENDID = table.Column<int>(name: "CABLE_END_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ISMALE = table.Column<sbyte>(name: "IS_MALE", type: "TINYINT", nullable: false),
                    CONNECTIONTYPE = table.Column<string>(name: "CONNECTION_TYPE", type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABLE_ENDS", x => x.CABLEENDID);
                    table.ForeignKey(
                        name: "FK_CABLE_ENDS_E_CONNECTION_TYPE_CONNECTION_TYPE",
                        column: x => x.CONNECTIONTYPE,
                        principalTable: "E_CONNECTION_TYPE",
                        principalColumn: "VALUE",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "THINGS",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PLACEID = table.Column<int>(name: "PLACE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THINGS", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_THINGS_PLACES_PLACE_ID",
                        column: x => x.PLACEID,
                        principalTable: "PLACES",
                        principalColumn: "PLACE_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USER_HAS_ROLES_JT",
                columns: table => new
                {
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false),
                    ROLEID = table.Column<int>(name: "ROLE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_HAS_ROLES_JT", x => new { x.USERID, x.ROLEID });
                    table.ForeignKey(
                        name: "FK_USER_HAS_ROLES_JT_ROLES_ROLE_ID",
                        column: x => x.ROLEID,
                        principalTable: "ROLES",
                        principalColumn: "ROLE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_HAS_ROLES_JT_USERS_USER_ID",
                        column: x => x.USERID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ELECTRONICS",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ELECTRONICS", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_ELECTRONICS_THINGS_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "THINGS",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CABLES",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false),
                    LENGTH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABLES", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_CABLES_ELECTRONICS_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "ELECTRONICS",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ADAPTERS",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADAPTERS", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_ADAPTERS_CABLES_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "CABLES",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CABLE_HAS_ENDS_JT",
                columns: table => new
                {
                    CABLEID = table.Column<int>(name: "CABLE_ID", type: "int", nullable: false),
                    ENDID = table.Column<int>(name: "END_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABLE_HAS_ENDS_JT", x => new { x.CABLEID, x.ENDID });
                    table.ForeignKey(
                        name: "FK_CABLE_HAS_ENDS_JT_CABLES_CABLE_ID",
                        column: x => x.CABLEID,
                        principalTable: "CABLES",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CABLE_HAS_ENDS_JT_CABLE_ENDS_END_ID",
                        column: x => x.ENDID,
                        principalTable: "CABLE_ENDS",
                        principalColumn: "CABLE_END_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHARGING_CABLES",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHARGING_CABLES", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_CHARGING_CABLES_CABLES_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "CABLES",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HUBS",
                columns: table => new
                {
                    THINGID = table.Column<int>(name: "THING_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HUBS", x => x.THINGID);
                    table.ForeignKey(
                        name: "FK_HUBS_CABLES_THING_ID",
                        column: x => x.THINGID,
                        principalTable: "CABLES",
                        principalColumn: "THING_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ROLES",
                columns: new[] { "ROLE_ID", "DESCRIPTION", "IDENTIFIER" },
                values: new object[] { 1, "Administrator", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_CABLE_ENDS_CONNECTION_TYPE",
                table: "CABLE_ENDS",
                column: "CONNECTION_TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_CABLE_HAS_ENDS_JT_END_ID",
                table: "CABLE_HAS_ENDS_JT",
                column: "END_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ROLES_IDENTIFIER",
                table: "ROLES",
                column: "IDENTIFIER",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_THINGS_PLACE_ID",
                table: "THINGS",
                column: "PLACE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_HAS_ROLES_JT_ROLE_ID",
                table: "USER_HAS_ROLES_JT",
                column: "ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_EMAIL",
                table: "USERS",
                column: "EMAIL",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADAPTERS");

            migrationBuilder.DropTable(
                name: "CABLE_HAS_ENDS_JT");

            migrationBuilder.DropTable(
                name: "CHARGING_CABLES");

            migrationBuilder.DropTable(
                name: "HUBS");

            migrationBuilder.DropTable(
                name: "USER_HAS_ROLES_JT");

            migrationBuilder.DropTable(
                name: "CABLE_ENDS");

            migrationBuilder.DropTable(
                name: "CABLES");

            migrationBuilder.DropTable(
                name: "ROLES");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "E_CONNECTION_TYPE");

            migrationBuilder.DropTable(
                name: "ELECTRONICS");

            migrationBuilder.DropTable(
                name: "THINGS");

            migrationBuilder.DropTable(
                name: "PLACES");
        }
    }
}
