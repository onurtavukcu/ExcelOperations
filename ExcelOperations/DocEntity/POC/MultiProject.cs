using ExcelOperations.DocEntity;

namespace ExcelOperations.Doc.Entity.POC
{
    public class MultiProject
    {
        public string? Order { get; set; }
        [ColumnName("Zuständige Region")]
        public string? Zuständige_Region { get; set; }
        public string? MP_Bezeichnung { get; set; }
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
        public string? Objekt_ID { get; set; }
        public string? Alt { get; set; }
        [ColumnName("NE-Typ")]
        public string? NE_Typ { get; set; }
        public string? POC_Projekt { get; set; }
        public string? MP_ID { get; set; }
        [ColumnName("MP-Typ(kurz)")]
        public string? MP_Typ_kurz { get; set; }
        public string? MP_Bemerkung { get; set; }
        public string? MP_Stand { get; set; }
        [ColumnName("MP_Geplanter Start")]
        public string? MP_Geplanter_Start { get; set; }
        public string? MP_Rev_Bemerkung { get; set; }
        [ColumnName("MP_Angelegt am")]
        public string? MP_Angelegt_am { get; set; }
        [ColumnName("MP_Angelegt von")]
        public string? MP_Angelegt_von { get; set; }
        [ColumnName("MP_Geplantes Ende")]
        public string? MP_Geplantes_Ende { get; set; }
        public string? MP_Ist_St19 { get; set; }
        public string? MP_Ist_St30 { get; set; }
        public string? MP_Ist_St40 { get; set; }
        public string? MP_Ist_St50 { get; set; }
        public string? MP_Ist_St56 { get; set; }
        public string? MP_Ist_St62w { get; set; }
        public string? MP_Ist_St60a { get; set; }
        public string? MP_Ist_St62a { get; set; }
        public string? MP_Plan_St71 { get; set; }
        public string? MP_Ist_St71 { get; set; }
        public string? MP_Ist_St73a { get; set; }
        public string? MP_Plan_St90 { get; set; }
        public string? MP_Ist_St90 { get; set; }
        public string? MP_Ist_St91 { get; set; }
        [ColumnName("Objekt-Art")]
        public string? Objekt_Art { get; set; }
        [ColumnName("Objekt-Stand")]
        public string? Objekt_Stand { get; set; }
        [ColumnName("Objekt-Template")]
        public string? Objekt_Template { get; set; }
        [ColumnName("Objekt-Bezeichnung")]
        public string? Objekt_Bezeichnung { get; set; }
        [ColumnName("Objekt-Typ")]
        public string? Objekt_Typ { get; set; }
        [ColumnName("Objekt-Sub-ID")]
        public string? Objekt_Sub_ID { get; set; }
        [ColumnName("Objekt-Bemerkung")]
        public string? Objekt_Bemerkung { get; set; }
        public string? Demand { get; set; }
        [ColumnName("NRG-Transition")]
        public string? NRG_Transition { get; set; }
        [ColumnName("Dim_Squads MAC")]
        public string? Dim_Squads_MAC { get; set; }
        [ColumnName("Objekt-Herkunft")]
        public string? Objekt_Herkunft { get; set; }
        public string? Dim_Beauftragungsform { get; set; }
        public string? NE_Name { get; set; }
        [ColumnName("CtK-Status")]
        public string? CtK_Status { get; set; }
        [ColumnName("Site Typ")]
        public string? Site_Typ { get; set; }
        public string? Festnetzplaner { get; set; }
        [ColumnName("MP-Festnetzplaner")]
        public string? MP_Festnetzplaner { get; set; }
        [ColumnName("MP-HLD-Planer")]
        public string? MP_HLD_Planer { get; set; }
        [ColumnName("MP-LLD-Planer")]
        public string? MP_LLD_Planer { get; set; }
        [ColumnName("MP-Projektleiter")]
        public string? MP_Projektleiter { get; set; }
        [ColumnName("MP-Projektleiter-Bemerkung")]
        public string? MP_Projektleiter_Bemerkung { get; set; }
        [ColumnName("MP-Generalunternehmer")]
        public string? MP_Generalunternehmer { get; set; }
        [ColumnName("MP-Generalunternehmer-Bemerkung")]
        public string? MP_Generalunternehmer_Bemerkung { get; set; }
        public string? Bauleiter { get; set; }
        [ColumnName("Auftragnehmer Systemtechnik")]
        public string? Auftragnehmer_Systemtechnik { get; set; }
        [ColumnName("Auftragnehmer Integration on-site")]
        public string? Auftragnehmer_Integration_on_site { get; set; }
        public string? Generalunternehmer { get; set; }
        public string? Subunternehmer { get; set; }
        public string? Carrier { get; set; }
        public string? TOM_PLANNING_PREPARATION { get; set; }
        public string? TOM_EXECUTION { get; set; }
        [ColumnName("SO-ID A-Ende")]
        public string? SO_ID_A_Ende { get; set; }
        [ColumnName("SO-A Standortnummer")]
        public string? SO_A_Standortnummer { get; set; }
        [ColumnName("SO-A Auftragstyp")]
        public string? SO_A_Auftragstyp { get; set; }
        [ColumnName("SO-A Projektstand")]
        public string? SO_A_Projektstand { get; set; }
        [ColumnName("SO-A Service_GU")]
        public string? SO_A_Service_GU { get; set; }
        [ColumnName("SO-A Planer")]
        public string? SO_A_Planer { get; set; }
        [ColumnName("SO-A Bemerkung_Auftrag")]
        public string? SO_A_Bemerkung_Auftrag { get; set; }
        [ColumnName("SO-A Bemerkung_Auftragnehmer")]
        public string? SO_A_Bemerkung_Auftragnehmer { get; set; }
        [ColumnName("SO-A APT_10_Ist")]
        public string? SO_A_APT_10_Ist { get; set; }
        [ColumnName("SO-A APT_10_Bem.")]
        public string? SO_A_APT_10_Bem { get; set; }
        [ColumnName("SO-A APT_16_Plan")]
        public string? SO_A_APT_16_Plan { get; set; }
        [ColumnName("SO-A APT_16_Ist")]
        public string? SO_A_APT_16_Ist { get; set; }
        [ColumnName("SO-A APT_16_Bem.")]
        public string? SO_A_APT_16_Bem { get; set; }
        [ColumnName("SO-A APT_30_Ist")]
        public string? SO_A_APT_30_Ist { get; set; }
        [ColumnName("SO-A APT_34_Ist")]
        public string? SO_A_APT_34_Ist { get; set; }
        [ColumnName("SO-A APT_35_Ist")]
        public string? SO_A_APT_35_Ist { get; set; }
        [ColumnName("SO-A PO Nummer")]
        public string? SO_A_PO_Nummer { get; set; }
        [ColumnName("SO-A Bestellitems")]
        public string? SO_A_Bestellitems { get; set; }
        [ColumnName("SO-A APT_45_Plan")]
        public string? SO_A_APT_45_Plan { get; set; }
        [ColumnName("SO-A APT_45_Ist")]
        public string? SO_A_APT_45_Ist { get; set; }
        [ColumnName("SO-A APT_45_Bem.")]
        public string? SO_A_APT_45_Bem { get; set; }
        [ColumnName("SO-A APT_48_Plan")]
        public string? SO_A_APT_48_Plan { get; set; }
        [ColumnName("SO-A APT_48_Ist")]
        public string? SO_A_APT_48_Ist { get; set; }
        [ColumnName("SO-A APT_48_Bem.")]
        public string? SO_A_APT_48_Bem { get; set; }
        [ColumnName("SO-A APT_49_Ist")]
        public string? SO_A_APT_49_Ist { get; set; }
        [ColumnName("SO-A APT_50_Plan")]
        public string? SO_A_APT_50_Plan { get; set; }
        [ColumnName("SO-A APT_50_Ist")]
        public string? SO_A_APT_50_Ist { get; set; }
        [ColumnName("SO-A APT_50_Bem.")]
        public string? SO_A_APT_50_Bem { get; set; }
        [ColumnName("SO-A APT_59_Plan")]
        public string? SO_A_APT_59_Plan { get; set; }
        [ColumnName("SO-A APT_59_Ist")]
        public string? SO_A_APT_59_Ist { get; set; }
        [ColumnName("SO-A APT_59_Bem.")]
        public string? SO_A_APT_59_Bem { get; set; }
        [ColumnName("SO-A APT_66_Ist")]
        public string? SO_A_APT_66_Ist { get; set; }
        [ColumnName("SO-A APT_66_Bem.")]
        public string? SO_A_APT_66_Bem { get; set; }
        [ColumnName("SO-A APT_82_Plan")]
        public string? SO_A_APT_82_Plan { get; set; }
        [ColumnName("SO-A APT_82_Soll")]
        public string? SO_A_APT_82_Soll { get; set; }
        [ColumnName("SO-A APT_82_Ist")]
        public string? SO_A_APT_82_Ist { get; set; }
        [ColumnName("SO-A APT_82_Bem.")]
        public string? SO_A_APT_82_Bem { get; set; }
        [ColumnName("SO-A APT_85_Ist")]
        public string? SO_A_APT_85_Ist { get; set; }
        [ColumnName("SO-A APT_85_Bem.")]
        public string? SO_A_APT_85_Bem { get; set; }
        [ColumnName("SO-A APT_86_Ist")]
        public string? SO_A_APT_86_Ist { get; set; }
        [ColumnName("SO-A APT_86_Bem.")]
        public string? SO_A_APT_86_Bem { get; set; }
        [ColumnName("SO-A APT_87_Ist")]
        public string? SO_A_APT_87_Ist { get; set; }
        [ColumnName("SO-A APT_87_Bem.")]
        public string? SO_A_APT_87_Bem { get; set; }
        [ColumnName("SO-A APT_88_Plan")]
        public string? SO_A_APT_88_Plan { get; set; }
        [ColumnName("SO-A APT_88_Ist")]
        public string? SO_A_APT_88_Ist { get; set; }
        [ColumnName("SO-A APT_88_Bem.")]
        public string? SO_A_APT_88_Bem { get; set; }
        [ColumnName("SO-A APT_90_Ist")]
        public string? SO_A_APT_90_Ist { get; set; }
        [ColumnName("SO-A APT_90_Bem.")]
        public string? SO_A_APT_90_Bem { get; set; }
        [ColumnName("SO-A APT_790_Ist")]
        public string? SO_A_APT_790_Ist { get; set; }
        [ColumnName("SO-ID B-Ende")]
        public string? SO_ID_B_Ende { get; set; }
        [ColumnName("SO-B Standortnummer")]
        public string? SO_B_Standortnummer { get; set; }
        [ColumnName("SO-B Auftragstyp")]
        public string? SO_B_Auftragstyp { get; set; }
        [ColumnName("SO-B Projektstand")]
        public string? SO_B_Projektstand { get; set; }
        [ColumnName("SO-B Service_GU")]
        public string? SO_B_Service_GU { get; set; }
        [ColumnName("SO-B Planer")]
        public string? SO_B_Planer { get; set; }
        [ColumnName("SO-B Bemerkung_Auftrag")]
        public string? SO_B_Bemerkung_Auftrag { get; set; }
        [ColumnName("SO-B Bemerkung_Auftragnehmer")]
        public string? SO_B_Bemerkung_Auftragnehmer { get; set; }
        [ColumnName("SO-B APT_10_Ist")]
        public string? SO_B_APT_10_Ist { get; set; }
        [ColumnName("SO-B APT_10_Bem.")]
        public string? SO_B_APT_10_Bem { get; set; }
        [ColumnName("SO-B APT_16_Plan")]
        public string? SO_B_APT_16_Plan { get; set; }
        [ColumnName("SO-B APT_16_Ist")]
        public string? SO_B_APT_16_Ist { get; set; }
        [ColumnName("SO-B APT_16_Bem.")]
        public string? SO_B_APT_16_Bem { get; set; }
        [ColumnName("SO-B APT_30_Ist")]
        public string? SO_B_APT_30_Ist { get; set; }
        [ColumnName("SO-B APT_34_Ist")]
        public string? SO_B_APT_34_Ist { get; set; }
        [ColumnName("SO-B APT_35_Ist")]
        public string? SO_B_APT_35_Ist { get; set; }
        [ColumnName("SO-B PO Nummer")]
        public string? SO_B_PO_Nummer { get; set; }
        [ColumnName("SO-B Bestellitems")]
        public string? SO_B_Bestellitems { get; set; }
        [ColumnName("SO-B APT_45_Plan")]
        public string? SO_B_APT_45_Plan { get; set; }
        [ColumnName("SO-B APT_45_Ist")]
        public string? SO_B_APT_45_Ist { get; set; }
        [ColumnName("SO-B APT_45_Bem.")]
        public string? SO_B_APT_45_Bem { get; set; }
        [ColumnName("SO-B APT_48_Plan")]
        public string? SO_B_APT_48_Plan { get; set; }
        [ColumnName("SO-B APT_48_Ist")]
        public string? SO_B_APT_48_Ist { get; set; }
        [ColumnName("SO-B APT_48_Bem.")]
        public string? SO_B_APT_48_Bem { get; set; }
        [ColumnName("SO-B APT_49_Ist")]
        public string? SO_B_APT_49_Ist { get; set; }
        [ColumnName("SO-B APT_50_Plan")]
        public string? SO_B_APT_50_Plan { get; set; }
        [ColumnName("SO-B APT_50_Ist")]
        public string? SO_B_APT_50_Ist { get; set; }
        [ColumnName("SO-B APT_50_Bem.")]
        public string? SO_B_APT_50_Bem { get; set; }
        [ColumnName("SO-B APT_59_Plan")]
        public string? SO_B_APT_59_Plan { get; set; }
        [ColumnName("SO-B APT_59_Ist")]
        public string? SO_B_APT_59_Ist { get; set; }
        [ColumnName("SO-B APT_59_Bem.")]
        public string? SO_B_APT_59_Bem { get; set; }
        [ColumnName("SO-B APT_66_Ist")]
        public string? SO_B_APT_66_Ist { get; set; }
        [ColumnName("SO-B APT_66_Bem.")]
        public string? SO_B_APT_66_Bem { get; set; }
        [ColumnName("SO-B APT_82_Plan")]
        public string? SO_B_APT_82_Plan { get; set; }
        [ColumnName("SO-B APT_82_Soll")]
        public string? SO_B_APT_82_Soll { get; set; }
        [ColumnName("SO-B APT_82_Ist")]
        public string? SO_B_APT_82_Ist { get; set; }
        [ColumnName("SO-B APT_82_Bem.")]
        public string? SO_B_APT_82_Bem { get; set; }
        [ColumnName("SO-B APT_85_Ist")]
        public string? SO_B_APT_85_Ist { get; set; }
        [ColumnName("SO-B APT_85_Bem.")]
        public string? SO_B_APT_85_Bem { get; set; }
        [ColumnName("SO-B APT_86_Ist")]
        public string? SO_B_APT_86_Ist { get; set; }
        [ColumnName("SO-B APT_86_Bem.")]
        public string? SO_B_APT_86_Bem { get; set; }
        [ColumnName("SO-B APT_87_Ist")]
        public string? SO_B_APT_87_Ist { get; set; }
        [ColumnName("SO-B APT_87_Bem.")]
        public string? SO_B_APT_87_Bem { get; set; }
        [ColumnName("SO-B APT_88_Plan")]
        public string? SO_B_APT_88_Plan { get; set; }
        [ColumnName("SO-B APT_88_Ist")]
        public string? SO_B_APT_88_Ist { get; set; }
        [ColumnName("SO-B APT_88_Bem.")]
        public string? SO_B_APT_88_Bem { get; set; }
        [ColumnName("SO-B APT_90_Ist")]
        public string? SO_B_APT_90_Ist { get; set; }
        [ColumnName("SO-B APT_90_Bem.")]
        public string? SO_B_APT_90_Bem { get; set; }
        [ColumnName("SO-B APT_790_Ist")]
        public string? SO_B_APT_790_Ist { get; set; }
        [ColumnName("Link APT_10_Ist")]
        public string? Link_APT_10_Ist { get; set; }
        [ColumnName("Linda Status")]
        public string? Linda_Status { get; set; }
        public string? Ist_Stx11 { get; set; }
        public string? Soll_LL { get; set; }
        public string? Soll_DF { get; set; }
        public string? Soll_MW { get; set; }
        public string? Soll_WL { get; set; }
        public string? Ist_LL { get; set; }
        public string? Ist_DF { get; set; }
        public string? Ist_MW { get; set; }
        public string? Ist_WL { get; set; }
        public string? LL_1st_Stx90 { get; set; }
        public string? DF_1st_Stx90 { get; set; }
        public string? MW_1st_Stx90 { get; set; }
        public string? WL_1st_Stx90 { get; set; }
        [ColumnName("Östl Länge WGS84")]
        public string? Östl_Länge_WGS84 { get; set; }
        [ColumnName("Nördl Breite WGS84")]
        public string? Nördl_Breite_WGS84 { get; set; }
        [ColumnName("Rechtswert GK3")]
        public string? Rechtswert_GK3 { get; set; }
        [ColumnName("Hochwert GK3")]
        public string? Hochwert_GK3 { get; set; }
        public string? RW_WGS84_dez { get; set; }
        public string? HW_WGS84_dez{ get; set; }
    }
}
