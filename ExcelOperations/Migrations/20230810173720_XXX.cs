using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class XXX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "passwordHash",
                table: "UserInputs",
                newName: "PasswordHash");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "UserInputs",
                type: "text",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "bytea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "UserInputs",
                newName: "passwordHash");

            migrationBuilder.AlterColumn<byte[]>(
                name: "passwordHash",
                table: "UserInputs",
                type: "bytea",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
