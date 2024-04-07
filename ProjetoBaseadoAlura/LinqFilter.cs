using System.Linq;

namespace ProjetoBaseadoAlura;

internal class LinqFilter
{
    // filtrar as músicas de um artista

    public static void FiltrarMusicaPorArtista(List<AlbumRequisitado> albuns, string artista)
    { 
        var artistasIguais = albuns.Select(x=>x.Artista!.Equals(artista)).ToList();
        List<string> lista = new List<string>();    

        foreach (var corredor in artistasIguais)
        {
            int i = 0;
            if (corredor)
            {
                lista.Add(albuns[i].Musica!);
            }
            i++;
        }
        Console.WriteLine($"Percorrendo Musicas iguais do artista {artista}\n");
        foreach (string percorrer in lista)
        {
            Console.WriteLine(percorrer);
        }
    }
}

