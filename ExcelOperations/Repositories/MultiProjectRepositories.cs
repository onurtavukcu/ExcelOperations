using ExcelOperations.Context;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.Entities.DocEntityDTO.POCDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

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
