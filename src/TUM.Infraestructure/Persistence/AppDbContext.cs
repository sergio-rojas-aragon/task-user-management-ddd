using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Domain.Entities;

namespace TUM.Infrastructure.Persistence
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EstadoTarea> EstadosTarea => Set<EstadoTarea>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aca se crea el modelo

            //Relaciones EstadoTarea => Tarea (1:N)

            //modelBuilder.Entity<EstadoTarea>().HasMany(p=> p.Tareas).WithOne().HasForeignKey(i=> i.EstadoTareaId);

            ////clave primaria autoincremental
            //modelBuilder.Entity<EstadoTarea>().Property(p => p.EstadoTareaId).ValueGeneratedOnAdd();

        }
    }
}
