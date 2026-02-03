using System;
using System.Collections.Generic;
using System.Text;

namespace Presupuestos.Domain.Entities
{
    public class APUManoObra
    {
        public Guid Id { get; private set; }
        public ManoObra ManoObra { get; private set; }
        public decimal HorasTrabajo { get; private set; }

        protected APUManoObra() { }

        public APUManoObra(ManoObra manoObra, decimal horasTrabajo)
        {
            Id = Guid.NewGuid();
            ManoObra = manoObra;
            HorasTrabajo = horasTrabajo;
        }

        public decimal CalcularCosto()
        {
            return HorasTrabajo * ManoObra.ValorHora;
        }
    }
}
