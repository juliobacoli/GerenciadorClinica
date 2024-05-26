using GerenciadorClinica.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorClinica.Infrastructure.Configuration;

public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.Property(m => m.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.Sobrenome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.DataNascimento)
            .IsRequired();

        builder.Property(m => m.Telefone)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(m => m.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.CPF)
            .IsRequired()
            .HasMaxLength(11);

        builder.Property(m => m.TipoSanguineo)
            .HasMaxLength(3);

        builder.Property(m => m.Endereco)
            .HasMaxLength(200);

        builder.Property(m => m.Especialidade)
            .HasMaxLength(100);

        builder.Property(m => m.RegistroCRM)
            .HasMaxLength(20);
    }
}
