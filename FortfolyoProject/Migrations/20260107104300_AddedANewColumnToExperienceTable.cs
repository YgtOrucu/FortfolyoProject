using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FortfolyoProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedANewColumnToExperienceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UseTechnology",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseTechnology",
                table: "Experiences");
        }
    }
}
