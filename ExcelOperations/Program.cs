using ExcelOperations.Context;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ExcelOperations.Repository.UnitOfWork;
using ExcelOperations.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EntityDbContext>
    (options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("ExcelOperationsDatabase"),
        b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName))
        );

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(
    cors => cors.AddPolicy("myCors", pb =>
    {
        pb.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod().Build();
    })
    );

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
            .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false,
        };
    }
    );
builder.Services.AddTransient<ElapsedTimerMiddleware>();
//builder.Services.AddTransient<ExceptionHandleMiddleware>();

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

app.UseMiddleware<ElapsedTimerMiddleware>();
//app.UseMiddleware<ExceptionHandleMiddleware>();

app.Run();


//app.Use(async (ctx, next) =>
//{
//    ctx.Response.Headers["Access-Control-Allow-Origin"] = "http://localhost:3000/";
//    if (HttpMethods.IsGet(ctx.Request.Method) || HttpMethods.IsPost(ctx.Request.Method))
//    {
//        ctx.Response.Headers["Access-Control-Allow-Headers"] = "*";
//        await ctx.Response.CompleteAsync();
//        return;
//    }

//    await next();
//}).Build();  //endpoint gelmiyor.

//app.Use(async (ctx, next) =>
//{
//    var start = DateTime.UtcNow;
//    await next.Invoke(ctx); //pass the context
//    app.Logger.LogInformation($"Duration:{(DateTime.UtcNow - start).TotalMilliseconds}");
//});

//app.Use((HttpContext ctx, Func<Task> next) =>
//{
//    app.Logger.LogInformation("Terminate");
//    return Task.CompletedTask;
//});
