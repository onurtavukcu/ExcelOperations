using ExcelOperations.Entities.DocEntity.UserInfo;
using ExcelOperations.Repository.UnitOfWork;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ExcelOperations.Authenticate.AuthenticateOperations.Repos
{
    public class JWTManagerRepository : IJWTManagerRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly string _JWTKey;

        public JWTManagerRepository(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _JWTKey = _configuration.GetSection("JWT:Key").Value!;
        }

        public Tokens Authenticate(User user)
        {
            
            if (_unitOfWork.UserRepository.GetAll().SingleOrDefault(usr => usr.Username == user.Username) == null)
            {
                return null;
            }

            //generate jwt
            var tokenHandler = new JwtSecurityTokenHandler();
          

            var tokenKey = Encoding.UTF8.GetBytes(_JWTKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Username)
                    }),
                Expires = DateTime.UtcNow.AddDays(1 ),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new Tokens { Token = tokenHandler.WriteToken(token) };
        }

        public int? ValidateJwtToken(string token)
        {
            if (token == null)
                return null;

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
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

                return userId;
            }
            catch
            {
                return null;
            }
        }
    }
}
