using ExcelOperations.Context;
using Microsoft.EntityFrameworkCore;

namespace ExcelOperations.Middlewares
{
    public class EnsureDatabaseMiddleware : IMiddleware
    {
        public readonly ILogger _logger;
        public readonly EntityDbContext _entityDbContext;

        public EnsureDatabaseMiddleware(ILogger<EnsureDatabaseMiddleware> logger, EntityDbContext entityDbContext)
        {
            _logger = logger;
            _entityDbContext = entityDbContext;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await Task.FromResult(EnsureAndMigrateDatabase());
        }

        public async Task<bool> EnsureAndMigrateDatabase()
        {
            await _entityDbContext.Database.MigrateAsync();

            return await _entityDbContext.Database.EnsureCreatedAsync(new CancellationToken());
        }
    }
}
