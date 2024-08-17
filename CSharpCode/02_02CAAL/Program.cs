using _02_02CAAL;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string dados = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var Desserealizados = JsonSerializer.Deserialize<List<Pais>>(dados);
        Desserealizados[1].MostrarDados();
    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine($"Houve um erro na requisição : {ex.Message}\n");

    }
}