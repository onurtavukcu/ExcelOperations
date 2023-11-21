using ExcelOperations.Context;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.Mappings;
using ExcelOperations.Repository.Implementor;
using ExcelOperations.Repository.ModelRepository.RouterAktuellOrderListRepository;

namespace ExcelOperations.Repository.ModelRepository.ProjectIdMappingRepository
{
    public class ProjectMappingRepository : GenericRepository<ProjectIdMapping>, IProjectMappingRepository

    {
        public ProjectMappingRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
