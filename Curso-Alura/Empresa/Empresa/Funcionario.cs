namespace Empresa;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public void Promover(string cargo)
    {
        if (cargo == Cargo){
            Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual.");
        }
        else
        {
            Console.WriteLine("Promoção realizada com sucesso!");
        }
    }

    public void InformacoesFuncionario()
    {
        Console.WriteLine($"Funcionário: {Nome}");
        Console.WriteLine($"Cargo Atual: {Cargo}");
    }
}