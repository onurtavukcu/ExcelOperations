using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.POCDTO
{
    public class JSLMultiProjectDTO
    {
        public string? Order { get; set; }
        [ColumnName("Zuständige Region")]
        public string? Zuständige_Region { get; set; }
        public string? MP_Bezeichnung { get; set; }
        public string? MIG_NEU { get; set; }
        [ColumnName("JSL-SiteTyp")]
        public string? JSL_SiteTyp { get; set; }
        public string? Zähler_Projekt { get; set; }
        public string? SO_Nr_Strecke { get; set; }
        [ColumnName("Standort-Klasse")]
        public string? Standort_Klasse { get; set; }
        [ColumnName("POC B-Ende")]
        public string? POC_B_Ende { get; set; }
        [ColumnName("Bewertung Standort Anbindung")]
        public string? Bewertung_Standort_Anbindung { get; set; }
        public string? Sto_Fibre_Kategorie_IST { get; set; }
        public string? Infrastruktur_Soll_Baseframe_Radio_MW { get; set; }
        public string? PLZ { get; set; }
        public string? Ort { get; set; }
        public string? Straße { get; set; }
        public string? Gebäudeart { get; set; }
        public string? Eigentümer { get; set; }
        public string? NE_Nr { get; set; }
        [ColumnName("Objekt-ID")]
        public string? Objekt_ID { get; set; } //object
        public string? Alt { get; set; }
        [ColumnName("NE-Typ")]
    }
}
