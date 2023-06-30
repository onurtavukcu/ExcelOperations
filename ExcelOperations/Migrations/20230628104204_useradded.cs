using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class useradded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UserInput",
                newName: "UserInputs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UserInputs",
                newName: "UserInput");
        }
    }
}
