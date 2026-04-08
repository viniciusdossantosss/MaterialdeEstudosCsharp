namespace Empresa;

public class Gerente : Funcionario
{
    private int Bonus = 20;
    private decimal SalarioFinal { get; }
    private String Departamento { get; }
    
    public Gerente(string nome, decimal salario, string departamento) : base(nome, salario)
    {
        Departamento = departamento;
        SalarioFinal = salario + (salario*(Bonus/100));
    }

    public void exibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Salario Base: " + Salario);
        Console.WriteLine("Salario com Bonus: " + SalarioFinal);
        Console.WriteLine("Departamento: " + Departamento);
    }
    
    
    
}