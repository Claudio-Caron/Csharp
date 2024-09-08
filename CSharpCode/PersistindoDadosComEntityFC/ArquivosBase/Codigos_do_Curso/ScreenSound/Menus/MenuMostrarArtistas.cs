using PersistindoDadosComEntityFC.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarArtistas : Menu
{
    public override void Executar(ArtistaDAL artistaDal)
    {
        
        base.Executar(artistaDal);
        ExibirTituloDaOpcao("Exibindo todos os artistas registradas na nossa aplicação");
        
        foreach (Artista artista in artistaDal.ListarArtista())
        {
            Console.WriteLine($"Artista: {artista.ToString()}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
