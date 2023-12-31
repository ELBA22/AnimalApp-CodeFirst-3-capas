using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("Ciudad");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.NombreCiudad)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Departamentos)
            .WithMany(p => p.Ciudades)
            .HasForeignKey(p => p.IdDep);

            builder.HasOne(p => p.ClientesDirecciones)
            .WithOne(p => p.Ciudades)
            .HasForeignKey<Ciudad>(p => p.IdClienteDir);
        }
        
    }
}