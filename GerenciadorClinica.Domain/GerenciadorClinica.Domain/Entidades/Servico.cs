namespace GerenciadorClinica.Domain.Entidades;

public class Servico
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int Duracao { get; set; }

    public ICollection<Atendimento> Atendimentos { get; set; }
}
