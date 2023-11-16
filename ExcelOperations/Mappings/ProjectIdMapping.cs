using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.DocEntity.PO;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcelOperations.Mappings
{
    public class ProjectIdMapping
    {
        public int ProjectId { get; set; }
        public int? RouterAktuellId { get; set; }
        public int? RouterAktuellOrderListId { get; set; }
        public int? XWDMAktuelId { get; set; }
        public int? XWDMAktuelOrderListId { get; set; }
        public int? LagerCentralId { get; set; }
        public int? CiscoPOId { get; set; }
        public int? DeltaTelPOId { get; set; }
        public int? ZTEPOId { get; set; }
        public int? JSLMultiProjectId { get; set; }
        public int? MultiProjectId { get; set; }
        public int? RouterSwapAktuellId { get; set; }

        public virtual RouterAktuell? RouterAktuell { get; set; }
        public virtual RouterAktuellOrderList? RouterAktuellOrderList { get; set; }
        public virtual XWDMAktuell? XWDMAktuell { get; set; }
        public virtual XWDMAktuellOrderList? XWDMAktuellOrderList { get; set; }
        public virtual LagerCentral? LagerCentral { get; set; }
        public virtual Cisco_PO? Cisco_PO { get; set; }
        public virtual Deltatel_PO? Deltatel_PO { get; set; }
        public virtual ZTE_PO? ZTE_PO { get; set; }
        public virtual JSLMultiProject? JSLMultiProject { get; set; }
        public virtual MultiProject? MultiProject { get; set; }
        public virtual RouterSwapAktuell? RouterSwapAktuell { get; set; }
    }
}
