using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Patterns;

namespace ExcelOperations.Middlewares
{
    public class AuthenticationsMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var route = context.Request.Path.Value;

            var authorization = context.Request.RouteValues;

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
            await _next(context);
        }
    }
}
