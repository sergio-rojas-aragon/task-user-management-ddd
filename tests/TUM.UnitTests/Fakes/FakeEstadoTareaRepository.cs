using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TUM.Domain.Entities;
using TUM.Application.Common.Interfaces;

namespace TUM.UnitTests.Fakes
{
    internal class FakeEstadoTareaRepository : IEstadoTareaRepository
    {
        private readonly List<EstadoTarea> _estadoTareas = new();
        public Task AddAsync(EstadoTarea estadoTarea)
        {
            estadoTarea.EstadoTareaId = _estadoTareas.Count + 1;
            _estadoTareas.Add(estadoTarea);
            return Task.CompletedTask;
        }

        public Task<EstadoTarea> GetByIdAsync(int id)
        {
            return Task.FromResult(_estadoTareas.FirstOrDefault(p => p.EstadoTareaId == id));
        }

        public List<EstadoTarea> GetAll()
        {
            return _estadoTareas;

        }
    }
}
