using System.Net;
using System.Text.Json;

namespace MovieApi.Middleware;

/// <summary>
/// Глобальный middleware для обработки исключений
/// </summary>
public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var response = new
            {
                status = 500,
                error = "Internal Server Error"
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
