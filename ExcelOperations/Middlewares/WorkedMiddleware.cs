namespace ExcelOperations.Middlewares
{
    public class WorkedMiddleware
    {
        private readonly ILogger<WorkedMiddleware> _logger;
        private readonly RequestDelegate _next;
        public WorkedMiddleware(ILogger<WorkedMiddleware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(HttpContext ctx)
        {
            var startDateTime = DateTime.UtcNow;

            await _next.Invoke(ctx);

            _logger.LogInformation($"Request {ctx.Request.Path}: {(DateTime.UtcNow - startDateTime).TotalSeconds}");
        }
    }

    //public static class WorkedMiddlewareExtensions 
    //{
    //    public static IApplicationBuilder UseWorkedM(this IApplicationBuilder app)
    //    {
    //        return app.UseMiddleware<WorkedMiddleware>();
    //    }
    //}
}
