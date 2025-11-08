using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TUM.Application.Common.Interfaces;
using TUM.Application.DTOs;
using TUM.Domain.Entities;

namespace TUM.Application.UseCases
{
    public class CrearEstadoTareaHandler
    {
        private IEstadoTareaRepository _estadoTareaRepo;

        public CrearEstadoTareaHandler(IEstadoTareaRepository EstadoRepo)
        {
            _estadoTareaRepo = EstadoRepo;
        }

        public async Task<int> Handle(CrearEstadoTareaDTO dto)
        {
            var estadoTarea = new EstadoTarea
            {
                Nombre = dto.Nombre
            };

           await _estadoTareaRepo.AddAsync(estadoTarea);

            return estadoTarea.EstadoTareaId;
        }
    }
}
