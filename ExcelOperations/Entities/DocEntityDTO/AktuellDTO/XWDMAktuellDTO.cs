using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.AktuellDTO
{
    public class XWDMAktuellDTO
    {
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

    }
}
