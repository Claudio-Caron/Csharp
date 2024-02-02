/*O episódio deve ter um número, um título,
 * uma duração e um resumo. O resumo do episódio
 * será concatenado com os valores de número,
 * título, duração e convidados do episódio.*/
class Episodio
{
    public List<string> Convidados {  get; set; }=new List<string>();
    private string Titulo { get; }
    private string Resumo { get; }
    private int Numero { get;  }
    public Episodio()
    {
        Console.Clear();
        Console.WriteLine("Qual o Titulo do episódio?");
        Titulo = Console.ReadLine()!;
        Console.WriteLine("Cite o resumo do Ep:");
        Resumo = Console.ReadLine()!;
        Console.WriteLine("Qual o numero do Ep?");
        Numero = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Pressione qualquer tecla para continuar:");
        Console.ReadKey();
        Console.Clear();
    }
    private string ResumoEp => "Titulo do ep: " + Titulo + "\nEp Numero " + Numero + "\nRESUMO DO EP: \n " + Resumo;
    public void ResumoDoEp()
    {
        Console.Clear();
        string imprimir = ResumoEp;
        foreach (var item in Convidados)
        {
            imprimir += "\n"+item;
        }
        Console.WriteLine(imprimir+"\n\n Pressione qualquer tecla para continuar:");
        Console.ReadKey();
    }
    public void AdicionarConvidados()
    {
        Console.Clear();
        Console.WriteLine("Adicione um convidado especial:");
        string conv= Console.ReadLine()!;
        Convidados.Add(conv);
        Console.WriteLine("Convidado adicionado com sucesso!");
        Thread.Sleep(3000);
        Console.Clear();
    }
}

