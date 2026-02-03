using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;
using Presupuestos.Infrastructure.Data;

namespace Presupuestos.Infrastructure.Repositories;

public class PresupuestoRepository : IPresupuestoRepository
{
    private readonly AppDbContext _context;

    public PresupuestoRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Presupuesto entity)
    {
        _context.Presupuestos.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Presupuesto entity)
    {
        _context.Presupuestos.Update(entity);
        _context.SaveChanges();
    }

    public void Remove(Presupuesto entity)
    {
        _context.Presupuestos.Remove(entity);
        _context.SaveChanges();
    }

    public Presupuesto? GetById(Guid id)
        => _context.Presupuestos
            .Include(p => p.Items)
            .FirstOrDefault(p => p.Id == id);

    public IEnumerable<Presupuesto> GetAll()
        => _context.Presupuestos
            .Include(p => p.Items)
            .AsNoTracking()
            .ToList();
}
