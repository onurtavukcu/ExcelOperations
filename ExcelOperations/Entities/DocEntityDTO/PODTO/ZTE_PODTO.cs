using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.PODTO
{
    public class ZTE_PODTO
    {
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
    }
}
