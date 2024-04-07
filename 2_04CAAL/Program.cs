using _2_04CAAL;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string retornostring = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var ListaDeLivros = JsonSerializer.Deserialize<List<LivroJson>>(retornostring)!;
        ListaDeLivros[1].MostrarLivro();
    }catch (Exception ex)
    {
        Console.WriteLine("Erro ocorrido\n"+ex.Message+"\n");  
    }
}