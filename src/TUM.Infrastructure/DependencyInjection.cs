using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

            // login
            services.AddDbContext<AuthDbContext>(op =>
                op.UseSqlite(connectionString)
            );


            services.AddIdentityApiEndpoints<IdentityUser>()
                .AddEntityFrameworkStores<AuthDbContext>();

            // Identity
            services.AddIdentityCore<IdentityUser>()
                .AddEntityFrameworkStores<AuthDbContext>()
                .AddApiEndpoints(); // imp

            // repositorios concretos
            services.AddScoped<IEstadoTareaRepository, EstadosTareaRepository>();

            return services;
            
       
        }
    }
}
