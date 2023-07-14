using ExcelOperations.Entities;
using ExcelOperations.Entities.DocEntity;

namespace ExcelOperations.DocEntity.PO
{
    public class Deltatel_PO : EntityBase
    {
        public string? PO_ID { get; set; }

        [ColumnName("Change History")]
        public string? Change_History { get; set; }

        [ColumnName("Rep Office")]
        public string? Rep_Office { get; set; }

        [ColumnName("Project Code")]
        public string? Project_Code { get; set; }

        [ColumnName("Site Code")]
        public string? Site_Code { get; set; }  //project ıd

        [ColumnName("Site Name")]
        public string? Site_Name{ get; set; }

        [ColumnName("Site ID")]
        public string? Site_ID{ get; set; }

        [ColumnName("Sub Contract NO.")]
        public string? Sub_Contract_NO { get; set; }

        [ColumnName("PR NO.")]
        public string? PR_NO { get; set; }

        [ColumnName("PO NO.")]
        public string? PO_NO{ get; set; }

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

        [ColumnName("Due Qty")]
        public string? Due_Qty { get; set; }

        [ColumnName("Note to Receiver")]
        public string? Note_to_Receiver { get; set; }

        [ColumnName("Fob Lookup Code")]
        public string? Fob_Lookup_Code { get; set; }

        [ColumnName("Acceptance Date")]
        public string? Acceptance_Date { get; set; }

        [ColumnName("PO NWT")]
        public string? PO_NWT { get; set; }

        [ColumnName("Acc to DTL1")]
        public string? Acc_to_DTL1 { get; set; }

        [ColumnName("File Number1")]
        public string? File_Number1 { get; set; }
        public string? invoice1 { get; set; }

        [ColumnName("faturadaki sira1")]
        public string? faturadaki_sira1 { get; set; }

        [ColumnName("Payment Rate1")]
        public string? Payment_Rate1 { get; set; }
        
        [ColumnName("Acc to DTL2")]
        public string? Acc_to_DTL2 { get; set; }

        [ColumnName("File Number2")]
        public string? File_Number2 { get; set; }
        public string? invoice2 { get; set; }     
        
        [ColumnName("faturadaki sira2")]
        public string? faturadaki_sira2 { get; set; }

        [ColumnName("Payment Rate2")]
        public string? Payment_Rate2 { get; set; }
    }
}
