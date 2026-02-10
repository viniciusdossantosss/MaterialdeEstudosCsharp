namespace EmpresaTecnologia;

public class Manutencao : IServico
{
    public string Servico { get; }
    public Funcionario Funcionario { get; }
    
    public Manutencao(string servico, Funcionario funcionario)
    {
        Servico = servico;
        Funcionario = funcionario;
    }
    
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de manutenção: {Servico}");
        Console.WriteLine($"Responsável: {Funcionario.Nome} - Departamento: {Funcionario.Departamento}");
    }
}