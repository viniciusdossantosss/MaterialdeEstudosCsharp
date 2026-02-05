namespace AgenciaViagens;

public class Passagem
{
    public string Passageiro { get; }
    public string Destino { get; }

    public Passagem(string destino, string passageiro)
    {
        Destino = destino;
        Passageiro = passageiro;
    }

    public void ImprimirPassagem()
    {
        Console.WriteLine($"Passageiro: {Passageiro}");
        Console.WriteLine($"Destino: {Destino}");
    }
}