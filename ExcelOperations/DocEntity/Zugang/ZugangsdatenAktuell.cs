namespace ExcelOperations.DocEntity
{
    public class ZugangsdatenAktuell
    {
        [ColumnName("Zuständige Region")]
        public string? Zustandige_Region { get; set; }
        public string? SO_Nr { get; set; }  //bağlant 700  den gelem tablo birleştirme
        public string? SO_Nr_EPlus { get; set; }

        [ColumnName("COOP-Contract")]
        public string? COOP_Contract { get; set; }

        [ColumnName("COOP-Status")]
        public string? COOP_Status { get; set; }

        [ColumnName("COOP-Tausch")]
        public string? COOP_Tausch { get; set; }
        public string? Infrastruktur_Soll_Baseframe_Radio_MW { get; set; }
        public string? Netzelement { get; set; }
        public string? Equipment_SO { get; set; }
        public string? Eigentümer { get; set; }

        [ColumnName("Gebäudeart")]
        public string? Gebaudeart { get; set; }
        public string? PLZ { get; set; }
        public string? Ort { get; set; }

        [ColumnName("Straße")]
        public string? Strabe { get; set; }

        [ColumnName("Rechtswert GK3")]
        public string? Rechtswert_GK3 { get; set; }

        [ColumnName("Hochwert GK3")]
        public string? Hochwert_GK3 { get; set; }

        [ColumnName("Östl Länge WGS84")]
        public string? Ostl_Lange_WGS84 { get; set; }
        
        [ColumnName("Nördl Breite WGS84")]
        public string? Nordl_Breite_WGS84 { get; set; }
        public string? Zugangsmöglichkeit { get; set; }
        public string? Zugangsregelung { get; set; }
        public string? Zufahrtsbeschreibung { get; set; }
        public string? Parkplätze { get; set; }
        public string? Besonderheiten { get; set; }
        public string? Umgebungspflege { get; set; }

        [ColumnName("Datum der Schließung")]
        public string? Datum_der_Schliebung { get; set; }

        [ColumnName("Schließung")]
        public string? Schliebung { get; set; }

        [ColumnName("Standort des Tresors")]
        public string? Standort_des_Tresors { get; set; }
    }
}
