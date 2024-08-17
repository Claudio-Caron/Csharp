//Modelar e desserializar a classe Carro,
//que pode ser encontrada no endpoint disponibilizado
using _2_03CAAL;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var ListaDeCarros = JsonSerializer.Deserialize<List<JsonCarro>>(resposta);
        ListaDeCarros[0].MostrarDados();
    }catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}