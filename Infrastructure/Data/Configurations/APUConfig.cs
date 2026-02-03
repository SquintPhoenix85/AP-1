using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presupuestos.Domain.Entities;

namespace Presupuestos.Infrastructure.Data.Configurations;

public class APUConfig : IEntityTypeConfiguration<APU>
{
    public void Configure(EntityTypeBuilder<APU> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Codigo)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(a => a.Descripcion)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(a => a.Unidad)
               .IsRequired();

        builder.HasMany(a => a.Materiales)
               .WithOne()
               .HasForeignKey("APUId")
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.Equipos)
               .WithOne()
               .HasForeignKey("APUId")
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.ManoObra)
               .WithOne()
               .HasForeignKey("APUId")
               .OnDelete(DeleteBehavior.Cascade);
    }
}
