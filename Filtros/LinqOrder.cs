using API_Musica.Modelos;

namespace API_Musica.Filtros;

internal class LinqOrder
{
    public static void ExibirArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine(" *** Lista de Artistas *** ");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"-{artista}");
        }
    }
}
