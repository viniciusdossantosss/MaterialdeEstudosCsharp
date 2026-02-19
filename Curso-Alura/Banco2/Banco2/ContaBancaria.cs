namespace Banco2;

public class ContaBancaria
{
    public string Titular { get; }
    private decimal Saldo { get; set; }

    public ContaBancaria(string titular, decimal saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public void
        Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            SegurancaConta seguranca = new SegurancaConta();
            if (seguranca.ValidarSaque(valor))
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
            }
            else
            {
                Console.WriteLine("Saque negado pela politica de segurança.");
            }
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para o saque.");
        }
    
        
    }
}