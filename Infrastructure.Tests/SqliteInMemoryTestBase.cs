using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Presupuestos.Infrastructure.Data;

namespace Presupuestos.Infrastructure.Tests;

public abstract class SqliteInMemoryTestBase : IDisposable
{
    protected readonly AppDbContext Context;
    private readonly SqliteConnection _connection;

    protected SqliteInMemoryTestBase()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite(_connection)
            .Options;

        Context = new AppDbContext(options);
        Context.Database.EnsureCreated();
    }

    public void Dispose()
    {
        Context.Dispose();
        _connection.Close();
    }
}
