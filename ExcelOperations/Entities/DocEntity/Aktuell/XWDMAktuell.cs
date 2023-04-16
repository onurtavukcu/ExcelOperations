namespace ExcelOperations.DocEntity.Entity.Aktuell
{
    public class XWDMAktuell
    {
        [ColumnName("Zuständige Region")]
        public string? Zustandige_Region { get; set; }
        public string? SO_Nr { get; set; }
        public string? SO_Nr_EPlus { get; set; }

        [ColumnName("CtK-Status")]
        public string? CtK_Status { get; set; }
        public string? NE_Nr { get; set; }
        public string? Alt { get; set; }
        public string? NE_Name { get; set; }

        [ColumnName("Dim_Squads MAC")]
        public string? Dim_Squads_MAC { get; set; }
        public string? NE_Bemerkung { get; set; }
        public string? NE_Nr_EPlus { get; set; }
        public string? Projektstand { get; set; }
        public string? Projektart { get; set; }

        [ColumnName("Template-Bezeichnung")]
        public string? Template_Bezeichnung { get; set; }
        public string? Projektbemerkung { get; set; }

        [ColumnName("Projekt-ID")]
        public string? Projekt_ID { get; set; } // project
        public string? Bezeichnung { get; set; }

        [ColumnName("Verantw Organisationseinheit")]
        public string? Verantw_Organisationseinheit { get; set; }
        public string? Infrastruktur_Soll_Baseframe_Radio_MW { get; set; }

        [ColumnName("Ziel des Projekts")]
        public string? Ziel_des_Projekts { get; set; }
        public string? MP_POC { get; set; }
        public string? POC_Projekt { get; set; }

        [ColumnName("Dim_POC-Projekt")]
        public string? Dim_POC_Projekt { get; set; }
        public string? Demand { get; set; }

        [ColumnName("Budget Datum")]
        public string? Budget_Datum { get; set; }
        public string? Dim_Beauftragungsform { get; set; }

        [ColumnName("NRG-Transition")]
        public string? NRG_Transition { get; set; }

        [ColumnName("Dim_OSPF Rule")]
        public string? Dim_OSPF_Rule { get; set; }

        [ColumnName("Kapazität WDM")]
        public string? Kapazitat_WDM { get; set; }
        public string? TOM_PLANNING_PREPARATION { get; set; }
        public string? TOM_EXECUTION { get; set; }
        public string? PLZ { get; set; }
        public string? Ort { get; set; }
        public string? Straße { get; set; }

        [ColumnName("Gebäudeart")]
        public string? Gebaudeart { get; set; }
        public string? Eigentümer { get; set; }
        public string? Projekt_Equipment { get; set; }
        public string? NE_Equipment_Bestand { get; set; }
        public string? NE_Equipment_Ziel { get; set; }
        public string? Equipment_Stern { get; set; }
        public string? Festnetzplaner { get; set; }
        public string? GU_Projekt { get; set; }
        public string? UTS_Ticket_am_Projekt { get; set; }
        public string? Ist_Stx11 { get; set; }
        public string? Stx11_Bemerkung { get; set; }
        public string? Ist_Stx29t { get; set; }
        public string? Stx29t_Bemerkung { get; set; }
        public string? Ist_Stx30 { get; set; }
        public string? Stx30_Bemerkung { get; set; }
        public string? Ist_Stx43a { get; set; }
        public string? Stx43a_Bemerkung { get; set; }
        public string? Ist_Stx43c { get; set; }
        public string? Ist_Stx43 { get; set; }
        public string? Ist_Stx44 { get; set; }
        public string? Stx44_Bemerkung { get; set; }
        public string? Plan_Stx48 { get; set; }
        public string? Ist_Stx48 { get; set; }
        public string? Stx48_Bemerkung { get; set; }
        public string? Plan_Stx50 { get; set; }
        public string? Ist_Stx50 { get; set; }
        public string? Stx50_Bemerkung { get; set; }
        public string? Plan_Stx40 { get; set; }
        public string? Ist_Stx40 { get; set; }
        public string? Stx40_Bemerkung { get; set; }
        public string? Ist_Stx40Stern { get; set; }
        public string? Ist_Stx53 { get; set; }
        public string? Stx53_Bemerkung { get; set; }
        public string? Ist_Stx52r { get; set; }
        public string? Ist_Stx52b { get; set; }
        public string? Stx52b_Bemerkung { get; set; }
        public string? Ist_Stx62g { get; set; }
        public string? Soll_Stx62j { get; set; }
        public string? Plan_Stx62j { get; set; }
        public string? Ist_Stx62j { get; set; }
        public string? Stx62j_Bemerkung { get; set; }
        public string? Ist_Stx62w { get; set; }
        public string? Stx62w_Bemerkung { get; set; }
        public string? Ist_Stx62r { get; set; }
        public string? Plan_Stx59k { get; set; }
        public string? Ist_Stx59k { get; set; }
        public string? Stx59k_Bemerkung { get; set; }
        public string? Plan_Stx60 { get; set; }
        public string? Ist_Stx60 { get; set; }
        public string? Stx60_Bemerkung { get; set; }
        public string? Ist_Stx59 { get; set; }
        public string? Stx59_Bemerkung { get; set; }
        public string? Ist_Stx62a { get; set; }
        public string? Stx62a_Bemerkung { get; set; }
        public string? Ist_Stx51a { get; set; }
        public string? Ist_Stx51b { get; set; }
        public string? Stx51b_Bemerkung { get; set; }
        public string? Ist_Stx51l { get; set; }
        public string? Stx51l_Bemerkung { get; set; }
        public string? Ist_Stx51r { get; set; }
        public string? Plan_Stx71 { get; set; }
        public string? Ist_Stx71 { get; set; }
        public string? Stx71_Bemerkung { get; set; }
        public string? Ist_Stx71a { get; set; }
        public string? Ist_Stx71b { get; set; }
        public string? Ist_Stx71c { get; set; }
        public string? Ist_Stx80 { get; set; }
        public string? Stx80_Bemerkung { get; set; }
        public string? Ist_Stx87r { get; set; }
        public string? Plan_Stx88i { get; set; }
        public string? Ist_Stx88i { get; set; }
        public string? Ist_Stx89 { get; set; }
        public string? Soll_Stx90 { get; set; }
        public string? Plan_Stx90 { get; set; }
        public string? Ist_Stx90 { get; set; }
        public string? Stx90_Bemerkung { get; set; }
        public string? Plan_Stx91 { get; set; }
        public string? Ist_Stx91 { get; set; }
        public string? Stx91_Bemerkung { get; set; }
        public string? Plan_Stx91a { get; set; }
        public string? Ist_Stx91a { get; set; }
        public string? Stx91a_Bemerkung { get; set; }
        public string? Ist_Stx91r { get; set; }
        public string? Ist_Stx30n { get; set; }
        public string? Ist_Stx68n { get; set; }
        public string? Ist_Stx30o { get; set; }
        public string? Ist_Stx68o { get; set; }
        public string? Ist_Stx30p { get; set; }
        public string? Ist_Stx68p { get; set; }
    }
}
