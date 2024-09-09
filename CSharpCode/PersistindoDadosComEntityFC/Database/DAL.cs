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
        protected readonly ScreenSoundContext con;

        public  IEnumerable<T> Listar()=>
            con.Set<T>().ToList();
        

        public  void Alterar(T objeto)
        {
            if (con.Set<T>().Contains(objeto))
            {
                con.Set<T>().Update(objeto);
                con.SaveChanges();
                return;
            }
            throw new KeyNotFoundException();
        }

        public void Deletar(T objeto)
        {
            con.Set<T>().Remove(objeto);
            con.SaveChanges();
        }

        public void Adicionar(T objeto)
        {
            con.Set<T>().Add(objeto);
            con.SaveChanges();
        }

        public T? RecuperarPor(Func<T, bool> objeto)
        {
            return con.Set<T>().FirstOrDefault(objeto);
        }
        
    }
}
