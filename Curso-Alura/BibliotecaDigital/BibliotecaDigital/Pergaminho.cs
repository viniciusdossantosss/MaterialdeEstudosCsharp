namespace BibliotecaDigital;

public class Pergaminho : ItemDigital
{
    public string Conteudo { get; }
    
    public Pergaminho(string titulo, string conteudo) : base(titulo)
    {
        Conteudo = conteudo;
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine("Detalhes do Pergaminho:");
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Descrição: {Conteudo}");
    }
    

    
}