using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Application.Common.Interfaces;
using TUM.Domain.Entities;
using TUM.Infrastructure.Persistence;

namespace TUM.Infrastructure.Repositories
{
    internal class EstadosTareaRepository : IEstadoTareaRepository
    {
        private AppDbContext _context;

        public EstadosTareaRepository(AppDbContext context)
        {
            _context = context;

        }
        public async Task AddAsync(EstadoTarea estadoTarea)
        {
            await _context.EstadosTarea.AddAsync(estadoTarea);
            await _context.SaveChangesAsync();
        }

        public async Task<EstadoTarea> GetByIdAsync(int id)
        {
            return await _context.EstadosTarea.FirstOrDefaultAsync(p => p.EstadoTareaId == id);

        }
    }
}
