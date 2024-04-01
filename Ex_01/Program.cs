using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    try
    {
        Console.WriteLine($"Retorno da API de pokemon: \n {resposta}");
    }catch(Exception ex)
    {
        Console.WriteLine("Erro no retorno da API: "+ ex.Message);
    }
}