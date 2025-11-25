
using TUM.Domain.Entities;

namespace TUM.Application.Common.Interfaces
{
    public interface IEstadoTareaRepository
    {
        Task AddAsync(EstadosTarea estadoTarea);
        Task <EstadosTarea> GetByIdAsync(int id);
        Task <List<EstadosTarea?>> GetAsync();

    }
}
