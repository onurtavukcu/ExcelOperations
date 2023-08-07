using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.JSLMultiPorjectRepository
{
    public class JSLMultiPorjectRepository : GenericRepository<JSLMultiProject>, IJSLMultiPorjectRepository
    {
        public JSLMultiPorjectRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
