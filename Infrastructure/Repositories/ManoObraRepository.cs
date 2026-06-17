using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;
using Presupuestos.Infrastructure.Data;

namespace Presupuestos.Infrastructure.Repositories
{
    public class ManoObraRepository : IManoObraRepository
    {
        private readonly AppDbContext _context;

        public ManoObraRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(ManoObra entity)
        {
            _context.ManoObras.Add(entity);
            _context.SaveChanges();
        }

        public void Update(ManoObra entity)
        {
            _context.ManoObras.Update(entity);
            _context.SaveChanges();
        }

        public void Remove(ManoObra entity)
        {
            _context.ManoObras.Remove(entity);
            _context.SaveChanges();
        }

        public ManoObra? GetById(Guid id)
            => _context.ManoObras.Find(id);

        public IEnumerable<ManoObra> GetAll()
            => _context.ManoObras.AsNoTracking().ToList();
    }
}
