using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DmTool.Efc.Sql.Migrations
{
    /// <inheritdoc />
    public partial class pntsecp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmorClass",
                table: "Characters",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArmorClass",
                table: "Characters");
        }
    }
}
