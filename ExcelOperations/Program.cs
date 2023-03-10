using ExcelOperations.Context;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EntityDbContext>
    (options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("ExcelOperationsDatabase"),
        b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)));

builder.Services.AddScoped<DbContext>(provider => provider.GetService<EntityDbContext>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider
//        .GetRequiredService<EntityDbContext>();

//    var result = dbContext.CheckTableInDatabase<EntityDbContext>();
    
//    if (!result)
//    {
//        return;
//    }

//    dbContext.Database.EnsureCreated();
//    dbContext.Database.CreateExecutionStrategy
//    //dbContext.Database.Migrate();
//}

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
    
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
