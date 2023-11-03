using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class migg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "admin",
                column: "PasswordHash",
                value: "5XEwMFgstmdhbI4SmRTH4p9G+Sq1Ck+yf+iU+K9ASjtxMflhaq97YDUCXDkS3pvnkgrDhn4oI7eMYWH13p7U9A==");

            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "regular",
                column: "PasswordHash",
                value: "L0KD9M/KwiIed3pJ5LvpLGjT5ynvhfm3EJTSrtnUEgSrEfzqdJvekLn+zQmO60N9OYJBvaRcAKstj+BMcFqz1Q==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "admin",
                column: "PasswordHash",
                value: "yCCu9ZtdYNbBQvFTCMnrozHVaSQgSToVJbJZw9TUx+nEwDKKtmLlQzXNK4BvOJ1sawfBIueJil60Q8+wV1YXcQ==");

            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "regular",
                column: "PasswordHash",
                value: "azeq8DRLVq2MmJ97I0WdTLDjoOo0cbe+CiZLl7H3Q0Zl6QoTGFmDYLORZvpEih6XzzGd1KD0C7cmeOoTw0r/hQ==");
        }
    }
}
