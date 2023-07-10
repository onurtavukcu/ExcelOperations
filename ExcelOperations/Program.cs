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
        b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName))
        );

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .Build();
    });
});


//builder.Services.AddScoped<DbContext>(provider => provider.GetService<EntityDbContext>());

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(
    cors => cors.AddPolicy("myCors", pb =>
    {
        pb.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod().Build();
    })
    );


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("myCors");

app.MapControllers();

app.Run();

app.Use(async (ctx, next) =>
{
    ctx.Response.Headers["Access-Control-Allow-Origin"] = "http://localhost:3000/";
    if (HttpMethods.IsOptions(ctx.Request.Method))
    {
        ctx.Response.Headers["Access-Control-Allow-Headers"] = "*";
        await ctx.Response.CompleteAsync();
        return;
    }

    await next();
}).Build();  //endpoint gelmiyor.