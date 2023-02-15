﻿namespace ExcelOperations.DocEntity.Lager
{
    public class Depo
    {
        public string? DepoID { get; set; }
        public string? Sender { get; set; }
        public string? Lager { get; set; }
        public string? Date { get; set; }

        [ColumnName("IM NO")]
        public string? IM_NO { get; set; }
        public string? NE_Nr { get; set; }
        public string? SO_Nr { get; set; }

        [ColumnName("Service PO")]        
        public string? Service_PO { get; set; }
        public string? PID { get; set; }
        public string? NE { get; set; }
        public string? Qnt { get; set; }
        public string? Project { get; set; }
        public string? LagerPO { get; set; }

        [ColumnName("Rec. Date")]
        public string? Rec_Date { get; set; }
        public string? Where { get; set; }
        public string? when { get; set; }
        public string? Comment1 { get; set; }
        public string? check { get; set; }
        public string? Team { get; set; }
        public string? Action { get; set; }
        public string? Status { get; set; }
    }
}
