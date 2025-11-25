using TUM.Application.Common.Interfaces;
using TUM.Application.DTOs;
using TUM.Domain.Entities;

namespace TUM.Application.UseCases.ClientCases
{
    public class NewClientHandler
    {
        //private IEstadoTareaRepository _estadoTareaRepo;

        //public NewClientHandler(IEstadoTareaRepository EstadoRepo)
        //{
        //    _estadoTareaRepo = EstadoRepo;
        //}

        //public async Task<int> Handle(CrearEstadoTareaDTO dto, string userId)
        //{
        //    var estadoTarea = new EstadosTarea
        //    {
        //        Nombre = dto.Nombre,
        //        CreatedAt = DateTime.Now,
        //        CreatedBy = userId
        //    };

        //   await _estadoTareaRepo.AddAsync(estadoTarea);

        //    return estadoTarea.EstadosTareaId;
        //}
    }
}
