namespace Empresa2;

public class Interno : Funcionario
{
    public decimal Salario { get; }
    public Interno(string nome, string cargo, decimal salario) : base(nome, cargo)
    {
        Salario = salario;
    }
    
    public override void ExibirInformacao()
    {
        base.ExibirInformacao();
        Console.WriteLine($"Salário: R${Salario:F2}");
    }
}