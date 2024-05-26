using GerenciadorClinica.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorClinica.Infrastructure.Configuration;

public class ServicoConfiguration : IEntityTypeConfiguration<Servico>
{
    public void Configure(EntityTypeBuilder<Servico> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.Descricao)
            .HasMaxLength(200);

        builder.Property(s => s.Valor)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(s => s.Duracao)
            .IsRequired();
    }
}
