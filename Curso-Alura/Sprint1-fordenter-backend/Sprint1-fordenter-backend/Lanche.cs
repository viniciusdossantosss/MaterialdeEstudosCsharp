namespace Sprint1_fordenter_backend;

public class Lanche : ItemCardapio
{
    public List<string> IngredientesExtras { get; set; }
    public decimal PrecoPorExtra { get; set; } = 2.00m; // Preço fixo por ingrediente extra

    public Lanche(int codigo, string descricao, decimal precoBase) : base(codigo, descricao, precoBase)
    {
        IngredientesExtras = new List<string>();
    }

    public void AdicionarExtra(string ingrediente)
    {
        IngredientesExtras.Add(ingrediente);
    }

    public override decimal CalcularPreco()
    {
        return PrecoBase + (IngredientesExtras.Count * PrecoPorExtra);
    }

    public override string ToString()
    {
        string extras = IngredientesExtras.Count > 0 ? $" (Extras: {string.Join(", ", IngredientesExtras)})" : "";
        return base.ToString() + extras;
    }
}
