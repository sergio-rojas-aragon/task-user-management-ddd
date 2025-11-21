using TUM.Application.Common.Interfaces;
using TUM.Application.UseCases;
using TUM.Infrastructure;
using TUM.Infrastructure.Repositories;
using FluentValidation;
using TUM.Application.Validators;

var builder = WebApplication.CreateBuilder(args);


// Infraestructura (EF Core + repositorios)
builder.Services.AddInfrastructure(
    builder.Configuration.GetConnectionString("DefaultConnection")!
);

// inyeccion de dependencias
builder.Services.AddScoped<IEstadoTareaRepository, EstadosTareaRepository>();
builder.Services.AddScoped<CrearEstadoTareaHandler>();

builder.Services.AddControllers();
builder.Services.AddValidatorsFromAssemblyContaining<CrearEstadoTareaDtoValidator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//------------------------------------- APP -------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

