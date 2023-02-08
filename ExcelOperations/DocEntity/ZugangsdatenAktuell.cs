namespace ExcelOperations.DocEntity
{
    public class ZugangsdatenAktuell
    {
        [ColumnName("Zuständige Region")]
        public string? ZustandigeRegion { get; set; }
        public string? SO_Nr { get; set; }
        public string? SO_Nr_EPlus { get; set; }

        [ColumnName("COOP-Contract")]
        public string? COOPContract { get; set; }

        [ColumnName("COOP-Status")]
        public string? COOPStatus { get; set; }

        [ColumnName("COOP-Tausch")]
        public string? COOPTausch { get; set; }
        public string? Infrastruktur_Soll_Baseframe_Radio_MW { get; set; }
        public string? Netzelement { get; set; }
        public string? Equipment_SO { get; set; }
        public string? Eigentümer { get; set; }
        public string? Gebäudeart { get; set; }
        public string? PLZ { get; set; }
        public string? Ort { get; set; }

        [ColumnName("Straße")]
        public string? Strabe { get; set; }

        [ColumnName("Rechtswert GK3")]
        public string? RechtswertGK3 { get; set; }

        [ColumnName("Hochwert GK3")]
        public string? HochwertGK3 { get; set; }

        [ColumnName("Östl Länge WGS84")]
        public string? OstlLangeWGS84 { get; set; }
        
        [ColumnName("Nördl Breite WGS84")]
        public string? NordlBreiteWGS84 { get; set; }
        public string? Zugangsmöglichkeit { get; set; }
        public string? Zugangsregelung { get; set; }
        public string? Zufahrtsbeschreibung { get; set; }
        public string? Parkplätze { get; set; }
        public string? Besonderheiten { get; set; }
        public string? Umgebungspflege { get; set; }

        [ColumnName("Datum der Schließung")]
        public string? DatumderSchliebung { get; set; }
        public string? Schliebung { get; set; }

        [ColumnName("Standort des Tresors")]
        public string? StandortdesTresors { get; set; }
    }
}
