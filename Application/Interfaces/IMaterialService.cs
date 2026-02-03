using System;
using System.Collections.Generic;
using System.Text;

using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Enums;

namespace Presupuestos.Application.Interfaces;
public interface IMaterialService
{
    Material Crear(
        string nombre, UnidadMedida unidad, decimal rendimiento, decimal precioUnitario);

    IEnumerable<Material> ObtenerTodos();

}

