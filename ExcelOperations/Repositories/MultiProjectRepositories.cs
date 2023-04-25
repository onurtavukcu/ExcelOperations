using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.POC;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperations.Repositories
{
    public class MultiProjectRepositories
    {
        private readonly DbSet<MultiProject> _multiProject;

        public MultiProjectRepositories(EntityDbContext dbContext)
        {
            _multiProject = dbContext.Set<MultiProject>();
        }

        public DbSet<MultiProject> GetMultiProject()
        {
            return _multiProject;
        }
    }
}
