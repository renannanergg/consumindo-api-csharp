using API_Musica.Modelos;
using System.Text.Json;


internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new ();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine(" ***Musicas Favoritas*** ");
        foreach (var musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($"-{musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new {
            nome = Nome,
            musicas = ListaDeMusicasPreferidas,

        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo,json);
        Console.WriteLine($"Arquivo JSON criado com sucesso ! {Path.GetFullPath(nomeDoArquivo)}");

    }
}