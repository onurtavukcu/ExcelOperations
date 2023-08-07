using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.MultiProjectRepository
{
    public class MultiProjectRepository : GenericRepository<MultiProject>, IMultiProjectRepository
    {
        public MultiProjectRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
