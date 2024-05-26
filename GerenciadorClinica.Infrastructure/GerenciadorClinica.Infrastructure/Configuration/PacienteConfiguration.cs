using GerenciadorClinica.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorClinica.Infrastructure.Configuration;

public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Sobrenome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.DataNascimento)
            .IsRequired();

        builder.Property(p => p.Telefone)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.CPF)
            .IsRequired()
            .HasMaxLength(11);

        builder.Property(p => p.TipoSanguineo)
            .HasMaxLength(3);

        builder.Property(p => p.Altura)
            .IsRequired();

        builder.Property(p => p.Peso)
            .IsRequired();

        builder.Property(p => p.Endereco)
            .HasMaxLength(200);
    }
}
