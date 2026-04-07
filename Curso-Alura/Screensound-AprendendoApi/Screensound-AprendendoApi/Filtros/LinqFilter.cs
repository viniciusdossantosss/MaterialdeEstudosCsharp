sing Screensound_AprendendoApi.Modelos;
namespace Screensound_AprendendoApi.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => 
            musica.Genero.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"Artista do gênero musical {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).ToList();
        Console.WriteLine($"Musicas com a tonalidade {tonalidade}");
        foreach (var musica in musicasPorTonalidade) 
        {
            Console.WriteLine($"- {musica.Nome} - {musica.Artista}");
        }
    }
}

