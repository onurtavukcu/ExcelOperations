using ExcelOperations.Entities.UserInfo;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ExcelOperations.Authenticate.AuthenticateOperations
{
    public class TokenOperations
    {
        private readonly IConfiguration _configuration;
        private readonly string _JWTKey;
        public TokenOperations(IConfiguration configuration)
        {
            _configuration = configuration;
            _JWTKey = _configuration.GetSection("JWT:Key").Value!;
        }

        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.UserTypeId.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_JWTKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity
            (
                claims
            ),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public bool ValidateJwtToken(string token)
        {
            if (token == null)
                return false;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_JWTKey);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                //var _userName = int.Parse(jwtToken.Claims.First(x => x.Type == "Username").Value);
                //var _userRole = int.Parse(jwtToken.Claims.First(x => x.Type == "UserTypeId").Value);
                return true;
                
                //return  
                //    new LoginUserDto
                //    {                
                //        userRole = _userRole
                //    };
            }
            catch
            {
                // return null if validation fails
                return false;
            }
        }

        public class LoginUserDto
        {
            //public string username;
            public int userRole;
        }
    }
}
