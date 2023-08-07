using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.ZTEPORepository
{
    public class ZTEPORepository : GenericRepository<ZTE_PO>, IZTEPORepository
    {
        public ZTEPORepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
