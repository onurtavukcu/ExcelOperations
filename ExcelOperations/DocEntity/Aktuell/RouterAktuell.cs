namespace ExcelOperations.DocEntity
{
    public class RouterAktuell
    {   
        [ColumnName("Zuständige Region")]
        public string? Zustandige_Region { get; set; }
        public string? SO_Nr { get; set; }
        public string? SO_Nr_EPlus { get; set; }
        public string? PLZ { get; set; }
        public string? Ort { get; set; }
        public string? Strasse { get; set; }

        [ColumnName("Gebäudeart")]
        public string? Gebaudeart { get; set; }

        [ColumnName("Eigentümer")]
        public string? Eigentumer { get; set; }

        [ColumnName("CtK-Status")]
        public string? CtK_Status { get; set; }
        public string? NE_Nr { get; set; }
        public string? Alt { get; set; }

        [ColumnName("Dim_OSPF Rule")]
        public string? Dim_OSPF_Rule { get; set; }
        public string? NE_Name { get; set; }
        public string? NE_Bemerkung { get; set; }
        public string? NE_Nr_EPlus { get; set; }
        public string? Projektstand { get; set; }
        public string? Projektart { get; set; }

        [ColumnName("Dim_Squads MAC")]
        public string? Dim_Squads_MAC { get; set; }
        public string? SWD_POC_Sourcing { get; set; }

        [ColumnName("NRG-Transition")]
        public string? NRG_Transition { get; set; }

        [ColumnName("Template-Bezeichnung")]
        public string? Template_Bezeichnung { get; set; }
        public string? Projektbemerkung { get; set; }

        [ColumnName("Projekt-ID")]
        public string? Projekt_ID { get; set; }
        public string? MP_POC { get; set; }
        public string? Bezeichnung { get; set; }

        [ColumnName("Verantw Organisationseinheit")]
        public string? Verantw_Organisationseinheit { get; set; }
        public string? Infrastruktur_Soll_Baseframe_Radio_MW { get; set; }

        [ColumnName("Ziel des Projekts")]
        public string? Ziel_des_Projekts { get; set; }
        public string? POC_Projekt { get; set; }

        [ColumnName("Dim_POC-Projekt")]
        public string? Dim_POC_Projekt { get; set; }
        public string? Demand { get; set; }
        public string? Dim_Beauftragungsform { get; set; }
        public string? Projekt_Equipment { get; set; }
        public string? Kol_NE78_MxMS { get; set; }
        public string? Festnetzplaner { get; set; }
        public string? GU_Transport { get; set; }
        public string? GU_Projekt { get; set; }
        public string? Anz_NE30 { get; set; }
        public string? Anz_NE31 { get; set; }
        public string? Anz_NE32 { get; set; }
        public string? Anz_NE33 { get; set; }
        public string? Ist_Stx11 { get; set; }
        public string? Stx11_Bemerkung { get; set; }
        public string? Ist_Stx18b { get; set; }
        public string? Ist_Stx29b { get; set; }
        public string? Ist_Stx29t { get; set; }
        public string? Stx29t_Bemerkung { get; set; }
        public string? Ist_Stx29y { get; set; }
        public string? Ist_Stx29z { get; set; }
        public string? Stx29z_Bemerkung { get; set; }
        public string? Ist_Stx30 { get; set; }
        public string? Stx30_Bemerkung { get; set; }
        public string? Ist_Stx43a { get; set; }
        public string? Stx43a_Bemerkung { get; set; }
        public string? TOM_PLANNING_PREPARATION { get; set; }
        public string? Ist_Stx43c { get; set; }
        public string? Ist_Stx43 { get; set; }
        public string? Ist_Stx44 { get; set; }
        public string? Stx44_Bemerkung { get; set; }
        public string? Plan_Stx40 { get; set; }
        public string? Ist_Stx40 { get; set; }
        public string? Stx40_Bemerkung { get; set; }
        public string? Ist_Stx40Stern { get; set; }
        public string? Ist_Stx53 { get; set; }
        public string? Stx53_Bemerkung { get; set; }
        public string? Soll_Stx62j { get; set; }
        public string? Plan_Stx62j { get; set; }
        public string? Ist_Stx62j { get; set; }
        public string? Stx62j_Bemerkung { get; set; }
        public string? Ist_Stx62w { get; set; }
        public string? Stx62w_Bemerkung { get; set; }
        public string? Ist_Stx62r { get; set; }
        public string? Ist_Stx52b { get; set; }
        public string? Stx52b_Bemerkung { get; set; }
        public string? Plan_Stx59 { get; set; }
        public string? Ist_Stx59 { get; set; }
        public string? Stx59_Bemerkung { get; set; }
        public string? Plan_Stx59k { get; set; }
        public string? Ist_Stx59k { get; set; }
        public string? Stx59k_Bemerkung { get; set; }
        public string? TOM_EXECUTION { get; set; }
        public string? Ist_Stx60 { get; set; }
        public string? Stx60_Bemerkung { get; set; }
        public string? Ist_Stx62a { get; set; }
        public string? Stx62a_Bemerkung { get; set; }
        public string? Plan_Stx62g { get; set; }
        public string? Ist_Stx62g { get; set; }
        public string? Stx62g_Bemerkung { get; set; }
        public string? Ist_Stx51a { get; set; }
        public string? Ist_Stx51b { get; set; }
        public string? Stx51b_Bemerkung { get; set; }
        public string? Ist_Stx51r { get; set; }
        public string? Stx51r_Bemerkung { get; set; }
        public string? Soll_Stx71 { get; set; }
        public string? Plan_Stx71 { get; set; }
        public string? Ist_Stx71 { get; set; }
        public string? Stx71_Bemerkung { get; set; }
        public string? Ist_Stx71a { get; set; }
        public string? Ist_Stx71b { get; set; }
        public string? Stx71b_Bemerkung { get; set; }
        public string? Ist_Stx71c { get; set; }
        public string? Stx71c_Bemerkung { get; set; }
        public string? Ist_Stx80 { get; set; }
        public string? Stx80_Bemerkung { get; set; }
        public string? Plan_Stx88i { get; set; }
        public string? Ist_Stx88i { get; set; }
        public string? Stx88i_Bemerkung { get; set; }
        public string? Ist_Stx87r { get; set; }
        public string? Ist_Stx89 { get; set; }
        public string? Soll_Stx90 { get; set; }
        public string? Plan_Stx90 { get; set; }
        public string? Ist_Stx90 { get; set; }
        public string? Stx90_Bemerkung { get; set; }
        public string? Plan_Stx91 { get; set; }
        public string? Ist_Stx91 { get; set; }
        public string? Stx91_Bemerkung { get; set; }
        public string? Ist_Stx91c { get; set; }
        public string? Ist_Stx91r { get; set; }
        public string? UTS_Ticket_am_Projekt { get; set; }
        public string? Ist_Stx30n { get; set; }
        public string? Stx30n_Bemerkung { get; set; }
        public string? Ist_Stx52n { get; set; }
        public string? Stx52n_Bemerkung { get; set; }
        public string? Plan_Stx68n { get; set; }
        public string? Ist_Stx68n { get; set; }
        public string? Stx68n_Bemerkung { get; set; }
        public string? Ist_Stx30o { get; set; }
        public string? Ist_Stx68o { get; set; }
        public string? Ist_Stx30p { get; set; }
        public string? Stx30p_Bemerkung { get; set; }
        public string? Ist_Stx52p { get; set; }
        public string? Stx52p_Bemerkung { get; set; }
        public string? Plan_Stx68p { get; set; }
        public string? Ist_Stx68p { get; set; }
        public string? Stx68p_Bemerkung { get; set; }
        public string? LL_Ist { get; set; }
        public string? DF_Ist { get; set; }
        public string? MW_Ist { get; set; }
        public string? WL_Ist { get; set; }
        public string? SAT_Ist { get; set; }
        public string? LL { get; set; }
        public string? DF { get; set; }
        public string? MW { get; set; }
        public string? WL { get; set; }
        public string? SAT { get; set; }
        public string? LL_1st_Stx90 { get; set; }
        public string? DF_1st_Stx90 { get; set; }
        public string? MW_1st_Stx90 { get; set; }
        public string? WL_1st_Stx90 { get; set; }
        public string? SAT_1st_Stx90 { get; set; }
    }
}

