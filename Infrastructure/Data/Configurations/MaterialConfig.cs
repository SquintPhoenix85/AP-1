using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presupuestos.Domain.Entities;

namespace Presupuestos.Infrastructure.Data.Configurations;

public class MaterialConfig : IEntityTypeConfiguration<Material>
{
    public void Configure(EntityTypeBuilder<Material> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Nombre)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(m => m.PrecioUnitario)
               .HasPrecision(18, 2);
    }
}
