using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.AktuellDTO
{
    public class RouterAktuellDTO
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
        public string? Projekt_ID { get; set; } // project
        public string? MP_POC { get; set; }
        public string? Bezeichnung { get; set; }

        [ColumnName("Verantw Organisationseinheit")]
        public string? Verantw_Organisationseinheit { get; set; }
        public string? Infrastruktur_Soll_Baseframe_Radio_MW { get; set; }
    }
}
