using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _2_04CAAL;

public class LivroJson
{
    [JsonPropertyName("titulo")]
    public string? Titulo {  get; set; }

    [JsonPropertyName("autor")]
    public string? Autor {  get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int AnoDePublicacao {  get; set; }

    [JsonPropertyName("genero")]
    public string? Genero { get; set; }

    public void MostrarLivro()
    {
        Console.Clear();
        Console.WriteLine($"Livro : {Titulo}\nAutor : {Autor}\nGenero : {Genero}\nAno de Publicacao: {AnoDePublicacao}");
        Console.WriteLine(Genero);
        Console.ReadKey();
    }
}
