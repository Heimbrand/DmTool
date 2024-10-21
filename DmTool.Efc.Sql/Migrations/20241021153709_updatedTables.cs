using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DmTool.Efc.Sql.Migrations
{
    /// <inheritdoc />
    public partial class updatedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacterName",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Severity",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Players",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ItemOutcomes",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId1",
                table: "Players",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CharacterId",
                table: "Items",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Players_CharacterId",
                table: "Items",
                column: "CharacterId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_AspNetUsers_UserId1",
                table: "Players",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Players_CharacterId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_AspNetUsers_UserId1",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_UserId1",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Items_CharacterId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemOutcomes",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "CharacterName",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Severity",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
