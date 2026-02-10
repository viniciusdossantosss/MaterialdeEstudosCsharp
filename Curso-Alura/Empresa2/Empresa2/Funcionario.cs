namespace Empresa2;

public class Funcionario
{
    public string Nome { get; }
    public string Cargo { get; }

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public virtual void ExibirInformacao()
    {
        Console.WriteLine($"\nFuncionaria - {Nome}");
        Console.WriteLine($"Cargo - {Cargo}");
    }
}