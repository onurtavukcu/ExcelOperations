using ExcelOperations.Context;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperations.Operations.MinorOperations
{
    public class CheckDbTableExistance
    {
        private readonly EntityDbContext _DbContext;
        public CheckDbTableExistance(EntityDbContext _EntityDbContext)
        {
            _DbContext = _EntityDbContext;
        }
        public IQueryable<int> CheckTable()
        {
            var result = _DbContext.Database.SqlQuery<int>($@"Select cp.id from ""Cisco_POs"" cp where id < 2");
            
            return result;
        }
    }
}
