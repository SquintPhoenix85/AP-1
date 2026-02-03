using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Domain.Entities
{
    public class Equipo
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public decimal Rendimiento { get; private set; }
        public decimal ValorHora { get; private set; }

        protected Equipo() { }

        public Equipo(string nombre, decimal rendimiento, decimal valorHora)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Rendimiento = rendimiento;
            ValorHora = valorHora;
        }

    }
}
