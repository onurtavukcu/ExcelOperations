using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.Repository.Implementor;
using System.Data.Entity;

namespace ExcelOperations.Repository.ModelRepository.RouterAktuellRepository
{
    public class RouterAktuellRepository : GenericRepository<RouterAktuell>, IRouterAktuellRepository
    {
        public RouterAktuellRepository(EntityDbContext dbContext) : base(dbContext) { }

        public IEnumerable<RouterAktuell> GetRouterSwapAktuell()
        {
            return _dbContext.RouterAktuell.Include(rsa => rsa.Projekt_ID).ToList();

        }
    }
}
