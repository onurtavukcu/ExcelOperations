using Newtonsoft.Json;

namespace ExcelOperations.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        private readonly ILogger<ExceptionMiddleware> _logger;
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext ctx)
        {
            try
            {
                await _next.Invoke(ctx);  // NOT WORKED. WORK ON IT !!!

                if (ctx.Response.StatusCode >= 400)
                {
                    _logger.LogError($"Request failed with status code: {ctx.Response.StatusCode}");
                    Console.WriteLine("TESTESTESTE");
                   
                    ctx.Response.ContentType = "application/json";
                   
                    var jsonResponse = JsonConvert.SerializeObject(ctx.Response.Body);
                    await ctx.Response.WriteAsync(jsonResponse);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                var response = ctx.Response;
                
                response.ContentType = "application/json";

                await response.WriteAsync(ex.Message);

                if (ex.InnerException != null)
                {
                    _logger.LogError(ex.InnerException.Message);
                }                
            }
        }
        public class ErrorResponse
        {
            public int StatusCode { get; set; }
            public string Message { get; set; }
            // You can include additional properties if needed, such as ErrorCode, Details, etc.
        }
    }
}
