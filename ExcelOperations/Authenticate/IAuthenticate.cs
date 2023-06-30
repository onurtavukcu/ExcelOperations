using Microsoft.AspNetCore.Identity;

namespace ExcelOperations.Authenticate
{
    public interface IAuthenticate
    {
        public bool Login(IAuthInfo authInfo);
        public bool Logout();
    }
}
