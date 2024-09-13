using PersistindoDadosComEntityFC.Database;
using ScreenSound.Modelos;
using System.Linq;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicas : Menu
{
    public override void Executar(DAL<Artista> artistaDal)
    {
        base.Executar(artistaDal);
        ExibirTituloDaOpcao(" -> Mostrar Musica por informacao especifica");
        Console.Write("Gostaria de saber as musicas por meio de qual informacao do artista? ");
        Console.WriteLine("1 - Por nome");
        Console.WriteLine("2 - Por ID");

        int option = int.Parse(Console.ReadLine()!);
        if (option == 1)
        {
            Console.WriteLine("Insira o nome do Artista que gostaria de saber as musicas : ");
            string nome = Console.ReadLine()!;

            if (artistaDal.RecuperarPor(a=>a.Nome.Equals(nome)) is not null)
            {
                MensagemBemSucedida(artistaDal.RecuperarPor(x => x.Nome.Equals(nome))!);
            }
            else
            {
                MensagemErro<string>(nome);
            }
        }
        else if (option == 2)
        {
            Console.WriteLine("Insira o Id do Artista que deseja Buscar : ");
            int id = int.Parse(Console.ReadLine()!);
            if (artistaDal.RecuperarPor(x=>x.Id==id) is not null)
            {
                MensagemBemSucedida(artistaDal.RecuperarPor(x=>x.Id==id)!);
                
            }
            else
            {
                MensagemErro<int>(id);
            }
        }else
        {
            Console.WriteLine("*** OPCAO INVALIDA ***");
        }
    }
    private void MensagemErro<T>(T identificador)
    {
        Console.WriteLine($"\nIdentificado {identificador} não registrado nos artistas!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
    private void MensagemBemSucedida(Artista artista)
    {
        Console.WriteLine("\nDiscografia:");
        artista?.ExibirDiscografia();
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

}
