using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Application.Common.Interfaces;
using TUM.Infrastructure.Persistence;
using TUM.Infrastructure.Repositories;

namespace TUM.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(op =>
                op.UseSqlite(connectionString)    

            );

            // repositorios concretos
            services.AddScoped<IEstadoTareaRepository, EstadosTareaRepository>();

            return services;
            
       
        }
    }
}
