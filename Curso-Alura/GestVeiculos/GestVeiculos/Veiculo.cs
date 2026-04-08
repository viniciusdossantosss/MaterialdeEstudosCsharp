namespace GestVeiculos;

public class Veiculo
{
    public string Marca { get; private set; }
    public string Modelo { get; private set; }
    public int Ano { get; private set; }

    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
    

    public string MostrarDados()
    {
        return $"Veiculo: {Marca} - {Modelo} - {Ano}";
    }
}