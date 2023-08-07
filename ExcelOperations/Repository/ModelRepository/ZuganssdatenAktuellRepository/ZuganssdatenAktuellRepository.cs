using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.Zugang;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.ZuganssdatenAktuellRepository
{
    public class ZuganssdatenAktuellRepository : GenericRepository<ZugangsdatenAktuell>, IZuganssdatenAktuellRepository
    {
        public ZuganssdatenAktuellRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
