using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using A3MovieApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<A3MovieApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("A3MovieApiDbContext") ?? throw new InvalidOperationException("Connection string 'A3MovieApiDbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
