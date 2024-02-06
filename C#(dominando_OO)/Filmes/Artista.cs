namespace Csharp_treinamento.Csharp_dominando_OO.Filmes;

class Artista
{
    public List<string> Filmes { get; set; } = new();
    public string Nome {  get; }   
    public int idade;
    public Artista (string nome, int idade)
    {
        Nome = nome;   
        this.idade = idade; 
    }
    public void AdicionarFilme(string filme)
    {
        Filmes.Add(filme);
    }
    

}