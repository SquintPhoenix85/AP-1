using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;

namespace Presupuestos.Tests.Fakes;

public class FakePresupuestoRepository : IRepository<Presupuesto>
{
    private readonly List<Presupuesto> _data = new();

    public void Add(Presupuesto entity) => _data.Add(entity);

    public void Update(Presupuesto entity)
    {
        // No-op
    }

    public void Remove(Presupuesto entity) => _data.Remove(entity);

    public Presupuesto? GetById(Guid id)
        => _data.FirstOrDefault(p => p.Id == id);

    public IEnumerable<Presupuesto> GetAll() => _data;
}
