using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presupuestos.Domain.Entities;

namespace Presupuestos.Infrastructure.Data.Configurations;

public class PresupuestoConfig : IEntityTypeConfiguration<Presupuesto>
{
    public void Configure(EntityTypeBuilder<Presupuesto> builder)
    {
        // Configuración de la tabla
        builder.ToTable("Presupuestos");

        // Clave primaria
        builder.HasKey(m => m.Id);

        // Propiedades básicas
        builder.Property(m => m.Nombre)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(m => m.Fecha)
               .IsRequired();

        // Configuración del Backing Field para la colección _items
        builder.Metadata.FindNavigation(nameof(Presupuesto.Items))
               ?.SetPropertyAccessMode(PropertyAccessMode.Field);

        // Relación Uno a Muchos con PresupuestoItem
        builder.HasMany(p => p.Items)
               .WithOne() // Si PresupuestoItem no tiene propiedad de navegación de regreso
               .HasForeignKey("PresupuestoId") // Sombra o clave foránea explícita
               .OnDelete(DeleteBehavior.Cascade);
    }
}