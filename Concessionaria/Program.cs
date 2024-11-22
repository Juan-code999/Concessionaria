using Dominio._01_Core.Interfaces.Repository;
using Dominio._01_Core.Interfaces.Service;
using Dominio._02_Repository;
using Dominio._03_Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ICarroRespository, CarroRepository>();
builder.Services.AddScoped<ICarroService, CarroService>();
builder.Services.AddScoped<ICaminhaoService, CaminhaoService>();
builder.Services.AddScoped<ICaminhaoRepository, CaminhaoRepository>();


InicializadorBD.Inicializar();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
