using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.PODTO
{
    public class Cisco_PODTO
    {
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
        public string? Objekt_ID { get; set; }  //project Id
        public string? NE { get; set; }
        public string? Projekt { get; set; }
        public string? Address { get; set; }
        public string? Team { get; set; }
    }
}
