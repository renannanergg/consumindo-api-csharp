using System.Text.Json;
using API_Musica.Modelos;
using API_Musica.Filtros;

using (HttpClient client = new HttpClient() )
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //musicas[0].ExibirDetalhesDaMusica();
        
        //LinqFilter.FiltrarTodosGeneros(musicas);
        //LinqOrder.ExibirArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGenero(musicas,"pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas,"Michel Teló");
        //LinqFilter.FiltrarMusicasPorAno(musicas,2010);
        //LinqFilter.FiltrarMusicasEmCSharp(musicas);

        // var musicasPreferidasDoRenan = new MusicasPreferidas("Renan");
        // musicasPreferidasDoRenan.AdicionarMusicasFavoritas(musicas[377]);
        // musicasPreferidasDoRenan.AdicionarMusicasFavoritas(musicas[663]);
        // musicasPreferidasDoRenan.AdicionarMusicasFavoritas(musicas[600]);
        // musicasPreferidasDoRenan.AdicionarMusicasFavoritas(musicas[1333]);
        // musicasPreferidasDoRenan.AdicionarMusicasFavoritas(musicas[405]);

        // musicasPreferidasDoRenan.ExibirMusicasFavoritas();
        // musicasPreferidasDoRenan.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos o seguinte problema: {ex}");
    }
    
}
