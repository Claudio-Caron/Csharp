using Microsoft.Identity.Client;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistindoDadosComEntityFC.Database
{
    public class DAL<T> where T :  class
    {
        readonly ScreenSoundContext context;

        public DAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public enum Ordenacao{
            crescente,
            decrescente
        }

       
        
        public  void Alterar(T objeto)
        {
            if (context.Set<T>().Contains(objeto))
            {
                context.Set<T>().Update(objeto);
                context.SaveChanges();
                return;
            }
            throw new KeyNotFoundException();
        }

        public void Deletar(T objeto)
        {
            // Verifica se o objeto é do tipo Artista
            if (objeto is Artista artista)
            {
                // Carregar as músicas associadas ao artista
                var musicasAssociadas = context.Musicas.Where(m => m.Artista.Id == artista.Id).ToList();

                // Remover as músicas associadas
                context.Musicas.RemoveRange(musicasAssociadas);
                context.SaveChanges();  // Salvar alterações (excluir as músicas)

                // Agora pode remover o artista
                context.Set<T>().Remove(objeto);
                context.SaveChanges();  // Salvar alterações (excluir o artista)
             
            }
            else
            {
                // Se o objeto não for do tipo Artista, faz a exclusão normalmente
                context.Set<T>().Remove(objeto);
                context.SaveChanges();
            }
        }


        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }

        public IEnumerable<T>? Listar() =>
        context.Set<T>().ToList();

        public IEnumerable<T> ListarPor(Func<T, bool> func) =>
            context.Set<T>().Where(func).Distinct();
        public IEnumerable<T> ListarOrdenadoPor(Func<T, int> tipo, Ordenacao o)=>
            o == Ordenacao.crescente ?
            context.Set<T>().OrderBy(tipo).ToList():
            context.Set<T>().OrderByDescending(tipo).ToList();
        
        public T? RecuperarPor(Func<T, bool> objeto)=>
        context.Set<T>().FirstOrDefault(objeto);



    }
}
