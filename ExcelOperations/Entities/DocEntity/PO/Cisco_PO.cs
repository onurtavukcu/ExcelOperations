using ExcelOperations.Entities.DocEntity;

namespace ExcelOperations.DocEntity.Entity.PO
{
    public class Cisco_PO : EntityBase
    {
        public string? CISCO_ID { get; set; }

        [ColumnName("PO")]
        public string? PO_No { get; set; }

        [ColumnName("PO Date")]
        public string? PO_Date { get; set; }

        [ColumnName("PO Elemnt")]
        public string? PO_Elemnt { get; set; }

        [ColumnName("Mat.Code")]
        public string? Mat_Code { get; set; }
        public string? Artikel { get; set; }
        public string? Para { get; set; }

        [ColumnName("Auftr.best.")]
        public string? Auftr_best { get; set; }
        public string? BZR { get; set; }

        [ColumnName("Rech. NO")]
        public string? Rech_NO { get; set; }
        public string? MP_Bezeichnung { get; set; }
        public string? Sto { get; set; }
        public string? Gebäudeart { get; set; }
        public string? NE_Nr { get; set; }

        [ColumnName("Objekt-ID")]
        public int? Objekt_ID { get; set; }  //project Id
        public string? NE { get; set; }
        public string? Projekt { get; set; }
        public string? Address { get; set; }
        public string? Team { get; set; }
        public string? Action { get; set; }

        [ColumnName("Action Plan")]
        public string? Action_Plan { get; set; }

        [ColumnName("Action Detail")]
        public string? Action_Detail { get; set; }
        public string? Column1 { get; set; }
        public string? Column2 { get; set; }
    }
}
