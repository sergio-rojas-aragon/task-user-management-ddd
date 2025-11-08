using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Application.Common.Interfaces;
using TUM.Domain.Entities;
using TUM.Infrastructure.Persistence;
using TUM.Infrastructure.Repositories;

namespace TUM.UnitTests.Infrastructure
{
    public class CrearEstadoTareaRepositoryTests : DatabaseTestBase
    {

        [Fact]
        public async Task AddAsync_DeberiaCrearEstadoTarea() {

            var et = new EstadoTarea
            {
                Nombre = "nuevo estado"
            };

            //act
            await _repository.AddAsync(et);
            var guardado = await _repository.GetByIdAsync(et.EstadoTareaId);

            Assert.NotNull(guardado);
            
        }

    }
}
