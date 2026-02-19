namespace DadosMedicos;

public class Paciente
{
    public string Nome { get; }
    public int Idade { get; }

    public Paciente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}