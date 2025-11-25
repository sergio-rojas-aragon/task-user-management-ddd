using FluentValidation;
using Microsoft.AspNetCore.Identity;
using TUM.Application.Common.Interfaces;
using TUM.Application.UseCases;
using TUM.Application.Validators;
using TUM.Infrastructure;
using TUM.Infrastructure.Persistence;
using TUM.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);


// el setter de esto esta en la clase de infraestructura dependencyinjection
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

// Identity
builder.Services.AddAuthorization();

//------------------------------------- APP -------------------

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Endpoints automáticos de Identity
app.MapIdentityApi<IdentityUser>();

app.MapControllers();
app.Run();

