using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;

namespace Presupuestos.Tests.Fakes;

public class FakeMaterialRepository : IMaterialRepository
{
    private readonly List<Material> _data = new();

    public void Add(Material entity) => _data.Add(entity);

    public void Update(Material entity)
    {
        // En memoria no necesitamos nada especial
    }

    public void Remove(Material entity) => _data.Remove(entity);

    public Material? GetById(Guid id)
        => _data.FirstOrDefault(m => m.Id == id);

    public IEnumerable<Material> GetAll() => _data;
}
