using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleware.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ChaitaliMiddleware
    {
        private readonly RequestDelegate _next;

        public ChaitaliMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine(" ChaitaliMiddleware : Before Request");

            await _next(context);

            Console.WriteLine("ChaitaliMiddleware :After Response");

        }
    }

    }
