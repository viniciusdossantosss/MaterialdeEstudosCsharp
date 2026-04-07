using System.Text.Json;
using Screensound_AprendendoApi.Modelos;
using Screensound_AprendendoApi.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[134].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Green Day");

        var musicasPreferidasDoDaniel = new MusicasPreferidas("Vinicius");
        musicasPreferidasDoDaniel.AdicionarMusica(musicas[134]);
        musicasPreferidasDoDaniel.AdicionarMusica(musicas[135]);
        musicasPreferidasDoDaniel.AdicionarMusica(musicas[136]);
        musicasPreferidasDoDaniel.ExibirMusicasFavoritas();
        musicasPreferidasDoDaniel.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}