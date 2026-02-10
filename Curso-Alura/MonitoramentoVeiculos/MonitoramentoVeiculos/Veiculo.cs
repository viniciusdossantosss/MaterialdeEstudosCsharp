namespace MonitoramentoVeiculos;

internal class Veiculo
{
    public string Placa { get; }
    private double velociadeAtual;

    public Veiculo(string placa)
    {
        Placa = placa;
    }

    public void AtualizarVelocidade(double novaVelocidade)
    {
        velociadeAtual = novaVelocidade;
    }

    public double VelocidadeAtual()
    {
        return velociadeAtual;
    }
    
    
}