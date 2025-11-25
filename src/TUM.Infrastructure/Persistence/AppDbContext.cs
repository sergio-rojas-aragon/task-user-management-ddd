using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Domain.Entities;


namespace TUM.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EstadosTarea> EstadosTarea => Set<EstadosTarea>();
        public DbSet<Client> Clientes => Set<Client>(); 
        public DbSet<DetallePedido> DetallePedidos => Set<DetallePedido>();
        public DbSet<Pedido> Pedidos => Set<Pedido>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Tarea> Tareas => Set<Tarea>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            // evito el intento de duplicacion de aspnetusers
            
            modelBuilder.Entity<IdentityUser>()
    .           ToTable("AspNetUsers", t => t.ExcludeFromMigrations());

            base.OnModelCreating(modelBuilder);


            // creo la relacion entre pedido y aspnetusers

            modelBuilder.Entity<Pedido>()
                .HasOne<IdentityUser>() // sin navegación en dominio
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
