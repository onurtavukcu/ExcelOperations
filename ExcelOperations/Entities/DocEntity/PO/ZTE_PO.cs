using ExcelOperations.Entities.DocEntity;

namespace ExcelOperations.DocEntity.Entity.PO
{
    public class ZTE_PO : EntityBase
    {
        public string? ZTE_ID { get; set; }
        public string? PO { get; set; }

        [ColumnName("Order Position")]
        public string? Order_Position { get; set; }
        public string? PO_U_ID { get; set; }
        public string? PODate { get; set; }
        public string? Material { get; set; }

        [ColumnName("Material Bezeichnung")]
        public string? Material_Bezeichnung { get; set; }
        public string? Position { get; set; }
        public string? note1 { get; set; }
        public string? Acc1 { get; set; }

        [ColumnName("Rech No1")]
        public string? Rech_No1 { get; set; }

        [ColumnName("Acc 2")]
        public string? Acc_2 { get; set; }

        [ColumnName("Rech no 2")]
        public string? Rech_no_2 { get; set; }
        public string? MP_Bezeichnung { get; set; }
        public string? NE_Name2 { get; set; }
        public string? SO_Nr { get; set; }
        public string? NE_Nr { get; set; }

        [ColumnName("Projekt-ID")]
        public string? Projekt_ID { get; set; } // project id

        [ColumnName("MP ID")]
        public string? MP_ID { get; set; }
        public string? NE { get; set; }

        [ColumnName("Objekt-Art")]
        public string? Objekt_Art { get; set; }

        [ColumnName("Objekt-Bemerkung")]
        public string? Objekt_Bemerkung { get; set; }
        public string? Action { get; set; }

        [ColumnName("Team RAW")]
        public string? Team_RAW { get; set; }

        [ColumnName("Team2 FULL")]
        public string? Team2_FULL { get; set; }

        [ColumnName("Action Detail")]
        public string? Action_Detail { get; set; }

        [ColumnName("Action Plan")]
        public string? Action_Plan { get; set; }
        public string? Mat { get; set; }
        public string? Ist_Stx48 { get; set; }
        public string? Ist_Stx50 { get; set; }
        public string? Plan_Stx71 { get; set; }
        public string? Ist_Stx71 { get; set; }
        public string? Ist_Stx71a { get; set; }
        public string? Ist_Stx71b { get; set; }
        public string? Ist_Stx71c { get; set; }
        public string? Ist_Stx88i { get; set; }
        public string? Ist_Stx90 { get; set; }
        public string? Ist_Stx91 { get; set; }
        public string? Comment { get; set; }
        public string? Cabinet { get; set; }
        public string? inst { get; set; }
        public string? Power { get; set; }
        public string? Fiber { get; set; }
        public string? Bemerkung { get; set; }
        public string? Column1 { get; set; }
    }
}
