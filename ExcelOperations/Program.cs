using ExcelOperations.Context;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using AutoMapper;
using ExcelOperations.Configurations.MappingEntity;
using ExcelOperations.Operations.ExcelToFileModelOperations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EntityDbContext>
    (options =>
        options.UseLazyLoadingProxies(true)
        .UseNpgsql(builder.Configuration.GetConnectionString("ExcelOperationsDatabase"),
        b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName))
        );

builder.Services.AddScoped<DbContext>(provider => provider.GetService<EntityDbContext>());

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//builder.Services.AddScoped(typeof(IGetDataFromExcel<>), typeof(ExcelFileToModelOps<>)); add generic DI

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
 