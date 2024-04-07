using System.Linq;

namespace ProjetoBaseadoAlura;

internal class LinqFilter
{
    // filtrar as músicas de um artista

    public static void FiltrarMusicaPorArtista(List<AlbumRequisitado> albuns, string artista)
    {
        try
        {
            var musicasDoArtista = albuns.Where(x => x.Artista!.Equals(artista))
                .Select(x => x.Musica).ToList();
            Console.WriteLine($"Musicas do Artista {artista}: ");
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine(" -> " + musica + "\n");
            }
        } catch 
        {
            Console.WriteLine("O artista escolhido não possui músicas cadastradas");
        }
    }
}

