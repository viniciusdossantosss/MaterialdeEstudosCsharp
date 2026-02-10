namespace PlataformaCursos;

public class Instrutor
{
    public string Nome { get; }
    public string Especialidade { get; }

    public Instrutor(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}