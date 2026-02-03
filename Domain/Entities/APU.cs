using System;
using System.Collections.Generic;
using System.Text;
using Presupuestos.Domain.Enums;

namespace Presupuestos.Domain.Entities
{
    public class APU
    {
        public Guid Id { get; private set; }
        public string Codigo { get; private set; }
        public string Descripcion { get; private set; }
        public UnidadMedida Unidad { get; private set; }

        private readonly List<APUMaterial> _materiales = new();
        private readonly List<APUEquipo> _equipos = new();
        private readonly List <APUManoObra> _manoObra = new();

        public IReadOnlyCollection<APUMaterial> Materiales => _materiales;
        public IReadOnlyCollection<APUEquipo> Equipos => _equipos;
        public IReadOnlyCollection<APUManoObra> ManoObra => _manoObra;

        protected APU() { }

        public APU(string codigo, string descripcion, UnidadMedida unidad)
        {
            Id = Guid.NewGuid();
            Codigo = codigo;
            Descripcion = descripcion;
            Unidad = unidad;
        }
        public void AgregarMaterial(Material material, decimal cantidad)
        {
            _materiales.Add(new APUMaterial(material, cantidad));
        }

        public void AgregarEquipo(Equipo equipo, decimal cantidad)
        {
            _equipos.Add(new APUEquipo(equipo, cantidad));
        }
        public void AgregarManoObra(ManoObra manoObra, decimal cantidad)
        {
            _manoObra.Add(new APUManoObra(manoObra, cantidad));
        }
        public decimal CalcularCostoUnitario()
        {
            var materiales = _materiales.Sum(m => m.CalcularCosto());
            var equipos = _equipos.Sum(e => e.CalcularCosto());
            var manoObra = _manoObra.Sum(m => m.CalcularCosto());

            return materiales + equipos + manoObra;
        }

    }
}
