using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _02_02CAAL;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string Nome {  get; set; }

    [JsonPropertyName("capital")]
    public string Capital { get; set;}

    [JsonPropertyName("pupulacao")]
    public string Populacao { get; set;}

    [JsonPropertyName("continente")]
    public string Continente {  get; set;}

    [JsonPropertyName("idioma")]
    public string Idioma { get; set;}
    public void MostrarDados()
    {
        Console.Clear();
        Console.WriteLine($"Dados do {Nome}: \n");
        Console.WriteLine($"Capital : {Capital}\nContinente : {Continente}\n População : {Populacao}\nIdioma Nativo : {Idioma}\n\n");
        Console.ReadKey();
    }
}
