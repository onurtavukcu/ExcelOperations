using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Patterns;

namespace ExcelOperations.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var route = context.Request.Path.Value;
            if (route != "/Authenticate")
            {
                var token = context.Request.Headers["Authorization"].FirstOrDefault();

                // If no token is provided, return unauthorized response
                if (token == null)
                {
                    context.Response.StatusCode = 401;
                    return;
                }
            }

            // TODO: Validate and decode the token here
            // Implement your JWT validation logic, validate the token, and extract user information

            // Example: 
            // var userId = YourJwtValidationMethod(token);
            // context.Items["UserId"] = userId;

            // Call the next delegate/middleware in the pipeline
            _next(context);
        }
    }
}
