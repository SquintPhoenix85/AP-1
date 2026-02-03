using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;
using Presupuestos.Infrastructure.Repositories;

namespace Presupuestos.Infrastructure.Tests.Repositories;

[TestClass]
public class APURepositoryTests : SqliteInMemoryTestBase
{
    [TestMethod]
    public void Add_APU_With_Material_ShouldPersist()
    {
        var apuRepo = new APURepository(Context);
        var materialRepo = new MaterialRepository(Context);

        var cemento = new Material("Cemento", UnidadMedida.kg, 1, 800);
        materialRepo.Add(cemento);

        var apu = new APU("APU-01", "Concreto", UnidadMedida.m3);
        apu.AgregarMaterial(cemento, 100);

        apuRepo.Add(apu);

        var result = apuRepo.GetById(apu.Id);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result!.Materiales.Count);
    }
}
