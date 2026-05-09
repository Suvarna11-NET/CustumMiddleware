using CustomMiddleware.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<StudentController>();
app.UseMiddleware<DepartmentMiddleware>() ;
app.UseMiddleware<ValueMiddleware>() ;
app.UseMiddleware<ChaitaliMiddleware>() ;
app.MapControllers();
app.UseAuthorization();

app.MapControllers();

app.Run();
