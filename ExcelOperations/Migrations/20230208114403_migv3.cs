using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class migv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZugangsdatenAktuell",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ZustandigeRegion = table.Column<string>(type: "text", nullable: true),
                    SONr = table.Column<string>(name: "SO_Nr", type: "text", nullable: true),
                    SONrEPlus = table.Column<string>(name: "SO_Nr_EPlus", type: "text", nullable: true),
                    COOPContract = table.Column<string>(type: "text", nullable: true),
                    COOPStatus = table.Column<string>(type: "text", nullable: true),
                    COOPTausch = table.Column<string>(type: "text", nullable: true),
                    InfrastrukturSollBaseframeRadioMW = table.Column<string>(name: "Infrastruktur_Soll_Baseframe_Radio_MW", type: "text", nullable: true),
                    Netzelement = table.Column<string>(type: "text", nullable: true),
                    EquipmentSO = table.Column<string>(name: "Equipment_SO", type: "text", nullable: true),
                    Eigentümer = table.Column<string>(type: "text", nullable: true),
                    Gebäudeart = table.Column<string>(type: "text", nullable: true),
                    PLZ = table.Column<string>(type: "text", nullable: true),
                    Ort = table.Column<string>(type: "text", nullable: true),
                    Strabe = table.Column<string>(type: "text", nullable: true),
                    RechtswertGK3 = table.Column<string>(type: "text", nullable: true),
                    HochwertGK3 = table.Column<string>(type: "text", nullable: true),
                    OstlLangeWGS84 = table.Column<string>(type: "text", nullable: true),
                    NordlBreiteWGS84 = table.Column<string>(type: "text", nullable: true),
                    Zugangsmöglichkeit = table.Column<string>(type: "text", nullable: true),
                    Zugangsregelung = table.Column<string>(type: "text", nullable: true),
                    Zufahrtsbeschreibung = table.Column<string>(type: "text", nullable: true),
                    Parkplätze = table.Column<string>(type: "text", nullable: true),
                    Besonderheiten = table.Column<string>(type: "text", nullable: true),
                    Umgebungspflege = table.Column<string>(type: "text", nullable: true),
                    DatumderSchliebung = table.Column<string>(type: "text", nullable: true),
                    Schliebung = table.Column<string>(type: "text", nullable: true),
                    StandortdesTresors = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZugangsdatenAktuell", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZugangsdatenAktuell");
        }
    }
}
