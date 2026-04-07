namespace Sprint1_fordenter_backend;

public class Pedido
{
    private List<ItemCardapio> _itens;

    public Pedido()
    {
        _itens = new List<ItemCardapio>();
    }

    public void AdicionarItem(ItemCardapio item)
    {
        _itens.Add(item);
    }

    public void RemoverItem(int codigo)
    {
        var item = _itens.FirstOrDefault(i => i.Codigo == codigo);
        if (item != null)
        {
            _itens.Remove(item);
        }
    }

    public decimal CalcularTotal()
    {
        return _itens.Sum(i => i.CalcularPreco());
    }

    public void ExibirPedido()
    {
        Console.WriteLine("\n--- Resumo do Pedido ---");
        foreach (var item in _itens)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine($"\nTotal: R$ {CalcularTotal():F2}");
    }
}
