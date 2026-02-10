namespace CentroTecnico;

public class Processador
{
    public string Marca { get; }
    public string Modelo { get; }
    
    public Processador(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
}
