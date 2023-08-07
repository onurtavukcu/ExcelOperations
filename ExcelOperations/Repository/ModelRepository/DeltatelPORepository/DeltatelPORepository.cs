using ExcelOperations.Context;
using ExcelOperations.DocEntity.PO;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.DeltatelPORepository
{
    public class DeltatelPORepository : GenericRepository<Deltatel_PO>, IDeltatelPORepository
    {
        public DeltatelPORepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
