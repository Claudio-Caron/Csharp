using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _2_03CAAL;

internal class JsonCarro
{
    [JsonPropertyName("marca")]
    public string Marca {  get; set; }

    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int Ano {  get; set; }
    public void MostrarDados()
    {
        Console.Clear();
        Console.WriteLine($"Dados do carro: \n {Marca}\n {Modelo} \nAno: {Ano}\n");
        Console.ReadKey();
    }

}
