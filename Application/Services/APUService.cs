using System;
using System.Collections.Generic;
using System.Text;

using Presupuestos.Application.Interfaces;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;
using Presupuestos.Domain.Enums;

namespace Presupuestos.Application.Services;

public class APUService : IAPUService
{
    private readonly IAPURepository _apuRepository;

    public APUService(IAPURepository apuRepository)
    {
        _apuRepository = apuRepository;
    }

    
    public APU Crear(string codigo, string descripcion, UnidadMedida unidad)
    {
        var apu = new APU(codigo, descripcion, unidad);
        _apuRepository.Add(apu);
        return apu;
    }

    public void AgregarMaterial(APU apu, Material material, decimal cantidad)
    {
        apu.AgregarMaterial(material, cantidad);
        _apuRepository.Update(apu);
    }

    public decimal CalcularCosto(APU apu)
        => apu.CalcularCostoUnitario();
}
