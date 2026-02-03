using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Domain.Entities
{
    public class ManoObra
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public decimal Rendimiento { get; private set; }
        public decimal ValorHora { get; private set; }
        protected ManoObra() { }
        public ManoObra(string nombre, decimal rendimiento, decimal valorHora)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Rendimiento = rendimiento;
            ValorHora = valorHora;
        }
    }
}
