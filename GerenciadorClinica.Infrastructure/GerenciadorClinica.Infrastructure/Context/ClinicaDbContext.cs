using GerenciadorClinica.Domain.Entidades;
using GerenciadorClinica.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorClinica.Infrastructure.Context;

public class ClinicaDbContext : DbContext
{
    public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options) : base(options) { }

    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Servico> Servicos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AtendimentoConfiguration());
        modelBuilder.ApplyConfiguration(new MedicoConfiguration());
        modelBuilder.ApplyConfiguration(new PacienteConfiguration());
        modelBuilder.ApplyConfiguration(new ServicoConfiguration());

        base.OnModelCreating(modelBuilder);

    }
}
