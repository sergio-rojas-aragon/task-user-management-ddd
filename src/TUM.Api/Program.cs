using FluentValidation;
using Microsoft.AspNetCore.Identity;
using TUM.Application.Common.Interfaces;
using TUM.Application.UseCases.EstadoTareaCases;
using TUM.Application.Validators;
using TUM.Application.Common.Mappers;
using TUM.Infrastructure;
using TUM.Infrastructure.Persistence;
using TUM.Infrastructure.Repositories;
using AutoMapper;
using TUM.Application.UseCases.ClientCases;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(
    cfg => { },
    typeof(TaskStatusProfile)   // marcador de assembly
);


// el setter de esto esta en la clase de infraestructura dependencyinjection
builder.Services.AddInfrastructure(
    builder.Configuration.GetConnectionString("DefaultConnection")!
);


// inyeccion de dependencias
builder.Services.AddScoped<IEstadoTareaRepository, EstadosTareaRepository>();
builder.Services.AddScoped<CrearEstadoTareaHandler>();
builder.Services.AddScoped<ListTaskStatusesHandler>();

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

