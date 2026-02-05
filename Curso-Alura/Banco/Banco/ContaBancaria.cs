namespace Banco;

public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public decimal Saldo { get; set; }

    public ContaBancaria(string numeroConta, decimal saldo)
    {
        NumeroConta = numeroConta;
        Saldo = saldo;
    }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }
    
    public void ImprimirSaldo()
    {
        Console.WriteLine($"Conta: {NumeroConta}");
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
    }
}