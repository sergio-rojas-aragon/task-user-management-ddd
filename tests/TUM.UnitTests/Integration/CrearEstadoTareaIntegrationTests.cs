using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Domain.Entities;
using TUM.Infrastructure.Repositories;
using TUM.UnitTests.Infrastructure;
using TUM.Application.DTOs;
using Microsoft.EntityFrameworkCore;
using TUM.Application.UseCases.EstadoTareaCases;

namespace TUM.UnitTests.Integration
{
    public class CrearEstadoTareaIntegrationTests : DatabaseIntegrationBase
    {
        private EstadosTareaRepository _estadoTareaRepo;
        private CrearEstadoTareaHandler _handler;

        public CrearEstadoTareaIntegrationTests()
        {
            _estadoTareaRepo = new EstadosTareaRepository(_context);
            _handler = new CrearEstadoTareaHandler(_estadoTareaRepo);
        }

        [Fact]
        public async Task CrearEstadoTarea_DebeGuardarEnDB()
        {
            // recibe DTO
            var dto = new CrearEstadoTareaDTO()
            {
                Nombre = "nuevo estado"
            };

            //Act
            string UserId = Guid.NewGuid().ToString();

            var resultId = await _handler.Handle(dto, UserId);

            //Assert

            var estadoTarea = await _context.EstadosTarea.FirstOrDefaultAsync(et => et.EstadosTareaId == resultId);

            Assert.NotNull(estadoTarea);
            Assert.Equal(dto.Nombre,estadoTarea.Nombre);


        }
    }
}
