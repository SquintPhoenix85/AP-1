using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presupuestos.Application.Services;
using Presupuestos.Domain.Enums;
using Presupuestos.Domain.Entities;
using Presupuestos.Tests.Fakes;

namespace Presupuestos.Tests.Application;

[TestClass]
public class APUServiceTests
{
    [TestMethod]
    public void CalcularCosto_DeberiaSumarMateriales()
    {
        var repo = new FakeAPURepository();
        var service = new APUService(repo);

        var apu = service.Crear("APU-01", "Concreto", UnidadMedida.m3);
        var cemento = new Material("Cemento", UnidadMedida.kg, 1, 800);

        service.AgregarMaterial(apu, cemento, 100);

        var costo = service.CalcularCosto(apu);

        Assert.AreEqual(80000, costo);
    }
}
