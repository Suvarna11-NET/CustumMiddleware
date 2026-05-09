using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleware.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class DepartmentMiddleware
    {
        private readonly RequestDelegate _next;

        public DepartmentMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            Console.WriteLine("Department Middleware - BEFORE Request");

            await _next(httpContext);

            Console.WriteLine("Department Middleware - AFTER Response");
        }
    }

    
}
