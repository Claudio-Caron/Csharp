//Modelar e desserializar a classe Filme,
//que pode ser encontrada no endpoint disponibilizado
using _2_01_CAAL;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var Dados = JsonSerializer.Deserialize<List<Json2_01CAAL>>(json);
        Dados[0].MostrarDados();
    }catch(Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro na requisição: {ex.Message}");
    }
}