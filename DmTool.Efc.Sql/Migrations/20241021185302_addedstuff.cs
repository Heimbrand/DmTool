using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DmTool.Efc.Sql.Migrations
{
    /// <inheritdoc />
    public partial class addedstuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Players_CharacterId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_AspNetUsers_UserId1",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ItemOutcomes",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Characters");

            migrationBuilder.RenameIndex(
                name: "IX_Players_UserId1",
                table: "Characters",
                newName: "IX_Characters_UserId1");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AspNetUsers_UserId1",
                table: "Characters",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Characters_CharacterId",
                table: "Items",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AspNetUsers_UserId1",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Characters_CharacterId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "Players");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_UserId1",
                table: "Players",
                newName: "IX_Players_UserId1");

            migrationBuilder.AddColumn<string>(
                name: "ItemOutcomes",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

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
    }
}
