using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.POCDTO
{
    public class RouterSwapAktuellDTO
    {
        public string? SO_Nr_EPlus { get; set; }
        public string? PLZ { get; set; }
        public string? Ort { get; set; }

        [ColumnName("Straße")]
        public string? Strabe { get; set; }

        [ColumnName("Gebäudeart")]
        public string? Gebaudeart { get; set; }

        [ColumnName("Eigentümer")]
        public string? Eigentumer { get; set; }

        [ColumnName("Standort-Klasse")]
        public string? Standort_Klasse { get; set; }

        [ColumnName("POC B-Ende")]
        public string? POC_B_Ende { get; set; }
        public string? NE_Nr { get; set; }
        public string? Alt { get; set; }

        [ColumnName("Projekt-ID")]
        public string? Projekt_ID { get; set; } // project

        [ColumnName("Router alt")]
        public string? Router_alt { get; set; }

        [ColumnName("Router neu")]
        public string? Router_neu { get; set; }
    }
}
