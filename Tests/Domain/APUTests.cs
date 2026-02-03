using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Tests.Domain
{
    [TestClass]
    public class APUTests
    {
        [TestMethod]
        public void CalcularCostoUnitario_DSMEMO()
        {
            // Arrange
            var cemento = new Material("Cemento", UnidadMedida.kg, 1, 800);
            var grava = new Material("Grava", UnidadMedida.kg, 1, 500);
            var mezcladora = new Equipo("Mezcladora", 1, 20000);
            var oficial = new ManoObra("Oficial", 1, 15000);

            var apu = new APU("APU-001", "Concreto simple", UnidadMedida.m3);
            apu.AgregarMaterial(cemento, 300);
            apu.AgregarMaterial(grava, 200);
            apu.AgregarEquipo(mezcladora, 0.5m);
            apu.AgregarManoObra(oficial, 2);

            // Act
            var costo = apu.CalcularCostoUnitario();

            // Assert
            Assert.AreEqual(
                (300 * 800) +
                (200 * 500) +
                (0.5m * 20000) +
                (2 * 15000),
                costo);
        }
    }
}
