using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.CiscoPoRepository
{
    public class CiscoPoRepository : GenericRepository<Cisco_PO>, ICiscoPoRepository 
    {
        public CiscoPoRepository(EntityDbContext dbContext) : base(dbContext) { }

        public Cisco_PO GetNewCisco() 
        {
            return new Cisco_PO(); 
        }
    }
}
