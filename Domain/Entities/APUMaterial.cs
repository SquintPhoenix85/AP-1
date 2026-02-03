using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Domain.Entities
{
    public class APUMaterial
    {
        public Guid Id { get; private set; }
        public Material Material { get; private set; }
        public decimal Cantidad { get; private set; }
        protected APUMaterial() { }
        public APUMaterial(Material material, decimal cantidad)
        {
            Id = Guid.NewGuid();
            Material = material;
            Cantidad = cantidad;
        }
        public decimal CalcularCosto()
        {
            return Cantidad * Material.PrecioUnitario;
        }
    }
}
