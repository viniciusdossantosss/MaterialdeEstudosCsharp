using MonitoramentoVeiculos;

Veiculo veiculo = new Veiculo("ABC-1234");
veiculo.AtualizarVelocidade(72.5);

Console.WriteLine("Veículo: " + veiculo.Placa);
Console.WriteLine("Velocidade atual: " + veiculo.VelocidadeAtual() + " km/h");