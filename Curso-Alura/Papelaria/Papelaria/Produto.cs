namespace Papelaria;

public class Produto
{
    public string Nome { get; }
    private int QuantidadeEstoque { get; set; }

    public Produto(string nome, int quantidadeEstoque)
    {
        Nome = nome;
        QuantidadeEstoque = quantidadeEstoque;
    }

    public void Retirar(int quantidade)
    {
        if (QuantidadeEstoque > quantidade && QuantidadeEstoque > 0)
        {
            QuantidadeEstoque -=  quantidade;
            Console.WriteLine($"Retirada de {quantidade} unidades realizada com sucesso.");
        }
        else
        {
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidades.");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Quantidade: {QuantidadeEstoque}");
    }
}