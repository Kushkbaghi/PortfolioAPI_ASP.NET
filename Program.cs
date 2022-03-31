using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Include AddDbContext
builder.Services.AddDbContext<PortfolioContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddCors();         //Include Cors to allow access to fetch
var app = builder.Build();

app.UseCors(options =>              // Access options
{
    options.
    AllowAnyOrigin().
    AllowAnyMethod().
    AllowAnyHeader();
});

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();

app.Run();