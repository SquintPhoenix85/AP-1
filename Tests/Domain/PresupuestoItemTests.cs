using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Tests.Domain
{
    [TestClass]
    public class PresupuestoItemTests
    {
        [TestMethod]
        public void PresupuestoItem_DCCU()
        {
            // Arrange
            var acero = new Material("Acero", UnidadMedida.kg, 1, 3000);
            var apu = new APU("APU-002", "Estructura", UnidadMedida.kg);
            apu.AgregarMaterial(acero, 10);

            var item = new PresupuestoItem(apu, 5);

            // Cambio de precio posterior
            var aceroCaro = new Material("Acero", UnidadMedida.kg, 1, 6000);
            var apuNuevo = new APU("APU-002", "Estructura", UnidadMedida.kg);
            apuNuevo.AgregarMaterial(aceroCaro, 10);

            // Act
            var subtotal = item.CalcularSubtotal();

            // Assert
            Assert.AreEqual(5 * (10 * 3000), subtotal);
        }
    }
}
