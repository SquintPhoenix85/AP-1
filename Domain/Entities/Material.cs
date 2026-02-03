using System;
using System.Collections.Generic;
using System.Text;
using Presupuestos.Domain.Enums;

namespace Presupuestos.Domain.Entities
{
    public class Material
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public UnidadMedida Unidad { get; private set; }
        public decimal RendimientoUnitario { get; private set; }
        public decimal PrecioUnitario { get; private set; }

        protected Material() { }

        public Material(string nombre, UnidadMedida unidad, decimal rendimientoUnitario, decimal precioUnitario)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Unidad = unidad;
            RendimientoUnitario = rendimientoUnitario;
            PrecioUnitario = precioUnitario;
        }
    }
}
