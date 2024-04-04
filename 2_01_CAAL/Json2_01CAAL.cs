using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _2_01_CAAL;

internal class Json2_01CAAL
{
    [JsonPropertyName("title")]
    public string Titulo {  get; set; }

    [JsonPropertyName("fullTitle")]
    public string TituloCompleto {  get; set; }

    [JsonPropertyName("rank")]
    public string Rank { get; set; }
    [JsonPropertyName("image")]
    public string Imagem {  get; set; }
    public void MostrarDados()
    {
        Console.Clear();
        Console.WriteLine($"Título Completo: {TituloCompleto}\nTitulo: {Titulo}\n" +
            $"Posicao no Rank: {Rank}\n Imagem ilustrativa : {Imagem}");
        Console.ReadKey();

    }
    


}
