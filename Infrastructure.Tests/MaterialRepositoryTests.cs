using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;
using Presupuestos.Infrastructure.Repositories;

namespace Presupuestos.Infrastructure.Tests.Repositories;

[TestClass]
public class MaterialRepositoryTests : SqliteInMemoryTestBase
{
    [TestMethod]
    public void Add_And_GetById_ShouldWork()
    {
        var repo = new MaterialRepository(Context);

        var material = new Material(
            "Cemento",
            UnidadMedida.kg,
            1,
            800);

        repo.Add(material);

        var result = repo.GetById(material.Id);

        Assert.IsNotNull(result);
        Assert.AreEqual("Cemento", result!.Nombre);
    }

    [TestMethod]
    public void GetAll_ShouldReturnData()
    {
        var repo = new MaterialRepository(Context);

        repo.Add(new Material("Arena", UnidadMedida.m3, 1, 50000));
        repo.Add(new Material("Grava", UnidadMedida.m3, 1, 60000));

        var all = repo.GetAll();

        Assert.AreEqual(2, all.Count());
    }
}
