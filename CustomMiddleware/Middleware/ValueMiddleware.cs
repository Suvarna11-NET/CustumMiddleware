using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleware.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ValueMiddleware
    {
        private readonly RequestDelegate _next;

        public ValueMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("ValueMiddleware :Before Request");

            await _next(context);

            Console.WriteLine("ValueMiddleware :After Response");

        }
        
    }

  
   
}
