using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class test32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RouterAktuellXWDMAktuell",
                columns: table => new
                {
                    RouterAktuellsid = table.Column<int>(type: "integer", nullable: false),
                    XWDMAktuellsid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouterAktuellXWDMAktuell", x => new { x.RouterAktuellsid, x.XWDMAktuellsid });
                    table.ForeignKey(
                        name: "FK_RouterAktuellXWDMAktuell_RouterAktuell_RouterAktuellsid",
                        column: x => x.RouterAktuellsid,
                        principalTable: "RouterAktuell",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouterAktuellXWDMAktuell_XWDMAktuells_XWDMAktuellsid",
                        column: x => x.XWDMAktuellsid,
                        principalTable: "XWDMAktuells",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "admin",
                column: "PasswordHash",
                value: "ty8f1zmYNYVhItGRLlSOKM3jXyLNkQJObyoT3AqaQwgEbx/scZdHkTOGMysTXI/gt2t/NH+gRuNHo2s6AV0TxQ==");

            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "regular",
                column: "PasswordHash",
                value: "8KPBy5lUiwk87lJsHukn8OIk3f9DJFyWrttEaeoEcSb9DcsGhW4AEFZOtV9wvEasCeJnXn/jFclD3bS4retHsA==");

            migrationBuilder.CreateIndex(
                name: "IX_RouterAktuellXWDMAktuell_XWDMAktuellsid",
                table: "RouterAktuellXWDMAktuell",
                column: "XWDMAktuellsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RouterAktuellXWDMAktuell");

            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "admin",
                column: "PasswordHash",
                value: "e8nmCashjWJdo5TLXd2IHcjAeKU0StQthPwDoHRWdwRriNhHLQxT2ksbfaE3ZTI5SDpx805e6/8wSSZQQpiJtQ==");

            migrationBuilder.UpdateData(
                table: "UserInputs",
                keyColumn: "Username",
                keyValue: "regular",
                column: "PasswordHash",
                value: "GfBjr/yJxXAp1DA3asXMv8+yqpV2V6BGdb4YCj6mLGGBsIOQmk8s8nL+NYPFvPgBtbs+Cg4D6P3ko2xoUKCRBQ==");
        }
    }
}
