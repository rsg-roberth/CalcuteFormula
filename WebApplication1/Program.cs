using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Interfaces;
using WebApplication1.Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GuaranteedSavingsDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GuaranteedSavings")));

builder.Services.AddScoped<ICalculateFormulaRepository, CalculateFormulaRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
