namespace LojaOnline;

public class PagamentoCredito : Pessoa, IPagamento
{
    public PagamentoCredito(string nome, string email) : base(nome, email)
    {
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento com cartão de crédito para {Nome} - {Email}");
    }
}