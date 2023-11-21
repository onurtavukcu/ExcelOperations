using ExcelOperations.Context;
using ExcelOperations.Mappings;
using ExcelOperations.Repository.Implementor;
using ExcelOperations.Repository.ModelRepository.ProjectIdMappingRepository;

namespace ExcelOperations.Repository.ModelRepository.SONRMappingRepository
{
    public class SONRMappingRepository: GenericRepository<SONRMapping>, ISONRMappingRepository
    {
        public SONRMappingRepository(EntityDbContext dbContext): base(dbContext) { }        
    }
}