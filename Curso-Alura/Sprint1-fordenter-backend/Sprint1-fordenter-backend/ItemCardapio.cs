namespace Sprint1_fordenter_backend;

public abstract class ItemCardapio : IItemCardapio
{
    public int Codigo { get; set; }
    public string Descricao { get; set; }
    public decimal PrecoBase { get; set; }

    public ItemCardapio(int codigo, string descricao, decimal precoBase)
    {
        Codigo = codigo;
        Descricao = descricao;
        PrecoBase = precoBase;
    }

    public abstract decimal CalcularPreco();

    public override string ToString()
    {
        return $"{Codigo} - {Descricao} - R$ {CalcularPreco():F2}";
    }
}
