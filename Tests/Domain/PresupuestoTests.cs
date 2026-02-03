using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;

namespace Presupuestos.Tests.Domain
{
    [TestClass]
    public class PresupuestoTests
    {
        [TestMethod]
        public void Presupuesto_DCTC()
        {
            // Arrange
            var arena = new Material("Arena", UnidadMedida.kg, 1, 400);
            var apu = new APU("APU-003", "Mortero", UnidadMedida.m3);
            apu.AgregarMaterial(arena, 100);

            var presupuesto = new Presupuesto("Obra Test");
            presupuesto.AgregarItem(apu, 3);

            //Act
            var total = presupuesto.CalcularTotal();

            //Assert
            Assert.AreEqual(3 * (100 * 400), total);
        }
    }
}
