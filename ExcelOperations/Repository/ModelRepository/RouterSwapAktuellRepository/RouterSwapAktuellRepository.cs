using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.RouterSwapAktuellRepository
{
    public class RouterSwapAktuellRepository : GenericRepository<RouterSwapAktuell>, IRouterSwapAktuellRepository
    {
        public RouterSwapAktuellRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
