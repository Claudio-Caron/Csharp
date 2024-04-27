using ProjetoBaseadoAlura;
using System.Text.Json;
using System.Text.Json.Nodes;

using (HttpClient client = new HttpClient())
{
    try
    {
        string retorno = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<AlbumRequisitado>>(retorno);
        //for (int i = 0; i < musicas?.Count; i++)
        //{
        //    musicas[i].ShowInformationsFromBand();
        //    Console.ReadKey();
        //    Console.Clear();
        //}
        // LinqFilter.FiltrarMusicaPorArtista(musicas!, "Linkin Park");
        Console.Write("Qual a Classificação da Música deseja Buscar dentre as seguintes?\n |");
        
            foreach (string item2 in musicas[0].ListNewKeys)
            {
                Console.Write(item2+"|");
            }
        Console.WriteLine("");


        string y = Console.ReadLine()!;
        if (musicas.Select(x => x.NewKey).Contains(y))
        {
            var ListaFiltrada = musicas.Where(x => x.NewKey.Equals(y)).Select(x=>x.Musica).ToList();
            for(int i = 0; i < ListaFiltrada.Count; i++)
            {

                Console.WriteLine(ListaFiltrada[i]+"\n");
            }
        }
        else
        {

            Console.WriteLine("Nao exite uma música registrada com essa classificação");
        }
    

    }catch(Exception ex)
    {
        Console.WriteLine($"Erro de requisição: {ex.Message}");
    }
}