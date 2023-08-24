using ExcelOperations.Entities.DocEntity.UserInfo;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ExcelOperations.Authenticate.AuthenticateOperations
{
    public class CreateTokenOperations
    {
        private readonly IConfiguration _configuration;
        public CreateTokenOperations(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity
            (
                claims
            ),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds,
                //Audience = Audience,
                //Issuer = Issuer,
                //IssuedAt = issueDateTime,
                //NotBefore = issueDateTime
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);


            //var token = new JwtSecurityToken
            //    (
            //    claims: claims,
            //    expires: DateTime.Now.AddDays(1),
            //    signingCredentials: creds
            //    );
                     
            return tokenHandler.WriteToken(token);
        }
    }
}
