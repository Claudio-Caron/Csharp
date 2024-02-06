namespace Csharp_treinamento.Csharp_dominando_OO.Filmes;
class Filme
{
    public Filme(List<Artista> elenco, string titulo, int duracao)
    {
        Elenco = elenco;
        Titulo = titulo;
        Duracao = duracao;
    }
    public string Titulo { get; }
    public int Duracao  {get ;}
    public List<Artista> Elenco { get; }

}