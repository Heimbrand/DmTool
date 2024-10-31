using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DmTool.Efc.Sql.Migrations
{
    /// <inheritdoc />
    public partial class updatedCharacterTableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Race",
                table: "Characters");
        }
    }
}
