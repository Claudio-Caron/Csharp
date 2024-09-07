using PersistindoDadosComEntityFC.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicas : Menu
{
    public override void Executar(ArtistaDAL artistaDal)
    {
        base.Executar(artistaDal);
        ExibirTituloDaOpcao("Exibir detalhes do artista");
        Console.Write("Digite o nome do artista que deseja conhecer melhor: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (artistaDal.RecuperarPeloNome(nomeDoArtista) is not null)
        {
            Artista? artista = artistaDal.RecuperarPeloNome(nomeDoArtista);
            Console.WriteLine("\nDiscografia:");
            artista.ExibirDiscografia();
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
