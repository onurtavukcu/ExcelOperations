using AutoMapper;
using ExcelOperations.Authenticate.AuthenticateOperations;
using ExcelOperations.Entities.UserInfo;
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

        private readonly IConfiguration _configuration;

        public AuthenticateController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin(UserDTO request, CancellationToken cancellationToken)  // Bu endpoint test için. Admin Kullanıcısı statik olarak elle tanımlanmalı.
        {
            User user = new User();

            var userNameQuery = _unitOfWork.UserRepository.GetAll().SingleOrDefault(usr => usr.Username == request.Username);

            if (userNameQuery is not null)
            {
                return  BadRequest("User Already Exist");
            }

            if (request.Username is null || request.Password is null)
            {
                return BadRequest("Enter Valid Username or Password!");
            }
            var hashResult = PasswordHashingOperations.CreateHash(request.Password); //fix returned string

            user.Username = request.Username;
            user.PasswordHash = hashResult;
            user.UserTypeId = 1;

            _unitOfWork.UserRepository.AddAsync(user);

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

            _unitOfWork.UserRepository.AddAsync(user);

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

            var tokenInstance = new TokenOperations(_configuration);

            string token = tokenInstance.CreateToken(userNameQuery);

            return Ok(token);
        }

        [HttpGet]
        [Route("testAuthAdmin")]
        [Authorize(Roles = "1")]
        public ActionResult<string> TestAuthAdmin()
        {
            var userName = User?.Identity?.Name;

            return Ok(userName);
        }

        [HttpGet]
        [Route("testAuthRergular")]
        [Authorize(Roles = "2")]
        public ActionResult<string> TestAuthRegular()
        {
            var userName = User?.Identity?.Name;

            return Ok(userName);
        }
    }
}
 