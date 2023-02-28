using Microsoft.EntityFrameworkCore;
using Rest_API.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<RestApiDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("RestApiConnectionString") )
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();