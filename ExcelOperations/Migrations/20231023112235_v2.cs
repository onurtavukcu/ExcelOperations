using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "admin",
                column: "PasswordHash",
                value: "VcS9JLT3Hw1Lk8pY8PaE7BG5uxEu2eWcjXY3DxtG7VaJh73ANKDfOhZp5nXMWOC6I5QJvgPMpHKxxiEbMZY6oA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "admin",
                column: "PasswordHash",
                value: "Bw5TYuqmsI+lDSIeoRn0Jc25kwhpmkXA4aIMRt/+iSxxN0hasvQg3xM5aCptoaPTrEJrZLV2i4Iu3/9TlJmQ4w==");
        }
    }
}
