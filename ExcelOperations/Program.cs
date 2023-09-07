using ExcelOperations.Context;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ExcelOperations.Repository.UnitOfWork;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using ExcelOperations.Authenticate.AuthenticateOperations.Repos;
using ExcelOperations.ApiConfiguration.MvcFilter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ExcelOperations", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Here is enter the Bearer key!",
        Type = SecuritySchemeType.ApiKey,
        In = ParameterLocation.Header,
        Name = HeaderNames.Authorization,
        Scheme = "Bearer"
    });

    c.OperationFilter<SwaggerAuthenticateHeaderFilter>();
});

builder.Services.AddAuthentication(
    options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(
    o =>
    {
        var key = Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JWT:Key").Value);
        o.SaveToken = true;
        o.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration.GetSection("JWT:Issuer").Value,
            ValidAudience = builder.Configuration.GetSection("JWT:Audience").Value,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience =false,
            ValidateLifetime = true
        };

        o.Events = new JwtBearerEvents()
        {
            //OnMessageReceived = messageReceivedContext =>
            //{
            //    var authToken = messageReceivedContext.Token;

            //    Console.WriteLine(authToken);

            //    messageReceivedContext.Success();
                
            //    return Task.CompletedTask;
            //}
        };
    });

//builder.Services.AddDefaultIdentity<IdentityUser>(... )
//    .AddRoles<IdentityRole>();

builder.Services.AddTransient<IJWTManagerRepository, JWTManagerRepository>(); 

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
builder.Services.AddLogging();

builder.Services.AddAuthorization(
    opt =>
    {
        opt.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
    }
    );

//builder.Services.AddTransient<EnsureDatabaseMiddleware>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors("myCors");
app.MapControllers();

app.Run();
