using ExcelOperations.Entities.DocEntity.UserInfo;

namespace ExcelOperations.Authenticate.AuthenticateOperations.Repos
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(User user); 
    }
}
