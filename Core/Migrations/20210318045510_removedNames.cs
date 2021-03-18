using Microsoft.EntityFrameworkCore.Migrations;

namespace FrisbeeApplication.Data.Migrations
{
    public partial class removedNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_FirstNames_FirstNameId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_LastNames_LastNameId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "FirstNames");

            migrationBuilder.DropTable(
                name: "LastNames");

            migrationBuilder.DropIndex(
                name: "IX_Players_FirstNameId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_LastNameId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "FirstNameId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "LastNameId",
                table: "Players");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Players",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Players");

            migrationBuilder.AddColumn<long>(
                name: "FirstNameId",
                table: "Players",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LastNameId",
                table: "Players",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "FirstNames",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LastNames",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastNames", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_FirstNameId",
                table: "Players",
                column: "FirstNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_LastNameId",
                table: "Players",
                column: "LastNameId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Players_FirstNames_FirstNameId",
                table: "Players",
                column: "FirstNameId",
                principalTable: "FirstNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_LastNames_LastNameId",
                table: "Players",
                column: "LastNameId",
                principalTable: "LastNames",
                principalColumn: "Id");
        }
    }
}
