using System.Text.RegularExpressions;

namespace GerenciadorClinica.Domain.Entidades;

public class Medico
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public string TipoSanguineo { get; set; }
    public string Endereco { get; set; }
    public string Especialidade { get; set; }
    public string RegistroCRM { get; set; }

    public ICollection<Atendimento>? Atendimentos { get; set; }

    #region VALIDAÇÃO CPF
    private bool IsCpfValid(string cpf)
    {
        if (cpf.Length != 11 || !Regex.IsMatch(cpf, @"^\d{11}$"))
            return false;

        if (new string(cpf[0], cpf.Length) == cpf)
            return false;

        int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        string tempCpf;
        string digito;
        int soma;
        int resto;

        tempCpf = cpf.Substring(0, 9);
        soma = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];


        resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        digito = resto.ToString();
        tempCpf = tempCpf + digito;
        soma = 0;

        for (int i = 0; i < 10; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];


        resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        digito = digito + resto.ToString();

        return cpf.EndsWith(digito);
    } 
    #endregion
}
