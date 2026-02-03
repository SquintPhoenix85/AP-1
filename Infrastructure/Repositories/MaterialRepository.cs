using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;
using Presupuestos.Infrastructure.Data;

namespace Presupuestos.Infrastructure.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly AppDbContext _context;

        public MaterialRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Material entity)
        {
            _context.Materiales.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Material entity)
        {
            _context.Materiales.Update(entity);
            _context.SaveChanges();
        }

        public void Remove(Material entity)
        {
            _context.Materiales.Remove(entity);
            _context.SaveChanges();
        }

        public Material? GetById(Guid id)
        {
            return _context.Materiales.Find(id);
        }
        public IEnumerable<Material> GetAll()
        {
            return _context.Materiales.AsNoTracking().ToList();
        }
    }
}
