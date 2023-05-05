using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.LagerDTO
{
    public class LagerCentralDTO
    {
        [ColumnName("IM NO")]
        public string? IM_NO { get; set; }
        public string? NE_Nr { get; set; }
        public string? SO_Nr { get; set; }

        [ColumnName("Service PO")]
        public string? Service_PO { get; set; }
        public string? PID { get; set; }  // Project ID
        public string? NE { get; set; }
    }
}
