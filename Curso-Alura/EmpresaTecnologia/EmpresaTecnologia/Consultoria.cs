namespace EmpresaTecnologia;

public class Consultoria : IServico
{
    

    public string Servico { get; }
    public Funcionario Funcionario { get; }
    
    public Consultoria(string servico, Funcionario funcionario)
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