/*O método ExibirDetalhes() deve mostrar o nome do podcast
 * e o host na primeira linha, seguido pela lista de episódios
 * ordenados por sequência e por fim o total de episódios.*/
class PodCast
{
    public List<Episodio> Episodios { get; set; }
    public string Nome {  get;  }
    public string Host { get; } 
    public PodCast(string nome, string host) 
    {
        Nome = nome;    
        Host = host;
    }
    public void ExibirDetalhes()
    {
        Console.Clear();
        Console.WriteLine("Podcast: " + Nome+ "\n Host: "+ Host+ "\n\n\n");
        Console.WriteLine("LISTA DE EPISODIOS:");  
        foreach (var item in Episodios)
        {
            Console.WriteLine(item.Numero+ "  "+ item.Titulo);
        }
        Console.WriteLine("\n"+ Episodios.Count);

    }
    public void AdicionarEp()
    {
        Episodio ep = new Episodio();
        Episodios.Add(ep);
    }
}