using ExcelOperations.Context;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.RouterAktuellOrderListRepository
{
    public class RouterAktuellOrderListRepository : GenericRepository<RouterAktuellOrderList>, IRouterAktuellOrderListRepository
    {
        public RouterAktuellOrderListRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
