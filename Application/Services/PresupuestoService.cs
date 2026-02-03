using System;
using System.Collections.Generic;
using System.Text;
using Presupuestos.Application.Interfaces;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;

namespace Presupuestos.Application.Services;

public class PresupuestoService : IPresupuestoService
{
    private readonly IPresupuestoRepository _repository;

    public PresupuestoService(IPresupuestoRepository repository)
    {
        _repository = repository;
    }

    public Presupuesto Crear(string nombre)
    {
        var presupuesto = new Presupuesto(nombre);
        _repository.Add(presupuesto);
        return presupuesto;
    }

    public void AgregarItem(Presupuesto presupuesto, APU apu, decimal cantidad)
    {
        presupuesto.AgregarItem(apu, cantidad);
        _repository.Update(presupuesto);
    }

    public decimal CalcularTotal(Presupuesto presupuesto)
        => presupuesto.CalcularTotal();
}
