using System.Diagnostics;

namespace ExcelOperations.Middlewares
{
    public class ElapsedTimerMiddleware : IMiddleware
    {
        public ILogger _logger;
        
        public ElapsedTimerMiddleware(ILogger<ElapsedTimerMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            await next(context);

            stopwatch.Stop();
            var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Elapsed Time: {elapsedMilliseconds}ms");
        }
    }
}
