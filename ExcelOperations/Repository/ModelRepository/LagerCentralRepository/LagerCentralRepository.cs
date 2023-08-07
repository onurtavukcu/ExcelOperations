using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.LagerCentralRepository
{
    public class LagerCentralRepository : GenericRepository<LagerCentral>, ILagerCentralRepository
    {
        public LagerCentralRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
