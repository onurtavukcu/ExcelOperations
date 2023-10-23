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
            _next(context);
        }
    }
}
