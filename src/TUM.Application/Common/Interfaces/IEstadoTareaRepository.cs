using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Domain.Entities;

namespace TUM.Application.Common.Interfaces
{
    public interface IEstadoTareaRepository
    {
        Task AddAsync(EstadoTarea estadoTarea);
        Task <EstadoTarea> GetByIdAsync(int id);

    }
}
