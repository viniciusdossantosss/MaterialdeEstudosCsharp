namespace GestVeiculos;

internal class Carro : Veiculo
{
    public int QtdPortas { get; private set; }
    public Carro(string marca, string modelo, int ano, int qtdPortas) : base(marca, modelo, ano)
    {
        QtdPortas = qtdPortas;
    }
}