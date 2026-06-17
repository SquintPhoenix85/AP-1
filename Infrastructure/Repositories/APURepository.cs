using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Presupuestos.Domain.Entities;
using Presupuestos.Domain.Interfaces;
using Presupuestos.Infrastructure.Data;

namespace Presupuestos.Infrastructure.Repositories
{
    public class APURepository : IAPURepository
    {
        private readonly AppDbContext _context;
        public APURepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(APU entity)
        {
            _context.APUs.Add(entity);
            _context.SaveChanges();
        }
        public void Update(APU entity)
        {
            _context.APUs.Update(entity);
            _context.SaveChanges();
        }
        public void Remove(APU entity)
        {
            _context.APUs.Remove(entity);
            _context.SaveChanges();
        }
        public APU? GetById(Guid id)
        {
            return _context.APUs
                .Include(a => a.Materiales)
                .Include(a => a.Equipos)
                .Include(a => a.ManoObra)
                .FirstOrDefault(a => a.Id == id);
        }
        public IEnumerable<APU> GetAll()
        {
            return _context.APUs
                .Include(a => a.Materiales)
                .Include(a => a.Equipos)
                .Include(a => a.ManoObra)
                .AsNoTracking().ToList();
        }
    }
}
