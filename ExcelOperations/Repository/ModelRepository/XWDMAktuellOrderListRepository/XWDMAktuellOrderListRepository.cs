using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.XWDMAktuellOrderListRepository
{
    public class XWDMAktuellOrderListRepository : GenericRepository<XWDMAktuell>, IXWDMAktuellOrderListRepository
    {
        public XWDMAktuellOrderListRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
