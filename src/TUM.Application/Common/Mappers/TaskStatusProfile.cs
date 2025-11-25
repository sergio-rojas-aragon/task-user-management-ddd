
using AutoMapper;
using TUM.Application.DTOs;
using TUM.Domain.Entities;


namespace TUM.Application.Common.Mappers
{
    public class TaskStatusProfile : Profile
    {
        public TaskStatusProfile() {

            CreateMap<EstadosTarea, ListTaskStatusDTO>();
            CreateMap<ListTaskStatusDTO, EstadosTarea>();
        }
    }
}
