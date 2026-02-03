using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;
using Presupuestos.Infrastructure.Repositories;

namespace Presupuestos.Infrastructure.Tests.Repositories;

[TestClass]
public class PresupuestoRepositoryTests : SqliteInMemoryTestBase
{
    [TestMethod]
    public void Presupuesto_With_Items_ShouldPersist()
    {
        var repo = new PresupuestoRepository(Context);

        var apu = new APU("APU-01", "Concreto", UnidadMedida.m3);
        var material = new Material("Cemento", UnidadMedida.kg, 1, 1000);
        apu.AgregarMaterial(material, 10);

        var presupuesto = new Presupuesto("Casa");
        presupuesto.AgregarItem(apu, 2);

        repo.Add(presupuesto);

        var loaded = repo.GetById(presupuesto.Id);

        Assert.IsNotNull(loaded);
        Assert.AreEqual(1, loaded!.Items.Count);
    }
}
