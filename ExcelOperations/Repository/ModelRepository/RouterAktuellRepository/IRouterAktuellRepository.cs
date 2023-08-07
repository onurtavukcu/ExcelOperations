using ExcelOperations.DocEntity;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.RouterAktuellRepository
{
    public interface IRouterAktuellRepository : IGenericRepository<RouterAktuell>
    {
        IEnumerable<RouterAktuell> GetRouterSwapAktuell();
    }
}
