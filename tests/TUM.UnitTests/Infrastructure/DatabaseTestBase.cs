using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Domain.Entities;
using TUM.Infrastructure.Persistence;
using TUM.Infrastructure.Repositories;

namespace TUM.UnitTests.Infrastructure
{
    public abstract class DatabaseTestBase : IDisposable
    {
        protected readonly SqliteConnection _connection;
        protected readonly AppDbContext _context;
        protected readonly EstadosTareaRepository _repository;

        public DatabaseTestBase()
        {

            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(_connection)
                .Options;

            _context = new AppDbContext(options);
            _context.Database.EnsureCreated(); // crea tablas

            _repository = new EstadosTareaRepository(_context);
        }



        public void Dispose()
        {
            _context.Dispose();
            _connection.Close();
        }
    }
}
