using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class ApiKeyMiddleware
{
    private readonly RequestDelegate _next;
    private const string APIKEY = "123456";
    private const string HEADER_NAME = "Authorization";

    public ApiKeyMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        if (!context.Request.Headers.TryGetValue(HEADER_NAME, out var extractedApiKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("API Key não fornecida.");
            return;
        }

        if (extractedApiKey.ToString() != APIKEY)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("API Key inválida.");
            return;
        }

        await _next(context);
    }
}