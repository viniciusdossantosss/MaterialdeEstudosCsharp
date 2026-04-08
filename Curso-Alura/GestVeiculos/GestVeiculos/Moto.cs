namespace GestVeiculos;

public class Moto : Veiculo
{
    public int Guidão { get; set; }
    public Moto(string marca, string modelo, int ano, int guidão) : base(marca, modelo, ano)
        {
            Guidão = guidão;
        }
}