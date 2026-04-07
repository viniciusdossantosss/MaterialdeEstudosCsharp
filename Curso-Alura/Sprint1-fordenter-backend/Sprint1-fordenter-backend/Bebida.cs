namespace Sprint1_fordenter_backend;

public class Bebida : ItemCardapio
{
    public string Tamanho { get; set; } // 300ml, 500ml, 1L

    public Bebida(int codigo, string descricao, decimal precoBase, string tamanho) : base(codigo, descricao, precoBase)
    {
        Tamanho = tamanho;
    }

    public override decimal CalcularPreco()
    {
        // Ajuste de preço baseado no tamanho
        switch (Tamanho.ToLower())
        {
            case "500ml":
                return PrecoBase * 1.5m;
            case "1l":
                return PrecoBase * 2.0m;
            default: // 300ml ou padrão
                return PrecoBase;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $" - {Tamanho}";
    }
}
