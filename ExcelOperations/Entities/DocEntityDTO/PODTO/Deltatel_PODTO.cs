using ExcelOperations.DocEntity;

namespace ExcelOperations.Entities.DocEntityDTO.PODTO
{
    public class Deltatel_PODTO
    {
        [ColumnName("Project Code")]
        public string? Project_Code { get; set; }

        [ColumnName("Site Code")]
        public string? Site_Code { get; set; }  //project ıd

        [ColumnName("Site Name")]
        public string? Site_Name { get; set; }

        [ColumnName("Site ID")]
        public string? Site_ID { get; set; }

        [ColumnName("Sub Contract NO.")]
        public string? Sub_Contract_NO { get; set; }

        [ColumnName("PR NO.")]
        public string? PR_NO { get; set; }

        [ColumnName("PO NO.")]
        public string? PO_NO { get; set; }

        [ColumnName("PO Line NO.")]
        public string? PO_Line_NO { get; set; }

        [ColumnName("Shipment NO.")]
        public string? Shipment_NO { get; set; }

        [ColumnName("Item Code")]
        public string? Item_Code { get; set; }

        [ColumnName("Item Description")]
        public string? Item_Description { get; set; }

        [ColumnName("Item Description(Local)")]
        public string? Item_Description_Local { get; set; }

        [ColumnName("Requested Qty")]
        public string? Requested_Qty { get; set; }

        [ColumnName("Billed Quantity")]
        public string? Billed_Quantity { get; set; }

        [ColumnName("Quantity Cancel")]
        public string? Quantity_Cancel { get; set; }
    }
}
