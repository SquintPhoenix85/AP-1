using System;
using System.Collections.Generic;
using System.Text;

using Presupuestos.Application.Interfaces;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;
using Presupuestos.Domain.Interfaces;

namespace Presupuestos.Application.Services;

public class MaterialService : IMaterialService
{
    private readonly IMaterialRepository _repository;

    public MaterialService(IMaterialRepository repository)
    {
        _repository = repository;
    }

    public Material Crear(
        string nombre,
        UnidadMedida unidad,
        decimal rendimiento,
        decimal precioUnitario)
    {
        var material = new Material(nombre, unidad, rendimiento, precioUnitario);
        _repository.Add(material);
        return material;
    }

    public IEnumerable<Material> ObtenerTodos()
        => _repository.GetAll();
}
