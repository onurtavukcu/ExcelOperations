using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelOperations.Migrations
{
    /// <inheritdoc />
    public partial class migv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZustandigeRegion",
                table: "ZugangsdatenAktuell",
                newName: "Zustandige_Region");

            migrationBuilder.RenameColumn(
                name: "StandortdesTresors",
                table: "ZugangsdatenAktuell",
                newName: "Standort_des_Tresors");

            migrationBuilder.RenameColumn(
                name: "RechtswertGK3",
                table: "ZugangsdatenAktuell",
                newName: "Rechtswert_GK3");

            migrationBuilder.RenameColumn(
                name: "OstlLangeWGS84",
                table: "ZugangsdatenAktuell",
                newName: "Ostl_Lange_WGS84");

            migrationBuilder.RenameColumn(
                name: "NordlBreiteWGS84",
                table: "ZugangsdatenAktuell",
                newName: "Nordl_Breite_WGS84");

            migrationBuilder.RenameColumn(
                name: "HochwertGK3",
                table: "ZugangsdatenAktuell",
                newName: "Hochwert_GK3");

            migrationBuilder.RenameColumn(
                name: "Gebäudeart",
                table: "ZugangsdatenAktuell",
                newName: "Gebaudeart");

            migrationBuilder.RenameColumn(
                name: "DatumderSchliebung",
                table: "ZugangsdatenAktuell",
                newName: "Datum_der_Schliebung");

            migrationBuilder.RenameColumn(
                name: "COOPTausch",
                table: "ZugangsdatenAktuell",
                newName: "COOP_Tausch");

            migrationBuilder.RenameColumn(
                name: "COOPStatus",
                table: "ZugangsdatenAktuell",
                newName: "COOP_Status");

            migrationBuilder.RenameColumn(
                name: "COOPContract",
                table: "ZugangsdatenAktuell",
                newName: "COOP_Contract");

            migrationBuilder.RenameColumn(
                name: "ZustandigeRegion",
                table: "XWDMAktuells",
                newName: "Zustandige_Region");

            migrationBuilder.RenameColumn(
                name: "ZieldesProjekts",
                table: "XWDMAktuells",
                newName: "Ziel_des_Projekts");

            migrationBuilder.RenameColumn(
                name: "VerantwOrganisationseinheit",
                table: "XWDMAktuells",
                newName: "Verantw_Organisationseinheit");

            migrationBuilder.RenameColumn(
                name: "TemplateBezeichnung",
                table: "XWDMAktuells",
                newName: "Template_Bezeichnung");

            migrationBuilder.RenameColumn(
                name: "ProjektID",
                table: "XWDMAktuells",
                newName: "Projekt_ID");

            migrationBuilder.RenameColumn(
                name: "NRGTransition",
                table: "XWDMAktuells",
                newName: "NRG_Transition");

            migrationBuilder.RenameColumn(
                name: "KapazitatWDM",
                table: "XWDMAktuells",
                newName: "Kapazitat_WDM");

            migrationBuilder.RenameColumn(
                name: "Gebäudeart",
                table: "XWDMAktuells",
                newName: "Gebaudeart");

            migrationBuilder.RenameColumn(
                name: "Dim_Squads",
                table: "XWDMAktuells",
                newName: "Dim_Squads_MAC");

            migrationBuilder.RenameColumn(
                name: "Dim_POCProjekt",
                table: "XWDMAktuells",
                newName: "Dim_POC_Projekt");

            migrationBuilder.RenameColumn(
                name: "Dim_OSPFRule",
                table: "XWDMAktuells",
                newName: "Dim_OSPF_Rule");

            migrationBuilder.RenameColumn(
                name: "BudgetDatum",
                table: "XWDMAktuells",
                newName: "Budget_Datum");

            migrationBuilder.RenameColumn(
                name: "aktuell",
                table: "RouterSwapAktuells",
                newName: "Aktuell");

            migrationBuilder.RenameColumn(
                name: "geplantesEnde",
                table: "RouterSwapAktuells",
                newName: "geplantes_Ende");

            migrationBuilder.RenameColumn(
                name: "dim_OSPFRulexakta",
                table: "RouterSwapAktuells",
                newName: "dim_OSPF_Rule_xakta");

            migrationBuilder.RenameColumn(
                name: "ZuständigeRegion",
                table: "RouterSwapAktuells",
                newName: "Zustandige_Region");

            migrationBuilder.RenameColumn(
                name: "VerbindlicherJSLRouter",
                table: "RouterSwapAktuells",
                newName: "Verbindlicher_JSL_Router");

            migrationBuilder.RenameColumn(
                name: "TemplateBezeichnung",
                table: "RouterSwapAktuells",
                newName: "Template_Bezeichnung");

            migrationBuilder.RenameColumn(
                name: "StandortKlasse",
                table: "RouterSwapAktuells",
                newName: "Standort_Klasse");

            migrationBuilder.RenameColumn(
                name: "Routerneu",
                table: "RouterSwapAktuells",
                newName: "Router_neu");

            migrationBuilder.RenameColumn(
                name: "Routeralt",
                table: "RouterSwapAktuells",
                newName: "Router_alt");

            migrationBuilder.RenameColumn(
                name: "ProjektID",
                table: "RouterSwapAktuells",
                newName: "Projekt_ID");

            migrationBuilder.RenameColumn(
                name: "POCProjekt",
                table: "RouterSwapAktuells",
                newName: "POC_Projekt");

            migrationBuilder.RenameColumn(
                name: "POCBEnde",
                table: "RouterSwapAktuells",
                newName: "POC_B_Ende");

            migrationBuilder.RenameColumn(
                name: "Linda_StatusLeitung",
                table: "RouterSwapAktuells",
                newName: "Linda_Status_Leitung");

            migrationBuilder.RenameColumn(
                name: "FNE_VerantwOrg",
                table: "RouterSwapAktuells",
                newName: "FNE_Verantw_Org");

            migrationBuilder.RenameColumn(
                name: "FNE_TemplateBezeichnung",
                table: "RouterSwapAktuells",
                newName: "FNE_Template_Bezeichnung");

            migrationBuilder.RenameColumn(
                name: "FNE_ProjektID",
                table: "RouterSwapAktuells",
                newName: "FNE_Projekt_ID");

            migrationBuilder.RenameColumn(
                name: "FNE_POCProjekt",
                table: "RouterSwapAktuells",
                newName: "FNE_POC_Projekt");

            migrationBuilder.RenameColumn(
                name: "Dim_SquadsMAC",
                table: "RouterSwapAktuells",
                newName: "Dim_Squads_MAC");

            migrationBuilder.RenameColumn(
                name: "AuftragnehmerSystemtechnik",
                table: "RouterSwapAktuells",
                newName: "Auftragnehmer_Systemtechnik");

            migrationBuilder.RenameColumn(
                name: "ZustandigeRegion",
                table: "RouterAktuell",
                newName: "Zustandige_Region");

            migrationBuilder.RenameColumn(
                name: "SONumber",
                table: "RouterAktuell",
                newName: "SO_Nr");

            migrationBuilder.RenameColumn(
                name: "Dim_Squads",
                table: "RouterAktuell",
                newName: "Dim_Squads_MAC");

            migrationBuilder.RenameColumn(
                name: "Dim_OSPF",
                table: "RouterAktuell",
                newName: "Dim_OSPF_Rule");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Zustandige_Region",
                table: "ZugangsdatenAktuell",
                newName: "ZustandigeRegion");

            migrationBuilder.RenameColumn(
                name: "Standort_des_Tresors",
                table: "ZugangsdatenAktuell",
                newName: "StandortdesTresors");

            migrationBuilder.RenameColumn(
                name: "Rechtswert_GK3",
                table: "ZugangsdatenAktuell",
                newName: "RechtswertGK3");

            migrationBuilder.RenameColumn(
                name: "Ostl_Lange_WGS84",
                table: "ZugangsdatenAktuell",
                newName: "OstlLangeWGS84");

            migrationBuilder.RenameColumn(
                name: "Nordl_Breite_WGS84",
                table: "ZugangsdatenAktuell",
                newName: "NordlBreiteWGS84");

            migrationBuilder.RenameColumn(
                name: "Hochwert_GK3",
                table: "ZugangsdatenAktuell",
                newName: "HochwertGK3");

            migrationBuilder.RenameColumn(
                name: "Gebaudeart",
                table: "ZugangsdatenAktuell",
                newName: "Gebäudeart");

            migrationBuilder.RenameColumn(
                name: "Datum_der_Schliebung",
                table: "ZugangsdatenAktuell",
                newName: "DatumderSchliebung");

            migrationBuilder.RenameColumn(
                name: "COOP_Tausch",
                table: "ZugangsdatenAktuell",
                newName: "COOPTausch");

            migrationBuilder.RenameColumn(
                name: "COOP_Status",
                table: "ZugangsdatenAktuell",
                newName: "COOPStatus");

            migrationBuilder.RenameColumn(
                name: "COOP_Contract",
                table: "ZugangsdatenAktuell",
                newName: "COOPContract");

            migrationBuilder.RenameColumn(
                name: "Zustandige_Region",
                table: "XWDMAktuells",
                newName: "ZustandigeRegion");

            migrationBuilder.RenameColumn(
                name: "Ziel_des_Projekts",
                table: "XWDMAktuells",
                newName: "ZieldesProjekts");

            migrationBuilder.RenameColumn(
                name: "Verantw_Organisationseinheit",
                table: "XWDMAktuells",
                newName: "VerantwOrganisationseinheit");

            migrationBuilder.RenameColumn(
                name: "Template_Bezeichnung",
                table: "XWDMAktuells",
                newName: "TemplateBezeichnung");

            migrationBuilder.RenameColumn(
                name: "Projekt_ID",
                table: "XWDMAktuells",
                newName: "ProjektID");

            migrationBuilder.RenameColumn(
                name: "NRG_Transition",
                table: "XWDMAktuells",
                newName: "NRGTransition");

            migrationBuilder.RenameColumn(
                name: "Kapazitat_WDM",
                table: "XWDMAktuells",
                newName: "KapazitatWDM");

            migrationBuilder.RenameColumn(
                name: "Gebaudeart",
                table: "XWDMAktuells",
                newName: "Gebäudeart");

            migrationBuilder.RenameColumn(
                name: "Dim_Squads_MAC",
                table: "XWDMAktuells",
                newName: "Dim_Squads");

            migrationBuilder.RenameColumn(
                name: "Dim_POC_Projekt",
                table: "XWDMAktuells",
                newName: "Dim_POCProjekt");

            migrationBuilder.RenameColumn(
                name: "Dim_OSPF_Rule",
                table: "XWDMAktuells",
                newName: "Dim_OSPFRule");

            migrationBuilder.RenameColumn(
                name: "Budget_Datum",
                table: "XWDMAktuells",
                newName: "BudgetDatum");

            migrationBuilder.RenameColumn(
                name: "Aktuell",
                table: "RouterSwapAktuells",
                newName: "aktuell");

            migrationBuilder.RenameColumn(
                name: "geplantes_Ende",
                table: "RouterSwapAktuells",
                newName: "geplantesEnde");

            migrationBuilder.RenameColumn(
                name: "dim_OSPF_Rule_xakta",
                table: "RouterSwapAktuells",
                newName: "dim_OSPFRulexakta");

            migrationBuilder.RenameColumn(
                name: "Zustandige_Region",
                table: "RouterSwapAktuells",
                newName: "ZuständigeRegion");

            migrationBuilder.RenameColumn(
                name: "Verbindlicher_JSL_Router",
                table: "RouterSwapAktuells",
                newName: "VerbindlicherJSLRouter");

            migrationBuilder.RenameColumn(
                name: "Template_Bezeichnung",
                table: "RouterSwapAktuells",
                newName: "TemplateBezeichnung");

            migrationBuilder.RenameColumn(
                name: "Standort_Klasse",
                table: "RouterSwapAktuells",
                newName: "StandortKlasse");

            migrationBuilder.RenameColumn(
                name: "Router_neu",
                table: "RouterSwapAktuells",
                newName: "Routerneu");

            migrationBuilder.RenameColumn(
                name: "Router_alt",
                table: "RouterSwapAktuells",
                newName: "Routeralt");

            migrationBuilder.RenameColumn(
                name: "Projekt_ID",
                table: "RouterSwapAktuells",
                newName: "ProjektID");

            migrationBuilder.RenameColumn(
                name: "POC_Projekt",
                table: "RouterSwapAktuells",
                newName: "POCProjekt");

            migrationBuilder.RenameColumn(
                name: "POC_B_Ende",
                table: "RouterSwapAktuells",
                newName: "POCBEnde");

            migrationBuilder.RenameColumn(
                name: "Linda_Status_Leitung",
                table: "RouterSwapAktuells",
                newName: "Linda_StatusLeitung");

            migrationBuilder.RenameColumn(
                name: "FNE_Verantw_Org",
                table: "RouterSwapAktuells",
                newName: "FNE_VerantwOrg");

            migrationBuilder.RenameColumn(
                name: "FNE_Template_Bezeichnung",
                table: "RouterSwapAktuells",
                newName: "FNE_TemplateBezeichnung");

            migrationBuilder.RenameColumn(
                name: "FNE_Projekt_ID",
                table: "RouterSwapAktuells",
                newName: "FNE_ProjektID");

            migrationBuilder.RenameColumn(
                name: "FNE_POC_Projekt",
                table: "RouterSwapAktuells",
                newName: "FNE_POCProjekt");

            migrationBuilder.RenameColumn(
                name: "Dim_Squads_MAC",
                table: "RouterSwapAktuells",
                newName: "Dim_SquadsMAC");

            migrationBuilder.RenameColumn(
                name: "Auftragnehmer_Systemtechnik",
                table: "RouterSwapAktuells",
                newName: "AuftragnehmerSystemtechnik");

            migrationBuilder.RenameColumn(
                name: "Zustandige_Region",
                table: "RouterAktuell",
                newName: "ZustandigeRegion");

            migrationBuilder.RenameColumn(
                name: "SO_Nr",
                table: "RouterAktuell",
                newName: "SONumber");

            migrationBuilder.RenameColumn(
                name: "Dim_Squads_MAC",
                table: "RouterAktuell",
                newName: "Dim_Squads");

            migrationBuilder.RenameColumn(
                name: "Dim_OSPF_Rule",
                table: "RouterAktuell",
                newName: "Dim_OSPF");
        }
    }
}
