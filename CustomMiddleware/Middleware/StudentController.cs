using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleware.Middleware
{
    public class StudentController : Controller
    {
        private readonly RequestDelegate _next;
        public StudentController(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Before Request");

            await _next(context);

            Console.WriteLine("After Response");
        }

    }
}
