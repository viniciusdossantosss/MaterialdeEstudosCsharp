namespace LojaOnline;

public class PagamentoBoleto : Pessoa, IPagamento
{
    public PagamentoBoleto(string nome, string email) : base(nome, email)
    {
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento via boleto para {Nome} - {Email}");
    }
}