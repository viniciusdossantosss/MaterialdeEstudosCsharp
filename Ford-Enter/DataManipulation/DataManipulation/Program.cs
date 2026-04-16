using System.Collections;

var diasDaSemana = new DiasDaSeamana();

var carrinho = new List<Produto>()
{
    new Produto() { Nome = "Leite", Preco = 7.89 },
    new Produto() { Nome = "Manteiga", Preco = 3.45 }
};

foreach (var dia in diasDaSemana)
{
    
}


void PercorrendoComFor()
{
    for(int i = 0; i < carrinho.Count; i++)
    {
        Console.WriteLine($"Produto {carrinho[i].Nome} - R$ {carrinho[i].Preco}");
    }
}

void PercorrendoComForEach()
{
    foreach (var produto in carrinho)
    {
        Console.WriteLine($"Produto {produto.Nome}");
    }
}

class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class DiasDaSemanaEnumerator : IEnumerator<string>
{
    private object? _current;
    private int posicao = -1;
    private string[] dias = {"Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"};

    public bool MoveNext()
    {
        posicao++;
        return posicao < dias.Length;
    }

    public void Reset()
    {
        posicao = -1;
    }

    string IEnumerator<string>.Current => _current1;

    object? IEnumerator.Current => _current;

    public void Dispose()
    {
    }
}

class DiasDaSeamana : IEnumerable<string>
{
    
    public IEnumerator<string> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

