using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.AktuellDTO
{
    public class XWDMAktuellOrderListDTO
    {
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
    }
}
