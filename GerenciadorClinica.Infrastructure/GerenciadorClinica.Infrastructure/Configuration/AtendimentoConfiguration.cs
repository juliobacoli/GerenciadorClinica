using GerenciadorClinica.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorClinica.Infrastructure.Configuration;

public class AtendimentoConfiguration : IEntityTypeConfiguration<Atendimento>
{
    public void Configure(EntityTypeBuilder<Atendimento> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Convenio)
            .HasMaxLength(100);

        builder.Property(a => a.Inicio)
            .IsRequired();

        builder.Property(a => a.Fim)
            .IsRequired();

        builder.Property(a => a.TipoAtendimento)
            .IsRequired();

        #region Relacionamento entre as outras tabelas

        builder.HasOne(a => a.Paciente)
            .WithMany(p => p.Atendimentos)
            .HasForeignKey(a => a.PacienteId);

        builder.HasOne(a => a.Servico)
            .WithMany(s => s.Atendimentos)
            .HasForeignKey(a => a.ServicoId);

        builder.HasOne(a => a.Medico)
            .WithMany(m => m.Atendimentos)
            .HasForeignKey(a => a.MedicoId); 

        #endregion
    }
}
