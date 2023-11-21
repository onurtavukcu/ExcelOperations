using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.DocEntity.Entity.Zugang;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcelOperations.Mappings
{
    public class SONRMapping
    {
        public int SoNRId { get; set; }
        public int? LagerCentralId { get; set; }
        public int? ZTEPOID { get; set; }
        public int? RouterAktuellId { get; set; }
        public int? XWDMAktuelId { get; set; }
        public int? RouterSwapAktuellId { get; set; }
        public int? ZugansdatenId { get; set; }

        public virtual LagerCentral? LagerCentral { get; set; }
        public virtual ZTE_PO? ZTE_PO { get; set; }
        public virtual RouterAktuell? RouterAktuell { get; set; }
        public virtual XWDMAktuell? XWDMAktuell { get; set; }
        public virtual RouterSwapAktuell? RouterSwapAktuell { get; set; }
        public virtual ZugangsdatenAktuell? ZugangsdatenAktuell { get; set; }
    }
}
