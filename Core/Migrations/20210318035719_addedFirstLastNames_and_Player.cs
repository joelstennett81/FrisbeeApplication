using Microsoft.EntityFrameworkCore.Migrations;

namespace FrisbeeApplication.Data.Migrations
{
    public partial class addedFirstLastNames_and_Player : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirstNames",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LastNames",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNameId = table.Column<long>(nullable: false),
                    LastNameId = table.Column<long>(nullable: false),
                    JerseyNumber = table.Column<string>(nullable: true),
                    Overall = table.Column<int>(nullable: false),
                    IsHandle = table.Column<bool>(nullable: false),
                    HasDisc = table.Column<bool>(nullable: false),
                    ThrowAbility = table.Column<int>(nullable: false),
                    GameGoals = table.Column<int>(nullable: false),
                    SeasonGoals = table.Column<int>(nullable: false),
                    GameAssists = table.Column<int>(nullable: false),
                    SeasonAssists = table.Column<int>(nullable: false),
                    CutAbility = table.Column<int>(nullable: false),
                    TeamNameAndMascot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_FirstNames_FirstNameId",
                        column: x => x.FirstNameId,
                        principalTable: "FirstNames",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_LastNames_LastNameId",
                        column: x => x.LastNameId,
                        principalTable: "LastNames",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FirstNames_Id",
                table: "FirstNames",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LastNames_Id",
                table: "LastNames",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_FirstNameId",
                table: "Players",
                column: "FirstNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_Id",
                table: "Players",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_LastNameId",
                table: "Players",
                column: "LastNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "FirstNames");

            migrationBuilder.DropTable(
                name: "LastNames");
        }
    }
}
