using Microsoft.EntityFrameworkCore;
using RiskSolution.Models.Context;
using Microsoft.Extensions.Configuration;
using RiskSolution.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RiskContext>(
    options => options.UseSqlServer("Data Source=db;Initial Catalog=risk_database;Persist Security Info=True;TrustServerCertificate=true;Encrypt=true;User ID=sa;Password=PinkLemonade_1577"));

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddTransient<SearchService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
