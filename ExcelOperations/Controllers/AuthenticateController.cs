using AutoMapper;
using ExcelOperations.Authenticate.AuthenticateOperations;
using ExcelOperations.Context;
using ExcelOperations.Entities.DocEntity.UserInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : Controller
    {
        private readonly EntityDbContext _EntityDbContext;

        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;

        public AuthenticateController(EntityDbContext dbContext, IMapper mapper, IConfiguration configuration)
        {
            _EntityDbContext = dbContext;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(UserDTO request, CancellationToken cancellationToken)
        {
            User user = new User();

            var userNameQuery = _EntityDbContext.UserInputs
             .SingleOrDefault(usr => usr.Username == request.Username);

            if (userNameQuery is not null)
            {
                return BadRequest("User Already Exist");
            }

            var hashResult = PasswordHashingOperations.CreatePasswordHash(request.Password);
            user.Username = request.Username;
            user.passwordHash = hashResult;

            _EntityDbContext.Add(user);

            _EntityDbContext.SaveChanges();

            return Ok(user);
        }

        [HttpPost]
        public ActionResult<string> Authenticate(UserDTO request, CancellationToken cancellationToken)
        {
            var userNameQuery = _EntityDbContext.UserInputs
              .SingleOrDefault(usr => usr.Username == request.Username);
            
            if (userNameQuery is null)
            {
                return BadRequest("User Not Found!");
            }

            if (PasswordHashingOperations.VerifyPasswordHash(request.Password, userNameQuery.passwordHash))
            {
                return BadRequest("Wrong Password!");
            }

            var tokenInstance = new CreateTokenOperations(_configuration);

            string token = tokenInstance.CreateToken(userNameQuery);

            return Ok(token);
        }

        [HttpGet, Authorize]
        public ActionResult<string> GetClaims()
        {
            var userName = User?.Identity?.Name;
            return Ok(userName);
        }
    }
}
 