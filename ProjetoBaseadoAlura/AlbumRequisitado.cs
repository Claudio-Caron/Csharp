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

    [JsonPropertyName("key")]
    public int Key {  get; set; }
    public string NewKey
    {
        get
        {
            return ListNewKeys[Key];
        }
    }

    public string[] ListNewKeys = {"C", "C#","D", "D#" ,"E", "F", "F#", "G", "Ab", "A", "Bb", "B"}; 
    //public void ShowInformationsFromJson()
    //{

    //}
    public void ShowInformationsFromBand()
    {
        Console.WriteLine(Key);
        Console.WriteLine($"Artista: {Artista}\nMusica: {Musica}\n Ano de Lancamento: {int.Parse(Ano)}\nGenero: {GeneroMusical}\nchave da Musica: {NewKey}");
    }

    

}
