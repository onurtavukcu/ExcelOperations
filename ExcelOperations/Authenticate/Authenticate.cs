namespace ExcelOperations.Authenticate
{
    public class Authenticate
    {
        IAuthenticate authenticate;
        public bool Login(IAuthInfo authInfo)
        {
            if (authenticate.Login(authInfo))
            {
                return true;
            }
            return false;
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }        
    }
}
