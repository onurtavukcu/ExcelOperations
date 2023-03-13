namespace ExcelOperations.DocEntity.Aktuell
{
    public class RouterAktuellOrderList
    {
        [ColumnName("Zuständige Region")]
        public string? Zustandige_Region { get; set; }
        public string? SO_Nr_TEF { get; set; }
        public string? SO_Nr_EPlus { get; set; }
        [ColumnName("CtK-Status")]
        public string? CtK_Status { get; set; }
        public string? NE_Nr { get; set; }
        public string? Alt { get; set; }
        public string? NE_Name { get; set; }
        public string? NE_Bemerkung { get; set; }
        public string? Projektart { get; set; }
        [ColumnName("Projekt-ID")]
        public string? Projekt_ID { get; set; }
        [ColumnName("SC-Kategorie")]
        public string? SC_Kategorie { get; set; }
        [ColumnName("SC-Nummer")]
        public string? SC_Nummer { get; set; }
        public string? PO_NUMMER { get; set; }
        public string? PO_DATUM { get; set; }
        public string? LIEFERANT { get; set; }
        public string? POSITION { get; set; }
        public string? ARTIKELBEZEICHNUNG { get; set; }
        public string? MENGE { get; set; }
        public string? WARENEINGANGSDATUM { get; set; }
    }
}
