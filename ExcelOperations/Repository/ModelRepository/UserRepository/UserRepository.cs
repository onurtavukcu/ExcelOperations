using ExcelOperations.Context;
using ExcelOperations.Entities.DocEntity.UserInfo;
using ExcelOperations.Repository.Implementor;

namespace ExcelOperations.Repository.ModelRepository.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(EntityDbContext dbContext) : base(dbContext) { }
    }
}
