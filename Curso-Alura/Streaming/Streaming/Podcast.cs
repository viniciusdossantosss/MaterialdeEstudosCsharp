namespace Streaming;

public class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nomeDoPodcast)
    {
        Host = host;
        NomeDoPodcast = nomeDoPodcast;
    }
    public string Host { get; }
    public string NomeDoPodcast { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Nome do Podcast: {NomeDoPodcast}");

        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }
    
}