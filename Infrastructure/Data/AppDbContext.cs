using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Presupuestos.Domain.Entities;


namespace Presupuestos.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<Material> Materiales => Set<Material>();
    public DbSet<Equipo> Equipos => Set<Equipo>();
    public DbSet<ManoObra> ManoObras => Set<ManoObra>();
    public DbSet<APU> APUs => Set<APU>();
    public DbSet<Presupuesto> Presupuestos => Set<Presupuesto>();
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}   
