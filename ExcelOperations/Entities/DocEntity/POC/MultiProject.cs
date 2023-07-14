using ExcelOperations.Entities;
using ExcelOperations.Entities.DocEntity;

namespace ExcelOperations.DocEntity.Entity.POC
{
    public class MultiProject : EntityBase
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
        public string? Objekt_ID { get; set; } //project
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
        public string? HW_WGS84_dez { get; set; }






        [ColumnName("Link APT_15_Ist")]
        public string? Link_APT_15_Ist { get; set; }
        [ColumnName("Link APT_18_Ist")]
        public string? Link_APT_18_Ist { get; set; }
        [ColumnName("Link APT_18_Bem.")]
        public string? Link_APT_18_Bem { get; set; }
        [ColumnName("Link APT_19_Ist")]
        public string? Link_APT_19_Ist { get; set; }
        [ColumnName("Link APT_19_Bem.")]
        public string? Link_APT_19_Bem { get; set; }
        [ColumnName("Link APT_30_Ist")]
        public string? Link_APT_30_Ist { get; set; }
        [ColumnName("Link APT_34_Ist")]
        public string? Link_APT_34_Ist { get; set; }
        [ColumnName("Link APT_35_Ist")]
        public string? Link_APT_35_Ist { get; set; }
        [ColumnName("Link PO Nummer")]
        public string? Link_PO_Nummer { get; set; }
        [ColumnName("Link Bestellitems")]
        public string? Link_Bestellitems { get; set; }
        [ColumnName("Link APT_50_Ist")]
        public string? Link_APT_50_Ist { get; set; }
        [ColumnName("Link APT_51_Plan")]
        public string? Link_APT_51_Plan { get; set; }
        [ColumnName("Link APT_51_Ist")]
        public string? Link_APT_51_Ist { get; set; }
        [ColumnName("Link APT_51_Bem.")]
        public string? Link_APT_51_Bem { get; set; }
        [ColumnName("Link APT_52_Plan")]
        public string? Link_APT_52_Plan { get; set; }
        [ColumnName("Link APT_52_Ist")]
        public string? Link_APT_52_Ist { get; set; }
        [ColumnName("Link APT_52_Bem.")]
        public string? Link_APT_52_Bem { get; set; }
        [ColumnName("Link APT_53_Plan")]
        public string? Link_APT_53_Plan { get; set; }
        [ColumnName("Link APT_53_Ist")]
        public string? Link_APT_53_Ist { get; set; }
        [ColumnName("Link APT_53_Bem.")]
        public string? Link_APT_53_Bem { get; set; }
        [ColumnName("Link APT_54_Plan")]
        public string? Link_APT_54_Plan { get; set; }
        [ColumnName("Link APT_54_Ist")]
        public string? Link_APT_54_Ist { get; set; }
        [ColumnName("Link APT_54_Bem.")]
        public string? Link_APT_54_Bem { get; set; }
        [ColumnName("Link APT_77_Plan")]
        public string? Link_APT_77_Plan { get; set; }
        [ColumnName("Link APT_77_Ist")]
        public string? Link_APT_77_Ist { get; set; }
        [ColumnName("Link APT_77_Bem.")]
        public string? Link_APT_77_Bem { get; set; }
        [ColumnName("Link APT_16_Plan")]
        public string? Link_APT_16_Plan { get; set; }
        [ColumnName("Link APT_16_Ist")]
        public string? Link_APT_16_Ist { get; set; }
        [ColumnName("Link APT_16_Bem.")]
        public string? Link_APT_16_Bem { get; set; }
        [ColumnName("Link APT_60a_Ist")]
        public string? Link_APT_60a_Ist { get; set; }
        [ColumnName("Link APT_60a_Bem.")]
        public string? Link_APT_60a_Bem { get; set; }
        [ColumnName("Link APT_61a_Ist")]
        public string? Link_APT_61a_Ist { get; set; }
        [ColumnName("Link APT_61a_Bem.")]
        public string? Link_APT_61a_Bem { get; set; }
        [ColumnName("Link APT_82_Soll")]
        public string? Link_APT_82_Soll { get; set; }
        [ColumnName("Link APT_82_Plan")]
        public string? Link_APT_82_Plan { get; set; }
        [ColumnName("Link APT_82_Ist")]
        public string? Link_APT_82_Ist { get; set; }
        [ColumnName("Link APT_82_Bem.")]
        public string? Link_APT_82_Bem { get; set; }
        [ColumnName("Link APT_85_Plan")]
        public string? Link_APT_85_Plan { get; set; }
        [ColumnName("Link APT_85_Ist")]
        public string? Link_APT_85_Ist { get; set; }
        [ColumnName("Link APT_85_Bem.")]
        public string? Link_APT_85_Bem { get; set; }
        [ColumnName("Link APT_86_Plan")]
        public string? Link_APT_86_Plan { get; set; }
        [ColumnName("Link APT_86_Ist")]
        public string? Link_APT_86_Ist { get; set; }
        [ColumnName("Link APT_86_Bem.")]
        public string? Link_APT_86_Bem { get; set; }
        [ColumnName("Link APT_87_Plan")]
        public string? Link_APT_87_Plan { get; set; }
        [ColumnName("Link APT_87_Ist")]
        public string? Link_APT_87_Ist { get; set; }
        [ColumnName("Link APT_87_Bem.")]
        public string? Link_APT_87_Bem { get; set; }
        [ColumnName("Link APT_88_Plan")]
        public string? Link_APT_88_Plan { get; set; }
        [ColumnName("Link APT_88_Ist")]
        public string? Link_APT_88_Ist { get; set; }
        [ColumnName("Link APT_88_Bem.")]
        public string? Link_APT_88_Bem { get; set; }
        [ColumnName("Link APT_90_Plan")]
        public string? Link_APT_90_Plan { get; set; }
        [ColumnName("Link APT_90_Ist")]
        public string? Link_APT_90_Ist { get; set; }
        [ColumnName("Link APT_90_Bem.")]
        public string? Link_APT_90_Bem { get; set; }
        [ColumnName("Link APT_790_Ist")]
        public string? Link_APT_790_Ist { get; set; }
        [ColumnName("Link APT_790_Bem.")]
        public string? Link_APT_790_Bem { get; set; }
        [ColumnName("Stx11_Bem.")]
        public string? Stx11_Bem_ { get; set; }
        public string? Ist_Stx30 { get; set; }
        [ColumnName("Stx30_Bem.")]
        public string? Stx30_Bem_ { get; set; }
        public string? Ist_Stx43a { get; set; }
        [ColumnName("Stx43a_Bem.")]
        public string? Stx43a_Bem_ { get; set; }
        public string? Ist_Stx44 { get; set; }
        [ColumnName("Stx44_Bem.")]
        public string? Stx44_Bem_ { get; set; }
        public string? Ist_Stx45 { get; set; }
        [ColumnName("Stx45_Bem.")]
        public string? Stx45_Bem_ { get; set; }
        public string? Plan_Stx48 { get; set; }
        public string? Ist_Stx48 { get; set; }
        [ColumnName("Stx48_Bem.")]
        public string? Stx48_Bem_ { get; set; }
        public string? Plan_Stx50 { get; set; }
        public string? Ist_Stx50 { get; set; }
        [ColumnName("Stx50_Bem.")]
        public string? Stx50_Bem_ { get; set; }
        public string? Plan_Stx40 { get; set; }
        public string? Ist_Stx40 { get; set; }
        [ColumnName("Stx40_Bem.")]
        public string? Stx40_Bem_ { get; set; }
        public string? Ist_Stx40Stern { get; set; }
        public string? Ist_Stx52 { get; set; }
        [ColumnName("Stx52_Bem.")]
        public string? Stx52_Bem_ { get; set; }
        public string? Ist_Stx52r { get; set; }
        [ColumnName("Stx52r_Bem.")]
        public string? Stx52r_Bem_ { get; set; }
        public string? Plan_Stx52b { get; set; }
        public string? Ist_Stx52b { get; set; }
        [ColumnName("Stx52b_Bem.")]
        public string? Stx52b_Bem_ { get; set; }
        public string? Ist_Stx53 { get; set; }
        [ColumnName("Stx53_Bem.")]
        public string? Stx53_Bem_ { get; set; }
        public string? Plan_Stx56 { get; set; }
        public string? Ist_Stx56 { get; set; }
        public string? Plan_Stx56a { get; set; }
        public string? Ist_Stx56a { get; set; }
        [ColumnName("Stx56a_Bem.")]
        public string? Stx56a_Bem_ { get; set; }
        public string? Soll_Stx62j { get; set; }
        public string? Plan_Stx62j { get; set; }
        public string? Ist_Stx62j { get; set; }
        [ColumnName("Stx62j_Bem.")]
        public string? Stx62j_Bem_ { get; set; }
        public string? Ist_Stx62w { get; set; }
        [ColumnName("Stx62w_Bem.")]
        public string? Stx62w_Bem_ { get; set; }
        public string? Ist_Stx62r { get; set; }
        [ColumnName("Stx62r_Bem.")]
        public string? Stx62r_Bem_ { get; set; }
        public string? Plan_Stx59k { get; set; }
        public string? Ist_Stx59k { get; set; }
        [ColumnName("Stx59k_Bem.")]
        public string? Stx59k_Bem_ { get; set; }
        public string? Ist_Stx60 { get; set; }
        [ColumnName("Stx60_Bem.")]
        public string? Stx60_Bem_ { get; set; }
        public string? Plan_Stx59 { get; set; }
        public string? Ist_Stx59 { get; set; }
        [ColumnName("Stx59_Bem.")]
        public string? Stx59_Bem_ { get; set; }
        public string? Ist_Stx62a { get; set; }
        [ColumnName("Stx62a_Bem.")]
        public string? Stx62a_Bem_ { get; set; }
        public string? Plan_Stx62g { get; set; }
        public string? Ist_Stx62g { get; set; }
        public string? Plan_Stx51a { get; set; }
        public string? Ist_Stx51a { get; set; }
        public string? Ist_Stx51b { get; set; }
        [ColumnName("Stx51b_Bem.")]
        public string? Stx51b_Bem_ { get; set; }
        public string? Ist_Stx51l { get; set; }
        public string? Stx51l_Bem { get; set; }
        public string? Ist_Stx51r { get; set; }
        [ColumnName("Stx51r_Bem.")]
        public string? Stx51r_Bem_ { get; set; }
        public string? Plan_Stx63 { get; set; }
        public string? Ist_Stx63 { get; set; }
        [ColumnName("Stx63_Bem.")]
        public string? Stx63_Bem_ { get; set; }
        public string? Plan_Stx66 { get; set; }
        public string? Ist_Stx66 { get; set; }
        [ColumnName("Stx66_Bem.")]
        public string? Stx66_Bem_ { get; set; }
        public string? Plan_Stx67 { get; set; }
        public string? Ist_Stx67 { get; set; }
        [ColumnName("Stx67_Bem.")]
        public string? Stx67_Bem_ { get; set; }
        public string? Soll_Stx71 { get; set; }
        public string? Plan_Stx71 { get; set; }
        public string? Ist_Stx71 { get; set; }
        [ColumnName("Stx71_Bem.")]
        public string? Stx71_Bem_ { get; set; }
        public string? Ist_Stx71a { get; set; }
        public string? Ist_Stx71b { get; set; }
        [ColumnName("Stx71b_Bem.")]
        public string? Stx71b_Bem_ { get; set; }
        public string? Ist_Stx71c { get; set; }
        public string? Stx71c_Bem { get; set; }
        public string? Plan_Stx73a { get; set; }
        public string? Ist_Stx73a { get; set; }
        public string? Stx73a_Bemerkung { get; set; }
        public string? Soll_Stx80 { get; set; }
        public string? Ist_Stx80 { get; set; }
        [ColumnName("Stx80_Bem.")]
        public string? Stx80_Bem_ { get; set; }
        public string? Soll_Stx88i { get; set; }
        public string? Plan_Stx88i { get; set; }
        public string? Ist_Stx88i { get; set; }
        [ColumnName("Stx88i_Bem.")]
        public string? Stx88i_Bem_ { get; set; }
        public string? Soll_Stx90 { get; set; }
        public string? Plan_Stx90 { get; set; }
        public string? Ist_Stx90 { get; set; }
        [ColumnName("Stx90_Bem.")]
        public string? Stx90_Bem_ { get; set; }
        public string? Plan_Stx91 { get; set; }
        public string? Ist_Stx91 { get; set; }
        [ColumnName("Stx91_Bem.")]
        public string? Stx91_Bem_ { get; set; }
        public string? Plan_Stx91a { get; set; }
        public string? Ist_Stx91a { get; set; }
        [ColumnName("Stx91a_Bem.")]
        public string? Stx91a_Bem_ { get; set; }
        public string? Ist_Stx91c { get; set; }
        [ColumnName("Stx91c_Bem.")]
        public string? Stx91c_Bem_ { get; set; }
        public string? Ist_Stx91r { get; set; }
        [ColumnName("Stx91r_Bem.")]
        public string? Stx91r_Bem_ { get; set; }
        public string? Ist_Stx30n { get; set; }
        public string? Plan_Stx68n { get; set; }
        public string? Ist_Stx68n { get; set; }
        public string? Ist_Stx30o { get; set; }
        public string? Plan_Stx68o { get; set; }
        public string? Ist_Stx68o { get; set; }
        public string? Ist_Stx30p { get; set; }
        public string? Plan_Stx68p { get; set; }
        public string? Ist_Stx68p { get; set; }
        public string? Equipment { get; set; }
        public string? UTS_Ticket_am_Projekt { get; set; }
    }
}
