namespace GerenciadorClinica.Domain.Entidades;

public class Paciente
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public string TipoSanguineo { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public string Endereco { get; set; }

    public ICollection<Atendimento> Atendimentos { get; set; }
}
