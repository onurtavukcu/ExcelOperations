using ExcelOperations.Context;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EntityDbContext>  //her tablo icin ayri ayri baglanti mi ????
    (options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("ExcelOperationsDatabase"),
        b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)));

builder.Services.AddScoped<DbContext>(provider => provider.GetService<EntityDbContext>());  //dbcontext -> RouterAktuellDbContext

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

app.MapControllers();

app.Run();
