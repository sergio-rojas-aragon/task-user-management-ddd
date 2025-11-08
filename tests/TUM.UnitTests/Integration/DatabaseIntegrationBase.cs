using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUM.Infrastructure.Persistence;

namespace TUM.UnitTests.Integration
{
    public abstract class DatabaseIntegrationBase : IDisposable
    {
        protected readonly SqliteConnection _connection;
        protected readonly AppDbContext _context;

        public DatabaseIntegrationBase()
        {
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(_connection)
                .Options;

            _context = new AppDbContext(options);
            _context.Database.EnsureCreated();

        }

        public void Dispose()
        {
            _context.Dispose();
            _connection.Close();
        }
    }
}
