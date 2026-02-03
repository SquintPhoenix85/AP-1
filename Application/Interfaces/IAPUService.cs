using System;
using System.Collections.Generic;
using System.Text;

using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;

namespace Presupuestos.Application.Interfaces;
public interface IAPUService
{
    APU Crear(string codigo, string descripcion, UnidadMedida unidad);
    void AgregarMaterial(APU apu, Material material, decimal cantidad);
    decimal CalcularCosto(APU apu);
}

