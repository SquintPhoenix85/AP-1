using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Domain.Entities
{
    public class PresupuestoItem
    {
        public Guid Id { get; private set; }
        public Guid APUId { get; private set; }
        public string CodigoAPU { get; private set; }
        public string DescripcionAPU { get; private set; }
        
        public decimal Cantidad { get; private set; }
        public decimal CostoUnitarioSnapshot { get; private set; }

        protected PresupuestoItem() { }

        public PresupuestoItem(APU apu, decimal cantidad)
        {
            Id = Guid.NewGuid();
            APUId = apu.Id;
            CodigoAPU = apu.Codigo;
            DescripcionAPU = apu.Descripcion;

            Cantidad = cantidad;
            if (Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.", nameof(cantidad));
            CostoUnitarioSnapshot = apu.CalcularCostoUnitario();
        }

        public decimal CalcularSubtotal()
        {
            return Cantidad * CostoUnitarioSnapshot;
        }
    }
}
