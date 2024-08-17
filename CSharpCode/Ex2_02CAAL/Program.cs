using _2_04CAAL;
using Ex2_02CAAL;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        List<LivroJson> ListaDeFilmes = JsonSerializer.Deserialize<List<LivroJson>>(resposta)!;
        List<string> FiltroDeLivros = LinqLivro.LivrosAposDoisMil(ListaDeFilmes);
        foreach (string autor in FiltroDeLivros)
        {
             Console.WriteLine(autor);
        }
     
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro na requição\n Erro ocorrido: "+ex.Message);
    }
}