using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Domain.Entities
{
    public class APUEquipo
    {
        public Guid Id { get; private set; }
        public Equipo Equipo { get; private set; }
        public decimal HorasUso { get; private set; }
        protected APUEquipo() { }
        public APUEquipo(Equipo equipo, decimal horasUso)
        {
            Id = Guid.NewGuid();
            Equipo = equipo;
            HorasUso = horasUso;
        }
        public decimal CalcularCosto()
        {
            return HorasUso * Equipo.ValorHora;
        }
    }
}
