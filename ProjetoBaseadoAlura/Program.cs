using ProjetoBaseadoAlura;
using System.Text.Json;
using System.Text.Json.Nodes;

using (HttpClient client = new HttpClient())
{
    try
    {
        string retorno = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<AlbumRequisitado>>(retorno);
        // for (int i = 0; i < musicas?.Count; i++)
        //  musicas[i].ShowInformationsFromBand();
        LinqFilter.FiltrarMusicaPorArtista(musicas!, "Linkin Park");

    }catch(Exception ex)
    {
        Console.WriteLine($"Erro de requisição: {ex.Message}");
    }
}