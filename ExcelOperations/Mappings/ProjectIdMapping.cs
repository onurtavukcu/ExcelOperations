using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.DocEntity.PO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcelOperations.Mappings
{
    public class ProjectIdMapping
    {
        public virtual int ProjectId { get; set; }
        public virtual int? RouterAktuellId { get; set; }
        public virtual int? RouterAktuellOrderListId { get; set; }
        public virtual int? XWDMAktuelId { get; set; }
        public virtual int? XWDMAktuelOrderListId { get; set; }
        public virtual int? LagerCentralId { get; set; }
        public virtual int? CiscoPOId { get; set; }
        public virtual int? DeltaTelPOId { get; set; }
        public virtual int? ZTEPOId { get; set; }
        public virtual int? JSLMultiProjectId { get; set; }
        public virtual int? MultiProjectId { get; set; }
        public virtual int? RouterSwapAktuellId { get; set; }

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
