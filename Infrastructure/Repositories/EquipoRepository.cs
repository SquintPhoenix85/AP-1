using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;
using Presupuestos.Infrastructure.Data;

namespace Presupuestos.Infrastructure.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        private readonly AppDbContext _context;

        public EquipoRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Equipo entity)
        {
            _context.Equipos.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Equipo entity)
        {
            _context.Equipos.Update(entity);
            _context.SaveChanges();
        }

        public void Remove(Equipo entity)
        {
            _context.Equipos.Remove(entity);
            _context.SaveChanges();
        }

        public Equipo? GetById(Guid id)
            => _context.Equipos.Find(id);

        public IEnumerable<Equipo> GetAll()
            => _context.Equipos.AsNoTracking().ToList();
    }
}
