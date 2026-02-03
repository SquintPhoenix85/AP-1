using System;
using System.Collections.Generic;
using System.Text;

using Presupuestos.Domain.Entities;

namespace Presupuestos.Application.Interfaces
{
    public interface IPresupuestoService
    {
        Presupuesto Crear(string nombre);
        void AgregarItem(Presupuesto presupuesto, APU apu, decimal cantidad);
        decimal CalcularTotal(Presupuesto presupuesto);
    }
}
