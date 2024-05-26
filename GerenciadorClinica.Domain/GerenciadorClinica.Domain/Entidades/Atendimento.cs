using GerenciadorClinica.Domain.Enums;

namespace GerenciadorClinica.Domain.Entidades;

public class Atendimento
{
    public Guid Id { get; set; }
    public Guid PacienteId { get; set; }
    public Guid MedicoId { get; set; }
    public Guid ServicoId { get; set; }
    public string Convenio { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }
    public TipoAtendimento TipoAtendimento { get; set; }

    public Paciente Paciente { get; set; }
    public Servico Servico { get; set; }
    public Medico Medico { get; set; }
}
