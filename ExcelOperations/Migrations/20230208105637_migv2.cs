using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class migv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "XWDMAktuells",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ZustandigeRegion = table.Column<string>(type: "text", nullable: true),
                    SONr = table.Column<string>(name: "SO_Nr", type: "text", nullable: true),
                    SONrEPlus = table.Column<string>(name: "SO_Nr_EPlus", type: "text", nullable: true),
                    CtKStatus = table.Column<string>(name: "CtK_Status", type: "text", nullable: true),
                    NENr = table.Column<string>(name: "NE_Nr", type: "text", nullable: true),
                    Alt = table.Column<string>(type: "text", nullable: true),
                    NEName = table.Column<string>(name: "NE_Name", type: "text", nullable: true),
                    DimSquads = table.Column<string>(name: "Dim_Squads", type: "text", nullable: true),
                    NEBemerkung = table.Column<string>(name: "NE_Bemerkung", type: "text", nullable: true),
                    NENrEPlus = table.Column<string>(name: "NE_Nr_EPlus", type: "text", nullable: true),
                    Projektstand = table.Column<string>(type: "text", nullable: true),
                    Projektart = table.Column<string>(type: "text", nullable: true),
                    TemplateBezeichnung = table.Column<string>(type: "text", nullable: true),
                    Projektbemerkung = table.Column<string>(type: "text", nullable: true),
                    ProjektID = table.Column<string>(type: "text", nullable: true),
                    Bezeichnung = table.Column<string>(type: "text", nullable: true),
                    VerantwOrganisationseinheit = table.Column<string>(type: "text", nullable: true),
                    InfrastrukturSollBaseframeRadioMW = table.Column<string>(name: "Infrastruktur_Soll_Baseframe_Radio_MW", type: "text", nullable: true),
                    ZieldesProjekts = table.Column<string>(type: "text", nullable: true),
                    MPPOC = table.Column<string>(name: "MP_POC", type: "text", nullable: true),
                    POCProjekt = table.Column<string>(name: "POC_Projekt", type: "text", nullable: true),
                    DimPOCProjekt = table.Column<string>(name: "Dim_POCProjekt", type: "text", nullable: true),
                    Demand = table.Column<string>(type: "text", nullable: true),
                    BudgetDatum = table.Column<string>(type: "text", nullable: true),
                    DimBeauftragungsform = table.Column<string>(name: "Dim_Beauftragungsform", type: "text", nullable: true),
                    NRGTransition = table.Column<string>(type: "text", nullable: true),
                    DimOSPFRule = table.Column<string>(name: "Dim_OSPFRule", type: "text", nullable: true),
                    KapazitatWDM = table.Column<string>(type: "text", nullable: true),
                    TOMPLANNINGPREPARATION = table.Column<string>(name: "TOM_PLANNING_PREPARATION", type: "text", nullable: true),
                    TOMEXECUTION = table.Column<string>(name: "TOM_EXECUTION", type: "text", nullable: true),
                    PLZ = table.Column<string>(type: "text", nullable: true),
                    Ort = table.Column<string>(type: "text", nullable: true),
                    Straße = table.Column<string>(type: "text", nullable: true),
                    Gebäudeart = table.Column<string>(type: "text", nullable: true),
                    Eigentümer = table.Column<string>(type: "text", nullable: true),
                    ProjektEquipment = table.Column<string>(name: "Projekt_Equipment", type: "text", nullable: true),
                    NEEquipmentBestand = table.Column<string>(name: "NE_Equipment_Bestand", type: "text", nullable: true),
                    NEEquipmentZiel = table.Column<string>(name: "NE_Equipment_Ziel", type: "text", nullable: true),
                    EquipmentStern = table.Column<string>(name: "Equipment_Stern", type: "text", nullable: true),
                    Festnetzplaner = table.Column<string>(type: "text", nullable: true),
                    GUProjekt = table.Column<string>(name: "GU_Projekt", type: "text", nullable: true),
                    UTSTicketamProjekt = table.Column<string>(name: "UTS_Ticket_am_Projekt", type: "text", nullable: true),
                    IstStx11 = table.Column<string>(name: "Ist_Stx11", type: "text", nullable: true),
                    Stx11Bemerkung = table.Column<string>(name: "Stx11_Bemerkung", type: "text", nullable: true),
                    IstStx29t = table.Column<string>(name: "Ist_Stx29t", type: "text", nullable: true),
                    Stx29tBemerkung = table.Column<string>(name: "Stx29t_Bemerkung", type: "text", nullable: true),
                    IstStx30 = table.Column<string>(name: "Ist_Stx30", type: "text", nullable: true),
                    Stx30Bemerkung = table.Column<string>(name: "Stx30_Bemerkung", type: "text", nullable: true),
                    IstStx43a = table.Column<string>(name: "Ist_Stx43a", type: "text", nullable: true),
                    Stx43aBemerkung = table.Column<string>(name: "Stx43a_Bemerkung", type: "text", nullable: true),
                    IstStx43c = table.Column<string>(name: "Ist_Stx43c", type: "text", nullable: true),
                    IstStx43 = table.Column<string>(name: "Ist_Stx43", type: "text", nullable: true),
                    IstStx44 = table.Column<string>(name: "Ist_Stx44", type: "text", nullable: true),
                    Stx44Bemerkung = table.Column<string>(name: "Stx44_Bemerkung", type: "text", nullable: true),
                    PlanStx48 = table.Column<string>(name: "Plan_Stx48", type: "text", nullable: true),
                    IstStx48 = table.Column<string>(name: "Ist_Stx48", type: "text", nullable: true),
                    Stx48Bemerkung = table.Column<string>(name: "Stx48_Bemerkung", type: "text", nullable: true),
                    PlanStx50 = table.Column<string>(name: "Plan_Stx50", type: "text", nullable: true),
                    IstStx50 = table.Column<string>(name: "Ist_Stx50", type: "text", nullable: true),
                    Stx50Bemerkung = table.Column<string>(name: "Stx50_Bemerkung", type: "text", nullable: true),
                    PlanStx40 = table.Column<string>(name: "Plan_Stx40", type: "text", nullable: true),
                    IstStx40 = table.Column<string>(name: "Ist_Stx40", type: "text", nullable: true),
                    Stx40Bemerkung = table.Column<string>(name: "Stx40_Bemerkung", type: "text", nullable: true),
                    IstStx40Stern = table.Column<string>(name: "Ist_Stx40Stern", type: "text", nullable: true),
                    IstStx53 = table.Column<string>(name: "Ist_Stx53", type: "text", nullable: true),
                    Stx53Bemerkung = table.Column<string>(name: "Stx53_Bemerkung", type: "text", nullable: true),
                    IstStx52r = table.Column<string>(name: "Ist_Stx52r", type: "text", nullable: true),
                    IstStx52b = table.Column<string>(name: "Ist_Stx52b", type: "text", nullable: true),
                    Stx52bBemerkung = table.Column<string>(name: "Stx52b_Bemerkung", type: "text", nullable: true),
                    IstStx62g = table.Column<string>(name: "Ist_Stx62g", type: "text", nullable: true),
                    SollStx62j = table.Column<string>(name: "Soll_Stx62j", type: "text", nullable: true),
                    PlanStx62j = table.Column<string>(name: "Plan_Stx62j", type: "text", nullable: true),
                    IstStx62j = table.Column<string>(name: "Ist_Stx62j", type: "text", nullable: true),
                    Stx62jBemerkung = table.Column<string>(name: "Stx62j_Bemerkung", type: "text", nullable: true),
                    IstStx62w = table.Column<string>(name: "Ist_Stx62w", type: "text", nullable: true),
                    Stx62wBemerkung = table.Column<string>(name: "Stx62w_Bemerkung", type: "text", nullable: true),
                    IstStx62r = table.Column<string>(name: "Ist_Stx62r", type: "text", nullable: true),
                    PlanStx59k = table.Column<string>(name: "Plan_Stx59k", type: "text", nullable: true),
                    IstStx59k = table.Column<string>(name: "Ist_Stx59k", type: "text", nullable: true),
                    Stx59kBemerkung = table.Column<string>(name: "Stx59k_Bemerkung", type: "text", nullable: true),
                    PlanStx60 = table.Column<string>(name: "Plan_Stx60", type: "text", nullable: true),
                    IstStx60 = table.Column<string>(name: "Ist_Stx60", type: "text", nullable: true),
                    Stx60Bemerkung = table.Column<string>(name: "Stx60_Bemerkung", type: "text", nullable: true),
                    IstStx59 = table.Column<string>(name: "Ist_Stx59", type: "text", nullable: true),
                    Stx59Bemerkung = table.Column<string>(name: "Stx59_Bemerkung", type: "text", nullable: true),
                    IstStx62a = table.Column<string>(name: "Ist_Stx62a", type: "text", nullable: true),
                    Stx62aBemerkung = table.Column<string>(name: "Stx62a_Bemerkung", type: "text", nullable: true),
                    IstStx51a = table.Column<string>(name: "Ist_Stx51a", type: "text", nullable: true),
                    IstStx51b = table.Column<string>(name: "Ist_Stx51b", type: "text", nullable: true),
                    Stx51bBemerkung = table.Column<string>(name: "Stx51b_Bemerkung", type: "text", nullable: true),
                    IstStx51l = table.Column<string>(name: "Ist_Stx51l", type: "text", nullable: true),
                    Stx51lBemerkung = table.Column<string>(name: "Stx51l_Bemerkung", type: "text", nullable: true),
                    IstStx51r = table.Column<string>(name: "Ist_Stx51r", type: "text", nullable: true),
                    PlanStx71 = table.Column<string>(name: "Plan_Stx71", type: "text", nullable: true),
                    IstStx71 = table.Column<string>(name: "Ist_Stx71", type: "text", nullable: true),
                    Stx71Bemerkung = table.Column<string>(name: "Stx71_Bemerkung", type: "text", nullable: true),
                    IstStx71a = table.Column<string>(name: "Ist_Stx71a", type: "text", nullable: true),
                    IstStx71b = table.Column<string>(name: "Ist_Stx71b", type: "text", nullable: true),
                    IstStx71c = table.Column<string>(name: "Ist_Stx71c", type: "text", nullable: true),
                    IstStx80 = table.Column<string>(name: "Ist_Stx80", type: "text", nullable: true),
                    Stx80Bemerkung = table.Column<string>(name: "Stx80_Bemerkung", type: "text", nullable: true),
                    IstStx87r = table.Column<string>(name: "Ist_Stx87r", type: "text", nullable: true),
                    PlanStx88i = table.Column<string>(name: "Plan_Stx88i", type: "text", nullable: true),
                    IstStx88i = table.Column<string>(name: "Ist_Stx88i", type: "text", nullable: true),
                    IstStx89 = table.Column<string>(name: "Ist_Stx89", type: "text", nullable: true),
                    SollStx90 = table.Column<string>(name: "Soll_Stx90", type: "text", nullable: true),
                    PlanStx90 = table.Column<string>(name: "Plan_Stx90", type: "text", nullable: true),
                    IstStx90 = table.Column<string>(name: "Ist_Stx90", type: "text", nullable: true),
                    Stx90Bemerkung = table.Column<string>(name: "Stx90_Bemerkung", type: "text", nullable: true),
                    PlanStx91 = table.Column<string>(name: "Plan_Stx91", type: "text", nullable: true),
                    IstStx91 = table.Column<string>(name: "Ist_Stx91", type: "text", nullable: true),
                    Stx91Bemerkung = table.Column<string>(name: "Stx91_Bemerkung", type: "text", nullable: true),
                    PlanStx91a = table.Column<string>(name: "Plan_Stx91a", type: "text", nullable: true),
                    IstStx91a = table.Column<string>(name: "Ist_Stx91a", type: "text", nullable: true),
                    Stx91aBemerkung = table.Column<string>(name: "Stx91a_Bemerkung", type: "text", nullable: true),
                    IstStx91r = table.Column<string>(name: "Ist_Stx91r", type: "text", nullable: true),
                    IstStx30n = table.Column<string>(name: "Ist_Stx30n", type: "text", nullable: true),
                    IstStx68n = table.Column<string>(name: "Ist_Stx68n", type: "text", nullable: true),
                    IstStx30o = table.Column<string>(name: "Ist_Stx30o", type: "text", nullable: true),
                    IstStx68o = table.Column<string>(name: "Ist_Stx68o", type: "text", nullable: true),
                    IstStx30p = table.Column<string>(name: "Ist_Stx30p", type: "text", nullable: true),
                    IstStx68p = table.Column<string>(name: "Ist_Stx68p", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XWDMAktuells", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XWDMAktuells");
        }
    }
}
