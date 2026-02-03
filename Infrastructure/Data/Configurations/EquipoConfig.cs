using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presupuestos.Domain.Entities;

namespace Presupuestos.Infrastructure.Data.Configurations;

public class EquipoConfig : IEntityTypeConfiguration<Equipo>
{
    public void Configure(EntityTypeBuilder<Equipo> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Nombre)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(m => m.Rendimiento)
               .HasPrecision(18, 2);

        builder.Property(m => m.ValorHora)
               .HasPrecision(18, 2);
    }
}
