
using AutoMapper;
using TUM.Application.Common.Interfaces;
using TUM.Application.DTOs;

namespace TUM.Application.UseCases.EstadoTareaCases
{
    public class ListTaskStatusesHandler
        (IEstadoTareaRepository estadoRepo,
        IMapper mapper
        )
    {

        public async Task<List<ListTaskStatusDTO?>> Handle() {


            var results = await estadoRepo.GetAsync();
            var map = mapper.Map<List<ListTaskStatusDTO>>( results );
            return map;
            
        }

    }
}
