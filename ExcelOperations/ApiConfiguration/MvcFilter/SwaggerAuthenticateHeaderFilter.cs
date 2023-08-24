using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace ExcelOperations.ApiConfiguration.MvcFilter
{
    public class SwaggerAuthenticateHeaderFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (context.ApiDescription.ActionDescriptor is not ControllerActionDescriptor actionDescriptor)
                return;

            var authAttr = actionDescriptor.MethodInfo.GetCustomAttribute<AuthorizeAttribute>();

            if (authAttr is not null)
            {
                var jwtBearerScheme = new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
                };

                operation.Security = new List<OpenApiSecurityRequirement>
                {
                    new()
                    {
                        [jwtBearerScheme] = new [] {"bearer "}
                    }
                };
            }
        }
    }
}
