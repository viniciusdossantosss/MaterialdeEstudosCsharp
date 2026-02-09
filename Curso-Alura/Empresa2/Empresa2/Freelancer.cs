namespace Empresa2;

public class Freelancer : Funcionario
{
    public decimal ValorProjeto { get; set; }
    public Freelancer(string nome, string cargo, decimal valorProjeto) : base(nome, cargo)
    {
        ValorProjeto = valorProjeto;
    }

    public override void ExibirInformacao()
    {
        base.ExibirInformacao();
        Console.WriteLine($"Projeto Atual: R${ValorProjeto:F2}");
    }
}