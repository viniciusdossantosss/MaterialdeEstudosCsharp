namespace Clube;

public class ClienteVIP : Pessoa 
{
    public string NivelFidelidade { get; }
    public string CodigoVIP { get; }
    
    public ClienteVIP(string nome, int idade, string codigoVip, string nivelFidelidade) : base(nome, idade)
    {
        CodigoVIP = codigoVip;
        NivelFidelidade = nivelFidelidade;
    }

    public void ExibirDadosClienteVip()
    {
        Console.WriteLine($"Bem-vindo, cliente VIP: {Nome}");  
        Console.WriteLine($"Idade: {Idade}");  
        Console.WriteLine($"Nível de Fidelidade: {NivelFidelidade}");  
        Console.WriteLine($"Código VIP: {CodigoVIP}\n");
    }
}