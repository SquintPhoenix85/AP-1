using Presupuestos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Domain.Entities
{
    public class Presupuesto
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public DateTime Fecha { get; private set; }

        private readonly List<PresupuestoItem> _items = new();
        public IReadOnlyCollection<PresupuestoItem> Items => _items;

        protected Presupuesto() { }

        public Presupuesto(string nombre)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Fecha = DateTime.Now;
        }

        public void AgregarItem(APU apu, decimal cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.", nameof(cantidad));
            var item = new PresupuestoItem(apu, cantidad);
            _items.Add(item);
        }

        public decimal CalcularTotal() 
        {
            return _items.Sum(item => item.CalcularSubtotal());
        }
    }
}
