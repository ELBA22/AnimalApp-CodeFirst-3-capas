using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructure.Data.configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("Departamento");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.NombreDep)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Paises)
        .WithMany(p => p.Departamentos)
        .HasForeignKey(p => p.IdPais);

    }
}
