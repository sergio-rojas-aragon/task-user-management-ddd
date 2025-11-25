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
        private readonly List<EstadosTarea> _estadoTareas = new();
        public Task AddAsync(EstadosTarea estadoTarea)
        {
            estadoTarea.EstadosTareaId = _estadoTareas.Count + 1;
            _estadoTareas.Add(estadoTarea);
            return Task.CompletedTask;
        }

        public Task<EstadosTarea> GetByIdAsync(int id)
        {
            return Task.FromResult(_estadoTareas.FirstOrDefault(p => p.EstadosTareaId == id));
        }

        public List<EstadosTarea> GetAll()
        {
            return _estadoTareas;

        }

        public Task<List<EstadosTarea?>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
