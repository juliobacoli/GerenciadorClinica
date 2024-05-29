using GerenciadorClinica.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorClinica.Domain.Entidades;

public class Atendimento
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Paciente é obrigatório.")]
    public Guid PacienteId { get; set; }

    [Required(ErrorMessage = "Médico é obrigatório.")]
    public Guid MedicoId { get; set; }

    [Required(ErrorMessage = "Serviço é obrigatório.")]
    public Guid ServicoId { get; set; }

    [Required(ErrorMessage = "Convenio é obrigatório.")]
    [StringLength(100, ErrorMessage = "Convenio pode ter no máximo 100 caracteres.")]
    public string Convenio { get; set; }

    [Required(ErrorMessage = "Data de início é obrigatória.")]
    public DateTime Inicio { get; set; }

    [Required(ErrorMessage = "Data de fim é obrigatória.")]
    [DataType(DataType.DateTime)]
    public DateTime Fim { get; set; }

    [Required(ErrorMessage = "Tipo de atendimento é obrigatório.")]
    public TipoAtendimento TipoAtendimento { get; set; }

    public Paciente Paciente { get; set; }
    public Servico Servico { get; set; }
    public Medico Medico { get; set; }

    public static ValidationResult? ValidateFim(DateTime fim, ValidationContext context)
    {
        var atendimento = (Atendimento)context.ObjectInstance;

        return atendimento.Inicio >= fim ? new ValidationResult("Data de início deve ser menor que data de fim.") : ValidationResult.Success;
    }
}
