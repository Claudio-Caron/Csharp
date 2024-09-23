using PersistindoDadosComEntityFC.Database;
using ScreenSound.Menus;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistindoDadosComEntityFC.ArquivosBase.Codigos_do_Curso.ScreenSound.Menus;

internal class MenuExibirMusicaAnoLancamento:Menu
{
    public override void Executar(DAL<Artista> artistaDal)
    {
        base.Executar(artistaDal);
        Console.WriteLine("Ano de lançamento : ");
        int ano = int.Parse(Console.ReadLine()!);
        var musicaDal = new DAL<Musica>(new ScreenSoundContext());
        if (musicaDal.ListarPor(x => x.AnoLancamento == ano).Any())
        {
            Console.WriteLine($" -> Musicas registradas no Ano de {ano} : ");
            foreach (var musica in musicaDal.ListarPor(x => x.AnoLancamento == ano))
            {
                Console.WriteLine(musica.ToString());
            }
        }
        else
        {
            Console.WriteLine($"### Não existem Musicas registradas no ano de {ano}! ###");
        }

    }
}
