namespace Geometria;

public class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public void CalcularArea()
    {
        Console.WriteLine($"Area do Retangulo = {Altura * Largura:F2}");
    }
}