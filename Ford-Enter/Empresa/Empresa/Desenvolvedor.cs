namespace Empresa;

public class Desenvolvedor : Funcionario
{
    private String LingugemPrincipal { get; }
    private int Bonus = 10;
    private decimal SalarioFinal { get; }
    public Desenvolvedor(string nome, decimal salario, string lingugemPrincipal) : base(nome, salario)
    {
        LingugemPrincipal = lingugemPrincipal;
        SalarioFinal = salario + (salario*(Bonus/100));
    }
    
    public void exibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Salario Base: " + Salario);
        Console.WriteLine("Salario com Bonus: " + SalarioFinal);
        Console.WriteLine("Linguagem Principal: " + LingugemPrincipal);
    }
}