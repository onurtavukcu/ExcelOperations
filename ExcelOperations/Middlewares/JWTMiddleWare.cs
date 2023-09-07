//using ExcelOperations.Authenticate.AuthenticateOperations;


//namespace ExcelOperations.Middlewares
//{
//    public class JwtMiddleware
//    {
//        private readonly ILogger _logger;
//        private readonly IConfiguration _configuration;
//        private readonly RequestDelegate _next;

//        public JwtMiddleware(ILogger<JwtMiddleware> logger, IConfiguration configuration, RequestDelegate next)
//        {
//            _logger = logger;
//            _configuration = configuration;
//            _next = next;
//        }

//        public async Task Invoke(HttpContext context, RequestDelegate _next)
//        {
//            var createToken = new CreateTokenOperations(_configuration);

//            context.Response.Headers.Add("Authorization", createToken.ToString());

//            //var userRole = createToken.ValidateJwtToken(token);

//            //if (userRole != null)
//            //{
//            //    context.Items["UserRole"] = userRole;
//            //}

//            await _next.Invoke(context);
//        }
//    }
//}

using ExcelOperations.Authenticate.AuthenticateOperations;

namespace ExcelOperations.Middlewares
{
    public class JwtMiddleware
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly RequestDelegate _next;

        public JwtMiddleware(ILogger<JwtMiddleware> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
            var createToken = new CreateTokenOperations(_configuration);
            string token = createToken.ToString();

            // Set the JWT token in the response header
            context.Response.Headers.Add("Authorization", token);

            await _next(context);
        }
    }
}