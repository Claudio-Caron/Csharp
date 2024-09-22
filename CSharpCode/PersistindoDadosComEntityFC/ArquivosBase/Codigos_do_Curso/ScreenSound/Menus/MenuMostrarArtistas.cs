using PersistindoDadosComEntityFC.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarArtistas  : Menu
{
    public override void Executar(DAL<Artista> artistaDal)
    {
        base.Executar(artistaDal);
        ExibirTituloDaOpcao(" - > Exibindo todos os artistas registradas na nossa aplicação");
        int i = 0;
        
            foreach (var artista in artistaDal.Listar()!)
            {
                i++;
                Console.WriteLine($"Artista: {artista.ToString()}");
            }
            if (i == 0)
                Console.WriteLine("Não existem Artistas cadastrados ! ");

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
