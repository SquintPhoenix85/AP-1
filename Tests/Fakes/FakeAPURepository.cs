using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;

namespace Presupuestos.Tests.Fakes;

public class FakeAPURepository : IAPURepository
{
    private readonly List<APU> _data = new();

    public void Add(APU entity) => _data.Add(entity);

    public void Update(APU entity)
    {
        // No-op
    }

    public void Remove(APU entity) => _data.Remove(entity);

    public APU? GetById(Guid id)
        => _data.FirstOrDefault(a => a.Id == id);

    public IEnumerable<APU> GetAll() => _data;
}
