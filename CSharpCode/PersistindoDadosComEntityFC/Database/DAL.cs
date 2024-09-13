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
        public  IEnumerable<T> Listar()=>
            context.Set<T>().ToList();
        

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

        public T? RecuperarPor(Func<T, bool> objeto)
        {
            return context.Set<T>().FirstOrDefault(objeto);
        }
        
    }
}
