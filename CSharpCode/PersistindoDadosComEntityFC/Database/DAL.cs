using Microsoft.Identity.Client;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistindoDadosComEntityFC.Database
{
    internal class DAL<T> where T :  class
    {
        protected readonly ScreenSoundContext context;

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
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
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
