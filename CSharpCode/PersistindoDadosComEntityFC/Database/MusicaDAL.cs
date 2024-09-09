using Microsoft.EntityFrameworkCore;
using ScreenSound.Menus;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistindoDadosComEntityFC.Database
{
    internal class MusicaDAL: DAL<Musica>
    {
        private readonly ScreenSoundContext context;

        public MusicaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }
        public override IEnumerable<Musica> Listar()
        {

            return context.Musicas.ToList();

        }

        public override void Adicionar(Musica musica)
        {
            context.Musicas.Add(musica);
            context.SaveChanges();

        }

        public void Atualizar(Musica musica)
        {
            context.Musicas.Update(musica);
            context.SaveChanges();

        }

        public override void Deletar(Musica musica)
        {
            context.Musicas.Remove(musica);
            context.SaveChanges();

        }

        public override Musica? RecuperarPeloNome(string nome)
        {
            return context.Musicas.FirstOrDefault(a => a.Nome.Equals(nome));

        }
        public override void Alterar(Musica objeto)
        {
            if (context.Musicas.Contains(objeto))
            {
                context.Musicas.Update(objeto);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Musica nao encontrada");
            }
        }
    }

}

