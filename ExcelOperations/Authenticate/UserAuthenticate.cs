using ExcelOperations.Context;

namespace ExcelOperations.Authenticate
{
    public class UserAuthenticate : IAuthenticate
    {
        private readonly EntityDbContext _EntityDbContext;
        public bool Login(IAuthInfo authInfo)
        {
            throw new NotImplementedException();
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }
    }
}
