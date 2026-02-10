namespace CentroTecnico;

public class PlacaMae
{
    public string Fabricante { get; }
    public string Socket { get; }

    public PlacaMae(string fabricante, string socket)
    {
        Fabricante = fabricante;
        Socket = socket;
    }
}