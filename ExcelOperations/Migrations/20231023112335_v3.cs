using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "admin",
                column: "PasswordHash",
                value: "yCCu9ZtdYNbBQvFTCMnrozHVaSQgSToVJbJZw9TUx+nEwDKKtmLlQzXNK4BvOJ1sawfBIueJil60Q8+wV1YXcQ==");

            migrationBuilder.InsertData(
                table: "UserInputs",
                columns: new[] { "Username", "PasswordHash", "UserTypeId" },
                values: new object[] { "regular", "azeq8DRLVq2MmJ97I0WdTLDjoOo0cbe+CiZLl7H3Q0Zl6QoTGFmDYLORZvpEih6XzzGd1KD0C7cmeOoTw0r/hQ==", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "regular");

            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "admin",
                column: "PasswordHash",
                value: "VcS9JLT3Hw1Lk8pY8PaE7BG5uxEu2eWcjXY3DxtG7VaJh73ANKDfOhZp5nXMWOC6I5QJvgPMpHKxxiEbMZY6oA==");
        }
    }
}
