using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presupuestos.Application.Services;
using Presupuestos.Domain.Enums;
using Presupuestos.Tests.Fakes;

namespace Presupuestos.Tests.Application;

[TestClass]
public class MaterialServiceTests
{
    [TestMethod]
    public void CrearMaterial_DeberiaGuardarlo()
    {
        var repo = new FakeMaterialRepository();
        var service = new MaterialService(repo);

        var material = service.Crear("Cemento", UnidadMedida.kg, 1, 800);

        Assert.AreEqual(1, repo.GetAll().Count());
        Assert.AreEqual("Cemento", material.Nombre);
    }
}
