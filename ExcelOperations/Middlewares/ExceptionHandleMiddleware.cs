﻿    using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace ExcelOperations.Middlewares
{
    public class ExceptionHandleMiddleware : IMiddleware
    {
        private readonly ILogger _logger;

        public ExceptionHandleMiddleware(ILogger<ExceptionHandleMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                ProblemDetails problem = new()
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Type = "Server Error!",
                    Title = e.Message,
                    Detail = "An internal server error has occured!"
                };

                string json = JsonSerializer.Serialize(problem);

                await context.Response.WriteAsync(json);

                context.Response.ContentType = "application/json";
            }
        }
    }
}
