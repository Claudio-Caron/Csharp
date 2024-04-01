using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjetoBaseadoAlura;

internal class AlbumRequisitado
{
    [JsonPropertyName("artist")]
    public string? Artista {  get; set; }

    [JsonPropertyName("song")]
    public string? Musica { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("genre")]
    public string? GeneroMusical {  get; set; }
    public void ShowInformationsFromBand()
    {
        Console.Clear();
        Console.WriteLine($"Artista: {Artista}\nMusica: {Musica}\n Ano de Lancamento: {int.Parse(Ano)}\nGenero: {GeneroMusical}\n");
        Console.ReadKey();
    }
}
