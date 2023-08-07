using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.XWDMAktuellRepository
{
    public class XWDMAktuellRepository : GenericRepository<XWDMAktuell>, IXWDMAktuellRepository
    {
        public XWDMAktuellRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
