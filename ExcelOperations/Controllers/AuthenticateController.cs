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


        //private readonly IJWTManagerRepository _JWTManagerRepository;
        //public AuthenticateController(IJWTManagerRepository jWTManagerRepository, IUnitOfWork unitOfWork)
        //{
        //    _JWTManagerRepository = jWTManagerRepository;
        //    _unitOfWork = unitOfWork;
        //}

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("authenticate")]
        //public IActionResult Authenticate(User user) 
        //{
        //    var token = _JWTManagerRepository.Authenticate(user);

        //    if (token == null)
        //    {
        //        return Unauthorized();
        //    }

        //    return Ok(token);
        //}


        //[HttpGet]
        //[Route("AllUsers")]
        //public IActionResult Get() 
        //{
        //    var result = _unitOfWork.UserRepository.GetAll();
        //    return Ok(result);
        //}



        public AuthenticateController(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;

        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(UserDTO request, CancellationToken cancellationToken)
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
    }
}
 