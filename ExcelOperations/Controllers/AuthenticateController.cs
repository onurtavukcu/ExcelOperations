using AutoMapper;
using ExcelOperations.Authenticate.AuthenticateOperations;
using ExcelOperations.Entities.DocEntity.UserInfo;
using ExcelOperations.Repository.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExcelOperations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        private readonly IConfiguration _configuration;

        public AuthenticateController(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin(UserDTO request, CancellationToken cancellationToken)
        {
            User user = new User();

            var userNameQuery = _unitOfWork.UserRepository.GetAll().SingleOrDefault(usr => usr.Username == request.Username);

            if (userNameQuery is not null)
            {
                return BadRequest("User Already Exist");
            }

            if (request.Username is null || request.Password is null)
            {
                return BadRequest("Enter Valid Username or Password!");
            }
            var hashResult = PasswordHashingOperations.CreateHash(request.Password); //fix returned string

            user.Username = request.Username;
            user.PasswordHash = hashResult;
            user.UserTypeId = 1;

            _unitOfWork.UserRepository.Add(user);

            var result = _unitOfWork.UserRepository.SaveEntity(user);

            if (!(result == 1))
            {
                return BadRequest("User Can No Be Save!");
            }

            return await Task.FromResult<IActionResult>(Ok(result));
        }

        [HttpPost]
        [Route("RegisterRegularUser")]
        public async Task<IActionResult> RegisterRegularUser(UserDTO request, CancellationToken cancellationToken)
        {
            User user = new User();

            var userNameQuery = _unitOfWork.UserRepository.GetAll().SingleOrDefault(usr => usr.Username == request.Username);

            if (userNameQuery is not null)
            {
                return BadRequest("User Already Exist");
            }

            if (request.Username is null || request.Password is null)
            {
                return BadRequest("Enter Valid Username or Password!");
            }
            var hashResult = PasswordHashingOperations.CreateHash(request.Password);

            user.Username = request.Username;
            user.PasswordHash = hashResult;
            user.UserTypeId = 2;

            _unitOfWork.UserRepository.Add(user);

            var result = _unitOfWork.UserRepository.SaveEntity(user);

            if (!(result == 1))
            {
                return BadRequest("User Can No Be Save!");
            }

            return await Task.FromResult<IActionResult>(Ok(result));
        }

        [HttpPost]
        public ActionResult<string> Authenticate(UserDTO request, CancellationToken cancellationToken)
        {
            var userNameQuery = _unitOfWork
                .UserRepository
                .GetByFilter(usr => usr.Username == request.Username)
                .SingleOrDefault();

            if (request.Username is null || request.Password is null)
            {
                return BadRequest("Enter Valid Username or Password!");
            }

            if (userNameQuery is null)
            {
                return BadRequest("User Not Found!");
            }

            if (PasswordHashingOperations.VerifyPasswordHash(request.Password, userNameQuery.PasswordHash))
            {
                return BadRequest("Wrong Password!");
            }

            var tokenInstance = new CreateTokenOperations(_configuration);

            string token = tokenInstance.CreateToken(userNameQuery);

            return Ok(token);
        }

        [HttpGet]
        [Authorize]
        public ActionResult<string> GetClaims()
        {
            var userName = User?.Identity?.Name;

            return Ok(userName);
        }

        //[HttpGet]
        //[Authorize(Policy = "Admin")]
        //public ActionResult<string> GetClaims()
        //{
        //    var userName = User?.Identity?.Name;

        //    return Ok(userName);
        //}

        //[HttpGet]
        //[Authorize(Policy = "AdminOnly")]
        //public ActionResult<string> GetClaimer()
        //{
        //    var userName = User?.Identity?.Name;

        //    return Ok(userName);
        //}
    }
}
 